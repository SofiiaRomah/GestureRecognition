using System;
using System.Collections.Generic;
using System.Linq;
using MathNet.Numerics;
using MathNet.Numerics.Distributions;
using MathNet.Numerics.LinearAlgebra;

namespace GestureRecognition.NeuralNetwork
{
    public class NeuralNetwork
    {
        private readonly int _inputLayerNeuronesCount; // кількість нейронів на вхідному шарі
        private readonly int _hiddenLayerNeuronesCount; // кількість нейронів на прихованому шарі
        private readonly int _outputLayerNeuronesCount; // кількість нейронів на вихідному шарі
        private readonly double _learningRate; // швидкість навчання
        private readonly int _epochs; // кількість епох

        private Matrix<double> _inputHiddenWeightMatrix;
        private Matrix<double> _hiddenOutputWeightMatrix;

        public NeuralNetwork(int inputLayerNeuronesCount,
            int hiddenLayerNeuronesCount,
            int outputLayerNeuronesCount,
            double learningRate,
            int epochs)
        {
            _inputLayerNeuronesCount = inputLayerNeuronesCount;
            _hiddenLayerNeuronesCount = hiddenLayerNeuronesCount;
            _outputLayerNeuronesCount = outputLayerNeuronesCount;
            _learningRate = learningRate;
            _epochs = epochs;

            var inputHiddenWeightMatrixNormalDistribution = new Normal(0, Math.Pow(hiddenLayerNeuronesCount, -0.5));
            var hiddenOutputWeightMatrixNormalDistribution = new Normal(0, Math.Pow(outputLayerNeuronesCount, -0.5));

            _inputHiddenWeightMatrix = Matrix<double>
                .Build
                .Random(hiddenLayerNeuronesCount, inputLayerNeuronesCount, inputHiddenWeightMatrixNormalDistribution);
            _hiddenOutputWeightMatrix = Matrix<double>
                .Build
                .Random(outputLayerNeuronesCount, hiddenLayerNeuronesCount, hiddenOutputWeightMatrixNormalDistribution);
        }

        // метод для тренування нейромережі
        public void Train(string[] trainInputLines)
        {
            for (int e = 0; e < _epochs; e++)
            {
                foreach (var trainInputLine in trainInputLines)
                {
                    var trainInputLineDoubleArray = Array
                            .ConvertAll(trainInputLine.Split(','), double.Parse)
                            .ToArray();

                    var inputMatrix = Matrix<double>
                        .Build
                        .Dense(1, _inputLayerNeuronesCount, trainInputLineDoubleArray.Skip(1).Select(x => (x / 255 * 0.99) + 0.01).ToArray())
                        .Transpose();

                    var targetMatrix = Matrix<double>
                        .Build
                        .Dense(1, _outputLayerNeuronesCount, (rowIndex, columnIndex) => columnIndex == trainInputLineDoubleArray.First() ? 0.99 : 0.01)
                        .Transpose();

                    var hiddenLayerInputSignals = _inputHiddenWeightMatrix.Multiply(inputMatrix);
                    var hiddenLayerOutputSignals = Matrix<double>
                        .Build
                        .Dense(hiddenLayerInputSignals.RowCount, 1, (rowIndex, columnIndex) => SpecialFunctions.Logistic(hiddenLayerInputSignals[rowIndex, columnIndex]));

                    var finalLayerInputSignals = _hiddenOutputWeightMatrix.Multiply(hiddenLayerOutputSignals);
                    var finalLayerOutputSignals = Matrix<double>
                        .Build
                        .Dense(finalLayerInputSignals.RowCount, 1, (rowIndex, columnIndex) => SpecialFunctions.Logistic(finalLayerInputSignals[rowIndex, columnIndex]));

                    var outputLayerErrors = targetMatrix - finalLayerOutputSignals;
                    var hiddenLayerErrors = _hiddenOutputWeightMatrix.Transpose().Multiply(outputLayerErrors);

                    _hiddenOutputWeightMatrix += _learningRate * (
                            Matrix<double>
                            .Build
                            .Dense(_outputLayerNeuronesCount, 1, (rowIndex, columnIndex) => outputLayerErrors[rowIndex, columnIndex] * finalLayerOutputSignals[rowIndex, columnIndex] * (1 - finalLayerOutputSignals[rowIndex, columnIndex]))
                        ).Multiply(hiddenLayerOutputSignals.Transpose());

                    _inputHiddenWeightMatrix += _learningRate * (
                            Matrix<double>
                            .Build
                            .Dense(_hiddenLayerNeuronesCount, 1, (rowIndex, columnIndex) => hiddenLayerErrors[rowIndex, columnIndex] * hiddenLayerOutputSignals[rowIndex, columnIndex] * (1 - hiddenLayerOutputSignals[rowIndex, columnIndex]))
                        ).Multiply(inputMatrix.Transpose());
                }
            }
        }

        // метод для розпізнавання вхідного зображення
        public Matrix<double> Query(List<byte> inputArray)
        {
            var inputMatrix = Matrix<double>
                .Build
                .Dense(1, _inputLayerNeuronesCount, inputArray.Select(x => (x / 255 * 0.99) + 0.01).ToArray())
                .Transpose();

            var hiddenLayerInputSignals = _inputHiddenWeightMatrix.Multiply(inputMatrix);
            var hiddenLayerOutputSignals = Matrix<double>
                .Build
                .Dense(hiddenLayerInputSignals.RowCount, 1, (rowIndex, columnIndex) => SpecialFunctions.Logistic(hiddenLayerInputSignals[rowIndex, columnIndex]));

            var finalLayerInputSignals = _hiddenOutputWeightMatrix.Multiply(hiddenLayerOutputSignals);
            var finalLayerOutputSignals = Matrix<double>
                .Build
                .Dense(finalLayerInputSignals.RowCount, 1, (rowIndex, columnIndex) => SpecialFunctions.Logistic(finalLayerInputSignals[rowIndex, columnIndex]));

            return finalLayerOutputSignals;
        }
    }
}