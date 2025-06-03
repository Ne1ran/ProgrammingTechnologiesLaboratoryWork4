namespace ProgrammingTechnologiesLaboratoryWork4;

public partial class MainForm : Form
{
    private double _maxX;
    private double _minX;
    private double _maxY;
    private double _minY;
    private double _stepX;
    private double _stepY;
    private int _cycleSize;
    private double[] _arrayOfArgumentsX = null!;
    private double[] _arrayOfArgumentsY = null!;
    private double[,] _arrayOfValuesZ = null!;
    private DateTime _startTime;
    private DateTime _finishTime;
    private TimeSpan _durationOfProcess;
    private CancellationTokenSource? _cancellationTokenSource;

    public MainForm()
    {
        InitializeComponent();
        _startTime = DateTime.Now;
        _finishTime = DateTime.Now;
    }

    private async void CalculateButton_Click(object sender, EventArgs e)
    {
        try {
            if (!ValidateInputs()) {
                return;
            }

            progressBar1.Value = 0;
            CalculateButton.Enabled = false;
            CancelButton.Enabled = true;

            _startTime = DateTime.Now;
            _cancellationTokenSource = new();

            await CalculateAsync(_cancellationTokenSource.Token);

            _finishTime = DateTime.Now;
            _durationOfProcess = _finishTime - _startTime;
            ProcessTimeLabel.Text = $"Время выполнения: {_durationOfProcess.TotalSeconds:F2} сек";
        } catch (OperationCanceledException) {
            MessageBox.Show("Вычисление было отменено", "Отмена", MessageBoxButtons.OK, MessageBoxIcon.Information);
        } catch (Exception ex) {
            MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        } finally {
            CalculateButton.Enabled = true;
            CancelButton.Enabled = false;
            _cancellationTokenSource?.Dispose();
            _cancellationTokenSource = null;
        }
    }

    private void CancelButton_Click(object sender, EventArgs e)
    {
        _cancellationTokenSource?.Cancel();
    }

    private bool ValidateInputs()
    {
        if (!double.TryParse(MinXTextBox.Text, out _minX) || !double.TryParse(MaxXTextBox.Text, out _maxX)
            || !double.TryParse(MinYTextBox.Text, out _minY) || !double.TryParse(MaxYTextBox.Text, out _maxY)
            || !double.TryParse(StepXTextBox.Text, out _stepX) || !double.TryParse(StepYTextBox.Text, out _stepY)) {
            MessageBox.Show("Пожалуйста, введите корректные числовые значения", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        if (!(_minX >= _maxX) && !(_minY >= _maxY) && !(_stepX <= 0) && !(_stepY <= 0)) {
            return true;
        }
        
        MessageBox.Show("Пожалуйста, проверьте введенные значения:\n" + "- Минимальные значения должны быть меньше максимальных\n" + "- Шаги должны быть положительными",
                        "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return false;

    }

    private async Task CalculateAsync(CancellationToken cancellationToken)
    {
        _cycleSize = (int) (Math.Max((_maxX - _minX) / _stepX, (_maxY - _minY) / _stepY)) + 1;
        _arrayOfArgumentsX = new double[_cycleSize];
        _arrayOfArgumentsY = new double[_cycleSize];
        _arrayOfValuesZ = new double[_cycleSize, _cycleSize];

        for (int i = 0; i < _cycleSize; i++) {
            _arrayOfArgumentsX[i] = _minX + i * _stepX;
            _arrayOfArgumentsY[i] = _minY + i * _stepY;
        }

        Progress<int> progress = new(value => progressBar1.Value = value);
        await Task.Run(() => CalculateValues(progress, cancellationToken), cancellationToken);

        await SaveResultsToFileAsync("C:\\Save\\results.txt", cancellationToken);
    }

    private void CalculateValues(IProgress<int> progress, CancellationToken cancellationToken)
    {
        for (int i = 0; i < _cycleSize; i++) {
            for (int j = 0; j < _cycleSize; j++) {
                cancellationToken.ThrowIfCancellationRequested();
                _arrayOfValuesZ[i, j] = Function13(_arrayOfArgumentsX[i], _arrayOfArgumentsY[j]);
            }
            progress.Report((i + 1) * 100 / _cycleSize);
        }
    }

    private double Function13(double x, double y)
    {
        double numerator = Math.Exp(x) * (Math.Sin(y) - Math.Pow(Math.Cos(y), 2));
        double denominator = Math.Pow(Math.Sin(x), 2) + Math.Cos(x);
        return numerator / denominator;
    }

    private async Task SaveResultsToFileAsync(string filePath, CancellationToken cancellationToken)
    {
        await using var writer = new StreamWriter(filePath);
        for (int i = 0; i < _cycleSize; i++) {
            var line = new System.Text.StringBuilder();
            for (int j = 0; j < _cycleSize; j++) {
                cancellationToken.ThrowIfCancellationRequested();
                line.Append($"Z[{i}][{j}] = {_arrayOfValuesZ[i, j]:F6}; ");
            }
            await writer.WriteLineAsync(line, cancellationToken);
        }
    }
}