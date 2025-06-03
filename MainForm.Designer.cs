namespace ProgrammingTechnologiesLaboratoryWork4
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MinXLabel = new Label();
            MinXTextBox = new TextBox();
            progressBar1 = new ProgressBar();
            CalculateButton = new Button();
            MaxXTextBox = new TextBox();
            MaxXLabel = new Label();
            MinYTextBox = new TextBox();
            MinYLabel = new Label();
            MaxYTextBox = new TextBox();
            MaxYLabel = new Label();
            StepXTextBox = new TextBox();
            StepXLabel = new Label();
            StepYTextBox = new TextBox();
            StepYLabel = new Label();
            ProcessTimeLabel = new Label();
            CancelButton = new Button();
            SuspendLayout();
            // 
            // MinXLabel
            // 
            MinXLabel.AutoSize = true;
            MinXLabel.Location = new Point(570, 9);
            MinXLabel.Name = "MinXLabel";
            MinXLabel.Size = new Size(122, 15);
            MinXLabel.TabIndex = 0;
            MinXLabel.Text = "Минимальное значение X";
            // 
            // MinXTextBox
            // 
            MinXTextBox.Location = new Point(592, 25);
            MinXTextBox.Name = "MinXTextBox";
            MinXTextBox.Size = new Size(100, 23);
            MinXTextBox.TabIndex = 1;
            MinXTextBox.Text = "1";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(15, 219);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(1037, 23);
            progressBar1.TabIndex = 2;
            // 
            // CalculateButton
            // 
            CalculateButton.Location = new Point(970, 646);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(85, 23);
            CalculateButton.TabIndex = 3;
            CalculateButton.Text = "Вычислить";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // MaxXTextBox
            // 
            MaxXTextBox.Location = new Point(592, 64);
            MaxXTextBox.Name = "MaxXTextBox";
            MaxXTextBox.Size = new Size(100, 23);
            MaxXTextBox.TabIndex = 5;
            MaxXTextBox.Text = "5";
            // 
            // MaxXLabel
            // 
            MaxXLabel.AutoSize = true;
            MaxXLabel.Location = new Point(570, 48);
            MaxXLabel.Name = "MaxXLabel";
            MaxXLabel.Size = new Size(126, 15);
            MaxXLabel.TabIndex = 4;
            MaxXLabel.Text = "Максимальное значение X";
            // 
            // MinYTextBox
            // 
            MinYTextBox.Location = new Point(755, 25);
            MinYTextBox.Name = "MinYTextBox";
            MinYTextBox.Size = new Size(100, 23);
            MinYTextBox.TabIndex = 7;
            MinYTextBox.Text = "1";
            // 
            // MinYLabel
            // 
            MinYLabel.AutoSize = true;
            MinYLabel.Location = new Point(740, 9);
            MinYLabel.Name = "MinYLabel";
            MinYLabel.Size = new Size(122, 15);
            MinYLabel.TabIndex = 6;
            MinYLabel.Text = "Минимальное значение Y";
            // 
            // MaxYTextBox
            // 
            MaxYTextBox.Location = new Point(755, 64);
            MaxYTextBox.Name = "MaxYTextBox";
            MaxYTextBox.Size = new Size(100, 23);
            MaxYTextBox.TabIndex = 9;
            MaxYTextBox.Text = "15";
            // 
            // MaxYLabel
            // 
            MaxYLabel.AutoSize = true;
            MaxYLabel.Location = new Point(740, 48);
            MaxYLabel.Name = "MaxYLabel";
            MaxYLabel.Size = new Size(126, 15);
            MaxYLabel.TabIndex = 8;
            MaxYLabel.Text = "Максимальное значение Y";
            // 
            // StepXTextBox
            // 
            StepXTextBox.Location = new Point(592, 103);
            StepXTextBox.Name = "StepXTextBox";
            StepXTextBox.Size = new Size(100, 23);
            StepXTextBox.TabIndex = 11;
            StepXTextBox.Text = "0,1";
            // 
            // StepXLabel
            // 
            StepXLabel.AutoSize = true;
            StepXLabel.Location = new Point(570, 87);
            StepXLabel.Name = "StepXLabel";
            StepXLabel.Size = new Size(45, 15);
            StepXLabel.TabIndex = 10;
            StepXLabel.Text = "Шаг по X";
            // 
            // StepYTextBox
            // 
            StepYTextBox.Location = new Point(755, 103);
            StepYTextBox.Name = "StepYTextBox";
            StepYTextBox.Size = new Size(100, 23);
            StepYTextBox.TabIndex = 13;
            StepYTextBox.Text = "0,1";
            // 
            // StepYLabel
            // 
            StepYLabel.AutoSize = true;
            StepYLabel.Location = new Point(740, 87);
            StepYLabel.Name = "StepYLabel";
            StepYLabel.Size = new Size(45, 15);
            StepYLabel.TabIndex = 12;
            StepYLabel.Text = "Шаг по Y";
            // 
            // ProcessTimeLabel
            // 
            ProcessTimeLabel.AutoSize = true;
            ProcessTimeLabel.Location = new Point(15, 245);
            ProcessTimeLabel.Name = "ProcessTimeLabel";
            ProcessTimeLabel.Size = new Size(108, 15);
            ProcessTimeLabel.TabIndex = 14;
            ProcessTimeLabel.Text = "Время выполнения:";
            // 
            // CancelButton
            // 
            CancelButton.Enabled = false;
            CancelButton.Location = new Point(896, 646);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(75, 23);
            CancelButton.TabIndex = 15;
            CancelButton.Text = "Отмена";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 681);
            Controls.Add(CancelButton);
            Controls.Add(ProcessTimeLabel);
            Controls.Add(StepYTextBox);
            Controls.Add(StepYLabel);
            Controls.Add(StepXTextBox);
            Controls.Add(StepXLabel);
            Controls.Add(MaxYTextBox);
            Controls.Add(MaxYLabel);
            Controls.Add(MinYTextBox);
            Controls.Add(MinYLabel);
            Controls.Add(MaxXTextBox);
            Controls.Add(MaxXLabel);
            Controls.Add(MinXTextBox);
            Controls.Add(MinXLabel);
            Controls.Add(progressBar1);
            Controls.Add(CalculateButton);
            Name = "MainForm";
            Text = "Лабораторная работа 4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MinXLabel;
        private TextBox MinXTextBox;
        private ProgressBar progressBar1;
        private Button CalculateButton;
        private TextBox MaxXTextBox;
        private Label MaxXLabel;
        private TextBox MinYTextBox;
        private Label MinYLabel;
        private TextBox MaxYTextBox;
        private Label MaxYLabel;
        private TextBox StepXTextBox;
        private Label StepXLabel;
        private TextBox StepYTextBox;
        private Label StepYLabel;
        private Label ProcessTimeLabel;
        private new Button CancelButton;
    }
} 