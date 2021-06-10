namespace Lab2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.firstTask = new System.Windows.Forms.RadioButton();
            this.secondTask = new System.Windows.Forms.RadioButton();
            this.textBox = new System.Windows.Forms.TextBox();
            this.Encrypt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.MatrixBox = new System.Windows.Forms.TextBox();
            this.EncryptedMatrixBox = new System.Windows.Forms.TextBox();
            this.FirstKeyBox = new System.Windows.Forms.TextBox();
            this.SecondKeyBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Location = new System.Drawing.Point(32, 12);
            this.OpenFileButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(100, 28);
            this.OpenFileButton.TabIndex = 0;
            this.OpenFileButton.Text = "Открыть";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // PathTextBox
            // 
            this.PathTextBox.Location = new System.Drawing.Point(140, 15);
            this.PathTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.ReadOnly = true;
            this.PathTextBox.Size = new System.Drawing.Size(355, 22);
            this.PathTextBox.TabIndex = 1;
            // 
            // firstTask
            // 
            this.firstTask.AutoSize = true;
            this.firstTask.Checked = true;
            this.firstTask.Location = new System.Drawing.Point(31, 53);
            this.firstTask.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.firstTask.Name = "firstTask";
            this.firstTask.Size = new System.Drawing.Size(209, 21);
            this.firstTask.TabIndex = 2;
            this.firstTask.TabStop = true;
            this.firstTask.Text = "Маршрутная перестановка";
            this.firstTask.UseVisualStyleBackColor = true;
            // 
            // secondTask
            // 
            this.secondTask.AutoSize = true;
            this.secondTask.Location = new System.Drawing.Point(31, 80);
            this.secondTask.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.secondTask.Name = "secondTask";
            this.secondTask.Size = new System.Drawing.Size(230, 21);
            this.secondTask.TabIndex = 3;
            this.secondTask.Text = "Множественная перестановка";
            this.secondTask.UseVisualStyleBackColor = true;
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(511, 15);
            this.textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(463, 125);
            this.textBox.TabIndex = 4;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // Encrypt
            // 
            this.Encrypt.Location = new System.Drawing.Point(293, 76);
            this.Encrypt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Encrypt.Name = "Encrypt";
            this.Encrypt.Size = new System.Drawing.Size(193, 28);
            this.Encrypt.TabIndex = 5;
            this.Encrypt.Text = "Зашифровать";
            this.Encrypt.UseVisualStyleBackColor = true;
            this.Encrypt.Click += new System.EventHandler(this.Encrypt_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(161, 428);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Гистограммы";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 462);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(464, 22);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "s:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(293, 52);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(56, 22);
            this.textBox2.TabIndex = 10;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // MatrixBox
            // 
            this.MatrixBox.Location = new System.Drawing.Point(31, 149);
            this.MatrixBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MatrixBox.Multiline = true;
            this.MatrixBox.Name = "MatrixBox";
            this.MatrixBox.ReadOnly = true;
            this.MatrixBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.MatrixBox.Size = new System.Drawing.Size(464, 271);
            this.MatrixBox.TabIndex = 11;
            // 
            // EncryptedMatrixBox
            // 
            this.EncryptedMatrixBox.Location = new System.Drawing.Point(511, 149);
            this.EncryptedMatrixBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EncryptedMatrixBox.Multiline = true;
            this.EncryptedMatrixBox.Name = "EncryptedMatrixBox";
            this.EncryptedMatrixBox.ReadOnly = true;
            this.EncryptedMatrixBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.EncryptedMatrixBox.Size = new System.Drawing.Size(464, 271);
            this.EncryptedMatrixBox.TabIndex = 12;
            // 
            // FirstKeyBox
            // 
            this.FirstKeyBox.Location = new System.Drawing.Point(32, 114);
            this.FirstKeyBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FirstKeyBox.Name = "FirstKeyBox";
            this.FirstKeyBox.Size = new System.Drawing.Size(213, 22);
            this.FirstKeyBox.TabIndex = 13;
            // 
            // SecondKeyBox
            // 
            this.SecondKeyBox.Location = new System.Drawing.Point(284, 113);
            this.SecondKeyBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SecondKeyBox.Name = "SecondKeyBox";
            this.SecondKeyBox.Size = new System.Drawing.Size(201, 22);
            this.SecondKeyBox.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orchid;
            this.ClientSize = new System.Drawing.Size(991, 501);
            this.Controls.Add(this.SecondKeyBox);
            this.Controls.Add(this.FirstKeyBox);
            this.Controls.Add(this.EncryptedMatrixBox);
            this.Controls.Add(this.MatrixBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Encrypt);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.secondTask);
            this.Controls.Add(this.firstTask);
            this.Controls.Add(this.PathTextBox);
            this.Controls.Add(this.OpenFileButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Lab2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.RadioButton firstTask;
        private System.Windows.Forms.RadioButton secondTask;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button Encrypt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox MatrixBox;
        private System.Windows.Forms.TextBox EncryptedMatrixBox;
        private System.Windows.Forms.TextBox FirstKeyBox;
        private System.Windows.Forms.TextBox SecondKeyBox;
    }
}

