namespace WeatherForms {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            lbCity = new Label();
            lbWeather = new Label();
            lbTemperature = new Label();
            lbWind = new Label();
            lbPrecipitation = new Label();
            cbCity = new ComboBox();
            SuspendLayout();
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new Point(114, 76);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(28, 15);
            lbCity.TabIndex = 0;
            lbCity.Text = "City";
            // 
            // lbWeather
            // 
            lbWeather.AutoSize = true;
            lbWeather.Location = new Point(114, 107);
            lbWeather.Name = "lbWeather";
            lbWeather.Size = new Size(51, 15);
            lbWeather.TabIndex = 1;
            lbWeather.Text = "Weather";
            // 
            // lbTemperature
            // 
            lbTemperature.AutoSize = true;
            lbTemperature.Location = new Point(114, 141);
            lbTemperature.Name = "lbTemperature";
            lbTemperature.Size = new Size(73, 15);
            lbTemperature.TabIndex = 2;
            lbTemperature.Text = "Temperature";
            // 
            // lbWind
            // 
            lbWind.AutoSize = true;
            lbWind.Location = new Point(114, 170);
            lbWind.Name = "lbWind";
            lbWind.Size = new Size(35, 15);
            lbWind.TabIndex = 3;
            lbWind.Text = "Wind";
            // 
            // lbPrecipitation
            // 
            lbPrecipitation.AutoSize = true;
            lbPrecipitation.Location = new Point(114, 204);
            lbPrecipitation.Name = "lbPrecipitation";
            lbPrecipitation.Size = new Size(74, 15);
            lbPrecipitation.TabIndex = 4;
            lbPrecipitation.Text = "Precipitation";
            // 
            // cbCity
            // 
            cbCity.FormattingEnabled = true;
            cbCity.Items.AddRange(new object[] { "Ostrava", "Rovaniemi", "Rome", "Sydney", "Reykjavík" });
            cbCity.Location = new Point(77, 33);
            cbCity.Name = "cbCity";
            cbCity.Size = new Size(121, 23);
            cbCity.TabIndex = 5;
            cbCity.SelectedIndexChanged += cbCity_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 253);
            Controls.Add(cbCity);
            Controls.Add(lbPrecipitation);
            Controls.Add(lbWind);
            Controls.Add(lbTemperature);
            Controls.Add(lbWeather);
            Controls.Add(lbCity);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCity;
        private Label lbWeather;
        private Label lbTemperature;
        private Label lbWind;
        private Label lbPrecipitation;
        private ComboBox cbCity;
    }
}