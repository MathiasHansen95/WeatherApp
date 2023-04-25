namespace WeatherApp
{
    partial class ForecastForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            DTLab = new Label();
            condLabel = new Label();
            descLabel = new Label();
            tempLabel = new Label();
            minLabel = new Label();
            maxLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 57);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // DTLab
            // 
            DTLab.AutoSize = true;
            DTLab.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DTLab.ForeColor = Color.White;
            DTLab.Location = new Point(82, 27);
            DTLab.Name = "DTLab";
            DTLab.Size = new Size(46, 14);
            DTLab.TabIndex = 1;
            DTLab.Text = "Sunday";
            DTLab.Click += label1_Click;
            // 
            // condLabel
            // 
            condLabel.AutoSize = true;
            condLabel.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            condLabel.ForeColor = Color.White;
            condLabel.Location = new Point(19, 78);
            condLabel.Name = "condLabel";
            condLabel.Size = new Size(58, 14);
            condLabel.TabIndex = 2;
            condLabel.Text = "condition";
            // 
            // descLabel
            // 
            descLabel.AutoSize = true;
            descLabel.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            descLabel.ForeColor = Color.White;
            descLabel.Location = new Point(19, 101);
            descLabel.Name = "descLabel";
            descLabel.Size = new Size(64, 14);
            descLabel.TabIndex = 3;
            descLabel.Text = "Desription";
            // 
            // tempLabel
            // 
            tempLabel.AutoSize = true;
            tempLabel.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tempLabel.ForeColor = Color.White;
            tempLabel.Location = new Point(19, 126);
            tempLabel.Name = "tempLabel";
            tempLabel.Size = new Size(36, 14);
            tempLabel.TabIndex = 4;
            tempLabel.Text = "Temp";
            // 
            // minLabel
            // 
            minLabel.AutoSize = true;
            minLabel.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            minLabel.ForeColor = Color.White;
            minLabel.Location = new Point(19, 152);
            minLabel.Name = "minLabel";
            minLabel.Size = new Size(60, 14);
            minLabel.TabIndex = 5;
            minLabel.Text = "Min Temp";
            minLabel.Click += label1_Click_1;
            // 
            // maxLabel
            // 
            maxLabel.AutoSize = true;
            maxLabel.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            maxLabel.ForeColor = Color.White;
            maxLabel.Location = new Point(19, 180);
            maxLabel.Name = "maxLabel";
            maxLabel.Size = new Size(61, 14);
            maxLabel.TabIndex = 6;
            maxLabel.Text = "Max Temp";
            // 
            // ForecastForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(maxLabel);
            Controls.Add(minLabel);
            Controls.Add(tempLabel);
            Controls.Add(descLabel);
            Controls.Add(condLabel);
            Controls.Add(DTLab);
            Controls.Add(pictureBox1);
            Name = "ForecastForm";
            Size = new Size(137, 216);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public PictureBox pictureBox1;
        public Label DTLab;
        public Label condLabel;
        public Label descLabel;
        public Label tempLabel;
        public Label minLabel;
        public Label maxLabel;
    }
}
