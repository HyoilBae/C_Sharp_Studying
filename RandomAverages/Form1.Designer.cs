namespace RandomAverages
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.NumberOfValues = new System.Windows.Forms.Label();
            this.CalculateRandomAverages = new System.Windows.Forms.Button();
            this.RandomAverageResults = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(220, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(322, 26);
            this.textBox1.TabIndex = 0;
            // 
            // NumberOfValues
            // 
            this.NumberOfValues.AutoSize = true;
            this.NumberOfValues.Location = new System.Drawing.Point(74, 70);
            this.NumberOfValues.Name = "NumberOfValues";
            this.NumberOfValues.Size = new System.Drawing.Size(140, 20);
            this.NumberOfValues.TabIndex = 1;
            this.NumberOfValues.Text = "Number of values: ";
            this.NumberOfValues.Click += new System.EventHandler(this.label1_Click);
            // 
            // CalculateRandomAverages
            // 
            this.CalculateRandomAverages.Location = new System.Drawing.Point(559, 67);
            this.CalculateRandomAverages.Name = "CalculateRandomAverages";
            this.CalculateRandomAverages.Size = new System.Drawing.Size(75, 43);
            this.CalculateRandomAverages.TabIndex = 2;
            this.CalculateRandomAverages.Text = "Start";
            this.CalculateRandomAverages.UseVisualStyleBackColor = true;
            this.CalculateRandomAverages.Click += CalculateRandomAveragesAsync_Click;
            // 
            // RandomAverageResults
            // 
            this.RandomAverageResults.AutoSize = true;
            this.RandomAverageResults.Location = new System.Drawing.Point(293, 117);
            this.RandomAverageResults.Name = "RandomAverageResults";
            this.RandomAverageResults.Size = new System.Drawing.Size(51, 20);
            this.RandomAverageResults.TabIndex = 4;
            this.RandomAverageResults.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RandomAverageResults);
            this.Controls.Add(this.CalculateRandomAverages);
            this.Controls.Add(this.NumberOfValues);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Random Averages";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label NumberOfValues;
        private System.Windows.Forms.Button CalculateRandomAverages;
        private System.Windows.Forms.Label RandomAverageResults;
    }
}

