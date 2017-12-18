namespace AutoparkWindow
{
    partial class BusForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SizeNumeric = new System.Windows.Forms.NumericUpDown();
            this.NumberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.NumberplateTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.NoButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SizeNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // SizeNumeric
            // 
            this.SizeNumeric.Location = new System.Drawing.Point(112, 84);
            this.SizeNumeric.Name = "SizeNumeric";
            this.SizeNumeric.Size = new System.Drawing.Size(143, 20);
            this.SizeNumeric.TabIndex = 0;
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.Location = new System.Drawing.Point(112, 6);
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.Size = new System.Drawing.Size(143, 20);
            this.NumberTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Номер";
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Location = new System.Drawing.Point(112, 32);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.Size = new System.Drawing.Size(143, 20);
            this.ModelTextBox.TabIndex = 3;
            // 
            // NumberplateTextBox
            // 
            this.NumberplateTextBox.Location = new System.Drawing.Point(112, 58);
            this.NumberplateTextBox.Name = "NumberplateTextBox";
            this.NumberplateTextBox.Size = new System.Drawing.Size(143, 20);
            this.NumberplateTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Модель";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Номерной знак";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Количество мест";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(15, 110);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(240, 24);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButtonClick);
            // 
            // NoButton
            // 
            this.NoButton.Location = new System.Drawing.Point(15, 170);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(240, 24);
            this.NoButton.TabIndex = 9;
            this.NoButton.Text = "Отмена";
            this.NoButton.UseVisualStyleBackColor = true;
            this.NoButton.Click += new System.EventHandler(this.NoButtonClick);
            // 
            // SaveButton
            // 
            this.SaveButton.Enabled = false;
            this.SaveButton.Location = new System.Drawing.Point(15, 140);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(240, 24);
            this.SaveButton.TabIndex = 10;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // BusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 199);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.NoButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumberplateTextBox);
            this.Controls.Add(this.ModelTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumberTextBox);
            this.Controls.Add(this.SizeNumeric);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление автобуса";
            ((System.ComponentModel.ISupportInitialize)(this.SizeNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.NumericUpDown SizeNumeric;
        public System.Windows.Forms.TextBox NumberTextBox;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox ModelTextBox;
        public System.Windows.Forms.TextBox NumberplateTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button NoButton;
        public System.Windows.Forms.Button SaveButton;
    }
}