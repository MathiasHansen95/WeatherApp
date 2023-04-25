namespace WeatherApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            cityTB = new TextBox();
            button1 = new Button();
            labelCondition = new Label();
            labelDetails = new Label();
            labelSunrise = new Label();
            labelSunset = new Label();
            picIcon = new PictureBox();
            labelTemp = new Label();
            sunriseInfo = new Label();
            sunsetInfo = new Label();
            tempInfo = new Label();
            FLP = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)picIcon).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(450, 45);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(44, 23);
            label1.TabIndex = 0;
            label1.Text = "City:";
            // 
            // cityTB
            // 
            cityTB.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cityTB.Location = new Point(504, 46);
            cityTB.Margin = new Padding(5);
            cityTB.Name = "cityTB";
            cityTB.Size = new Size(238, 22);
            cityTB.TabIndex = 1;
            cityTB.TextChanged += cityTB_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(750, 46);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            // 
            // labelCondition
            // 
            labelCondition.AutoSize = true;
            labelCondition.BackColor = Color.Transparent;
            labelCondition.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelCondition.ForeColor = Color.White;
            labelCondition.Location = new Point(537, 180);
            labelCondition.Margin = new Padding(5, 0, 5, 0);
            labelCondition.Name = "labelCondition";
            labelCondition.Size = new Size(85, 23);
            labelCondition.TabIndex = 3;
            labelCondition.Text = "Condition";
            labelCondition.Click += label2_Click;
            // 
            // labelDetails
            // 
            labelDetails.AutoSize = true;
            labelDetails.BackColor = Color.Transparent;
            labelDetails.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelDetails.ForeColor = Color.White;
            labelDetails.Location = new Point(537, 214);
            labelDetails.Margin = new Padding(5, 0, 5, 0);
            labelDetails.Name = "labelDetails";
            labelDetails.Size = new Size(62, 23);
            labelDetails.TabIndex = 4;
            labelDetails.Text = "Details";
            labelDetails.Click += label3_Click;
            // 
            // labelSunrise
            // 
            labelSunrise.AutoSize = true;
            labelSunrise.BackColor = Color.Transparent;
            labelSunrise.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelSunrise.ForeColor = Color.White;
            labelSunrise.Location = new Point(537, 248);
            labelSunrise.Margin = new Padding(5, 0, 5, 0);
            labelSunrise.Name = "labelSunrise";
            labelSunrise.Size = new Size(72, 23);
            labelSunrise.TabIndex = 5;
            labelSunrise.Text = "Sunrise:";
            labelSunrise.Click += label4_Click;
            // 
            // labelSunset
            // 
            labelSunset.AutoSize = true;
            labelSunset.BackColor = Color.Transparent;
            labelSunset.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelSunset.ForeColor = Color.White;
            labelSunset.Location = new Point(537, 286);
            labelSunset.Margin = new Padding(5, 0, 5, 0);
            labelSunset.Name = "labelSunset";
            labelSunset.Size = new Size(67, 23);
            labelSunset.TabIndex = 6;
            labelSunset.Text = "Sunset:";
            // 
            // picIcon
            // 
            picIcon.BackColor = Color.Transparent;
            picIcon.Location = new Point(537, 76);
            picIcon.Name = "picIcon";
            picIcon.Size = new Size(159, 45);
            picIcon.SizeMode = PictureBoxSizeMode.Zoom;
            picIcon.TabIndex = 9;
            picIcon.TabStop = false;
            // 
            // labelTemp
            // 
            labelTemp.AutoSize = true;
            labelTemp.BackColor = Color.Transparent;
            labelTemp.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelTemp.ForeColor = Color.White;
            labelTemp.Location = new Point(537, 145);
            labelTemp.Margin = new Padding(5, 0, 5, 0);
            labelTemp.Name = "labelTemp";
            labelTemp.Size = new Size(113, 23);
            labelTemp.TabIndex = 10;
            labelTemp.Text = "Temperature:";
            // 
            // sunriseInfo
            // 
            sunriseInfo.AutoSize = true;
            sunriseInfo.BackColor = Color.Transparent;
            sunriseInfo.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            sunriseInfo.ForeColor = Color.White;
            sunriseInfo.Location = new Point(608, 248);
            sunriseInfo.Margin = new Padding(5, 0, 5, 0);
            sunriseInfo.Name = "sunriseInfo";
            sunriseInfo.Size = new Size(39, 23);
            sunriseInfo.TabIndex = 11;
            sunriseInfo.Text = "N/A";
            sunriseInfo.Click += label2_Click_1;
            // 
            // sunsetInfo
            // 
            sunsetInfo.AutoSize = true;
            sunsetInfo.BackColor = Color.Transparent;
            sunsetInfo.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            sunsetInfo.ForeColor = Color.White;
            sunsetInfo.Location = new Point(602, 286);
            sunsetInfo.Margin = new Padding(5, 0, 5, 0);
            sunsetInfo.Name = "sunsetInfo";
            sunsetInfo.Size = new Size(39, 23);
            sunsetInfo.TabIndex = 12;
            sunsetInfo.Text = "N/A";
            // 
            // tempInfo
            // 
            tempInfo.AutoSize = true;
            tempInfo.BackColor = Color.Transparent;
            tempInfo.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tempInfo.ForeColor = Color.White;
            tempInfo.Location = new Point(655, 145);
            tempInfo.Margin = new Padding(5, 0, 5, 0);
            tempInfo.Name = "tempInfo";
            tempInfo.Size = new Size(39, 23);
            tempInfo.TabIndex = 13;
            tempInfo.Text = "N/A";
            // 
            // FLP
            // 
            FLP.AutoScroll = true;
            FLP.BackColor = Color.Transparent;
            FLP.Location = new Point(12, 326);
            FLP.Name = "FLP";
            FLP.Size = new Size(1282, 257);
            FLP.TabIndex = 14;
            FLP.WrapContents = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1306, 595);
            Controls.Add(FLP);
            Controls.Add(tempInfo);
            Controls.Add(sunsetInfo);
            Controls.Add(sunriseInfo);
            Controls.Add(labelTemp);
            Controls.Add(picIcon);
            Controls.Add(labelSunset);
            Controls.Add(labelSunrise);
            Controls.Add(labelDetails);
            Controls.Add(labelCondition);
            Controls.Add(button1);
            Controls.Add(cityTB);
            Controls.Add(label1);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox cityTB;
        private Button button1;
        private Label labelCondition;
        private Label labelDetails;
        private Label labelSunrise;
        private Label labelSunset;
        private PictureBox picIcon;
        private Label labelTemp;
        private Label sunriseInfo;
        private Label sunsetInfo;
        private Label tempInfo;
        public FlowLayoutPanel FLP;
    }
}