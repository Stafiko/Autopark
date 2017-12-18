namespace AutoparkWindow
{
    partial class DelForm
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
            this.YesButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // YesButton
            // 
            this.YesButton.Location = new System.Drawing.Point(11, 41);
            this.YesButton.Name = "YesButton";
            this.YesButton.Size = new System.Drawing.Size(146, 33);
            this.YesButton.TabIndex = 0;
            this.YesButton.Text = "Да";
            this.YesButton.UseVisualStyleBackColor = true;
            this.YesButton.Click += new System.EventHandler(this.YesButtonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Вы действительно хотите удалить данную запись?";
            // 
            // NoButton
            // 
            this.NoButton.Location = new System.Drawing.Point(197, 41);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(148, 33);
            this.NoButton.TabIndex = 3;
            this.NoButton.Text = "Нет";
            this.NoButton.UseVisualStyleBackColor = true;
            this.NoButton.Click += new System.EventHandler(this.NoButtonClick);
            // 
            // DelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 87);
            this.Controls.Add(this.NoButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.YesButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Удаление перевозки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button YesButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NoButton;
    }
}