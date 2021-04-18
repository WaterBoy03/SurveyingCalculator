
namespace SurveyingCalculator
{
    partial class UnitConversionForm
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
            this.txtBox_UnitLength = new System.Windows.Forms.TextBox();
            this.cmbBox_UnitLength = new System.Windows.Forms.ComboBox();
            this.lbl_Length = new System.Windows.Forms.Label();
            this.btn_ConvertLength = new System.Windows.Forms.Button();
            this.lbl_LengthConvertToUnit = new System.Windows.Forms.Label();
            this.cmbBox_LengthConvertToUnit = new System.Windows.Forms.ComboBox();
            this.txtBox_LengthConverted = new System.Windows.Forms.TextBox();
            this.lbl_LengthConvertedUnit = new System.Windows.Forms.Label();
            this.txtBox_AreaConverted = new System.Windows.Forms.TextBox();
            this.cmbBox_AreaConvertToUnit = new System.Windows.Forms.ComboBox();
            this.lbl_AreaConvertToUnit = new System.Windows.Forms.Label();
            this.btn_AreaConvert = new System.Windows.Forms.Button();
            this.lbl_AreaText = new System.Windows.Forms.Label();
            this.cmbBox_UnitArea = new System.Windows.Forms.ComboBox();
            this.txtBox_UnitArea = new System.Windows.Forms.TextBox();
            this.lbl_AreaConvertedUnits = new System.Windows.Forms.Label();
            this.lbl_VolumeConvertedUnits = new System.Windows.Forms.Label();
            this.txtBox_VolumeConverted = new System.Windows.Forms.TextBox();
            this.cmbBox_VolumeConvertToUnit = new System.Windows.Forms.ComboBox();
            this.lbl_VolumeConvertToUnit = new System.Windows.Forms.Label();
            this.btn_VolumeConvert = new System.Windows.Forms.Button();
            this.lbl_VolumeText = new System.Windows.Forms.Label();
            this.cmbBox_UnitVolume = new System.Windows.Forms.ComboBox();
            this.txtBox_UnitVolume = new System.Windows.Forms.TextBox();
            this.lbl_TempConvertedUnits = new System.Windows.Forms.Label();
            this.txtBox_TempConverted = new System.Windows.Forms.TextBox();
            this.cmbBox_TempConvertToUnit = new System.Windows.Forms.ComboBox();
            this.lbl_TempConvertToUnit = new System.Windows.Forms.Label();
            this.btn_TempConvert = new System.Windows.Forms.Button();
            this.lbl_TempText = new System.Windows.Forms.Label();
            this.cmbBox_UnitTemp = new System.Windows.Forms.ComboBox();
            this.txtBox_UnitTemp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBox_UnitLength
            // 
            this.txtBox_UnitLength.Location = new System.Drawing.Point(25, 38);
            this.txtBox_UnitLength.Name = "txtBox_UnitLength";
            this.txtBox_UnitLength.Size = new System.Drawing.Size(82, 20);
            this.txtBox_UnitLength.TabIndex = 0;
            // 
            // cmbBox_UnitLength
            // 
            this.cmbBox_UnitLength.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_UnitLength.FormattingEnabled = true;
            this.cmbBox_UnitLength.Items.AddRange(new object[] {
            "International ft",
            "U.S. Survey ft",
            "m",
            "km",
            "mile",
            "rod",
            "Gunter\'s chain"});
            this.cmbBox_UnitLength.Location = new System.Drawing.Point(113, 37);
            this.cmbBox_UnitLength.Name = "cmbBox_UnitLength";
            this.cmbBox_UnitLength.Size = new System.Drawing.Size(84, 21);
            this.cmbBox_UnitLength.TabIndex = 1;
            // 
            // lbl_Length
            // 
            this.lbl_Length.AutoSize = true;
            this.lbl_Length.Location = new System.Drawing.Point(25, 19);
            this.lbl_Length.Name = "lbl_Length";
            this.lbl_Length.Size = new System.Drawing.Size(40, 13);
            this.lbl_Length.TabIndex = 2;
            this.lbl_Length.Text = "Length";
            // 
            // btn_ConvertLength
            // 
            this.btn_ConvertLength.Location = new System.Drawing.Point(317, 35);
            this.btn_ConvertLength.Name = "btn_ConvertLength";
            this.btn_ConvertLength.Size = new System.Drawing.Size(75, 23);
            this.btn_ConvertLength.TabIndex = 3;
            this.btn_ConvertLength.Text = "Convert";
            this.btn_ConvertLength.UseVisualStyleBackColor = true;
            this.btn_ConvertLength.Click += new System.EventHandler(this.Btn_ConvertLength_Click);
            // 
            // lbl_LengthConvertToUnit
            // 
            this.lbl_LengthConvertToUnit.AutoSize = true;
            this.lbl_LengthConvertToUnit.Location = new System.Drawing.Point(210, 19);
            this.lbl_LengthConvertToUnit.Name = "lbl_LengthConvertToUnit";
            this.lbl_LengthConvertToUnit.Size = new System.Drawing.Size(56, 13);
            this.lbl_LengthConvertToUnit.TabIndex = 4;
            this.lbl_LengthConvertToUnit.Text = "Convert to";
            // 
            // cmbBox_LengthConvertToUnit
            // 
            this.cmbBox_LengthConvertToUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_LengthConvertToUnit.FormattingEnabled = true;
            this.cmbBox_LengthConvertToUnit.Items.AddRange(new object[] {
            "International ft",
            "U.S. Survey ft",
            "m",
            "km",
            "mile",
            "rod",
            "Gunter\'s chain"});
            this.cmbBox_LengthConvertToUnit.Location = new System.Drawing.Point(213, 37);
            this.cmbBox_LengthConvertToUnit.Name = "cmbBox_LengthConvertToUnit";
            this.cmbBox_LengthConvertToUnit.Size = new System.Drawing.Size(84, 21);
            this.cmbBox_LengthConvertToUnit.TabIndex = 5;
            // 
            // txtBox_LengthConverted
            // 
            this.txtBox_LengthConverted.Location = new System.Drawing.Point(415, 37);
            this.txtBox_LengthConverted.Name = "txtBox_LengthConverted";
            this.txtBox_LengthConverted.Size = new System.Drawing.Size(100, 20);
            this.txtBox_LengthConverted.TabIndex = 6;
            // 
            // lbl_LengthConvertedUnit
            // 
            this.lbl_LengthConvertedUnit.AutoSize = true;
            this.lbl_LengthConvertedUnit.Location = new System.Drawing.Point(521, 40);
            this.lbl_LengthConvertedUnit.Name = "lbl_LengthConvertedUnit";
            this.lbl_LengthConvertedUnit.Size = new System.Drawing.Size(0, 13);
            this.lbl_LengthConvertedUnit.TabIndex = 7;
            // 
            // txtBox_AreaConverted
            // 
            this.txtBox_AreaConverted.Location = new System.Drawing.Point(415, 90);
            this.txtBox_AreaConverted.Name = "txtBox_AreaConverted";
            this.txtBox_AreaConverted.Size = new System.Drawing.Size(100, 20);
            this.txtBox_AreaConverted.TabIndex = 14;
            // 
            // cmbBox_AreaConvertToUnit
            // 
            this.cmbBox_AreaConvertToUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_AreaConvertToUnit.FormattingEnabled = true;
            this.cmbBox_AreaConvertToUnit.Items.AddRange(new object[] {
            "sq ft",
            "sq m",
            "sq km",
            "hectare",
            "acre",
            "sq mile"});
            this.cmbBox_AreaConvertToUnit.Location = new System.Drawing.Point(213, 90);
            this.cmbBox_AreaConvertToUnit.Name = "cmbBox_AreaConvertToUnit";
            this.cmbBox_AreaConvertToUnit.Size = new System.Drawing.Size(84, 21);
            this.cmbBox_AreaConvertToUnit.TabIndex = 13;
            // 
            // lbl_AreaConvertToUnit
            // 
            this.lbl_AreaConvertToUnit.AutoSize = true;
            this.lbl_AreaConvertToUnit.Location = new System.Drawing.Point(210, 72);
            this.lbl_AreaConvertToUnit.Name = "lbl_AreaConvertToUnit";
            this.lbl_AreaConvertToUnit.Size = new System.Drawing.Size(56, 13);
            this.lbl_AreaConvertToUnit.TabIndex = 12;
            this.lbl_AreaConvertToUnit.Text = "Convert to";
            // 
            // btn_AreaConvert
            // 
            this.btn_AreaConvert.Location = new System.Drawing.Point(317, 88);
            this.btn_AreaConvert.Name = "btn_AreaConvert";
            this.btn_AreaConvert.Size = new System.Drawing.Size(75, 23);
            this.btn_AreaConvert.TabIndex = 11;
            this.btn_AreaConvert.Text = "Convert";
            this.btn_AreaConvert.UseVisualStyleBackColor = true;
            this.btn_AreaConvert.Click += new System.EventHandler(this.Btn_AreaConvert_Click);
            // 
            // lbl_AreaText
            // 
            this.lbl_AreaText.AutoSize = true;
            this.lbl_AreaText.Location = new System.Drawing.Point(25, 72);
            this.lbl_AreaText.Name = "lbl_AreaText";
            this.lbl_AreaText.Size = new System.Drawing.Size(29, 13);
            this.lbl_AreaText.TabIndex = 10;
            this.lbl_AreaText.Text = "Area";
            // 
            // cmbBox_UnitArea
            // 
            this.cmbBox_UnitArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_UnitArea.FormattingEnabled = true;
            this.cmbBox_UnitArea.Items.AddRange(new object[] {
            "sq ft",
            "sq m",
            "sq km",
            "hectare",
            "acre",
            "sq mile"});
            this.cmbBox_UnitArea.Location = new System.Drawing.Point(113, 90);
            this.cmbBox_UnitArea.Name = "cmbBox_UnitArea";
            this.cmbBox_UnitArea.Size = new System.Drawing.Size(84, 21);
            this.cmbBox_UnitArea.TabIndex = 9;
            // 
            // txtBox_UnitArea
            // 
            this.txtBox_UnitArea.Location = new System.Drawing.Point(25, 91);
            this.txtBox_UnitArea.Name = "txtBox_UnitArea";
            this.txtBox_UnitArea.Size = new System.Drawing.Size(82, 20);
            this.txtBox_UnitArea.TabIndex = 8;
            // 
            // lbl_AreaConvertedUnits
            // 
            this.lbl_AreaConvertedUnits.AutoSize = true;
            this.lbl_AreaConvertedUnits.Location = new System.Drawing.Point(521, 93);
            this.lbl_AreaConvertedUnits.Name = "lbl_AreaConvertedUnits";
            this.lbl_AreaConvertedUnits.Size = new System.Drawing.Size(0, 13);
            this.lbl_AreaConvertedUnits.TabIndex = 15;
            // 
            // lbl_VolumeConvertedUnits
            // 
            this.lbl_VolumeConvertedUnits.AutoSize = true;
            this.lbl_VolumeConvertedUnits.Location = new System.Drawing.Point(521, 153);
            this.lbl_VolumeConvertedUnits.Name = "lbl_VolumeConvertedUnits";
            this.lbl_VolumeConvertedUnits.Size = new System.Drawing.Size(0, 13);
            this.lbl_VolumeConvertedUnits.TabIndex = 23;
            // 
            // txtBox_VolumeConverted
            // 
            this.txtBox_VolumeConverted.Location = new System.Drawing.Point(415, 150);
            this.txtBox_VolumeConverted.Name = "txtBox_VolumeConverted";
            this.txtBox_VolumeConverted.Size = new System.Drawing.Size(100, 20);
            this.txtBox_VolumeConverted.TabIndex = 22;
            // 
            // cmbBox_VolumeConvertToUnit
            // 
            this.cmbBox_VolumeConvertToUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_VolumeConvertToUnit.FormattingEnabled = true;
            this.cmbBox_VolumeConvertToUnit.Items.AddRange(new object[] {
            "c ft",
            "c m",
            "c yd",
            "litre",
            "U.S. gal",
            "Imperial gal"});
            this.cmbBox_VolumeConvertToUnit.Location = new System.Drawing.Point(213, 150);
            this.cmbBox_VolumeConvertToUnit.Name = "cmbBox_VolumeConvertToUnit";
            this.cmbBox_VolumeConvertToUnit.Size = new System.Drawing.Size(84, 21);
            this.cmbBox_VolumeConvertToUnit.TabIndex = 21;
            // 
            // lbl_VolumeConvertToUnit
            // 
            this.lbl_VolumeConvertToUnit.AutoSize = true;
            this.lbl_VolumeConvertToUnit.Location = new System.Drawing.Point(210, 132);
            this.lbl_VolumeConvertToUnit.Name = "lbl_VolumeConvertToUnit";
            this.lbl_VolumeConvertToUnit.Size = new System.Drawing.Size(56, 13);
            this.lbl_VolumeConvertToUnit.TabIndex = 20;
            this.lbl_VolumeConvertToUnit.Text = "Convert to";
            // 
            // btn_VolumeConvert
            // 
            this.btn_VolumeConvert.Location = new System.Drawing.Point(317, 148);
            this.btn_VolumeConvert.Name = "btn_VolumeConvert";
            this.btn_VolumeConvert.Size = new System.Drawing.Size(75, 23);
            this.btn_VolumeConvert.TabIndex = 19;
            this.btn_VolumeConvert.Text = "Convert";
            this.btn_VolumeConvert.UseVisualStyleBackColor = true;
            this.btn_VolumeConvert.Click += new System.EventHandler(this.Btn_VolumeConvert_Click);
            // 
            // lbl_VolumeText
            // 
            this.lbl_VolumeText.AutoSize = true;
            this.lbl_VolumeText.Location = new System.Drawing.Point(25, 132);
            this.lbl_VolumeText.Name = "lbl_VolumeText";
            this.lbl_VolumeText.Size = new System.Drawing.Size(42, 13);
            this.lbl_VolumeText.TabIndex = 18;
            this.lbl_VolumeText.Text = "Volume";
            // 
            // cmbBox_UnitVolume
            // 
            this.cmbBox_UnitVolume.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_UnitVolume.FormattingEnabled = true;
            this.cmbBox_UnitVolume.Items.AddRange(new object[] {
            "c ft",
            "c m",
            "c yd",
            "litre",
            "U.S. gal",
            "Imperial gal"});
            this.cmbBox_UnitVolume.Location = new System.Drawing.Point(113, 150);
            this.cmbBox_UnitVolume.Name = "cmbBox_UnitVolume";
            this.cmbBox_UnitVolume.Size = new System.Drawing.Size(84, 21);
            this.cmbBox_UnitVolume.TabIndex = 17;
            // 
            // txtBox_UnitVolume
            // 
            this.txtBox_UnitVolume.Location = new System.Drawing.Point(25, 151);
            this.txtBox_UnitVolume.Name = "txtBox_UnitVolume";
            this.txtBox_UnitVolume.Size = new System.Drawing.Size(82, 20);
            this.txtBox_UnitVolume.TabIndex = 16;
            // 
            // lbl_TempConvertedUnits
            // 
            this.lbl_TempConvertedUnits.AutoSize = true;
            this.lbl_TempConvertedUnits.Location = new System.Drawing.Point(521, 212);
            this.lbl_TempConvertedUnits.Name = "lbl_TempConvertedUnits";
            this.lbl_TempConvertedUnits.Size = new System.Drawing.Size(0, 13);
            this.lbl_TempConvertedUnits.TabIndex = 31;
            // 
            // txtBox_TempConverted
            // 
            this.txtBox_TempConverted.Location = new System.Drawing.Point(415, 209);
            this.txtBox_TempConverted.Name = "txtBox_TempConverted";
            this.txtBox_TempConverted.Size = new System.Drawing.Size(100, 20);
            this.txtBox_TempConverted.TabIndex = 30;
            // 
            // cmbBox_TempConvertToUnit
            // 
            this.cmbBox_TempConvertToUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_TempConvertToUnit.FormattingEnabled = true;
            this.cmbBox_TempConvertToUnit.Items.AddRange(new object[] {
            "°F",
            "°C",
            "K"});
            this.cmbBox_TempConvertToUnit.Location = new System.Drawing.Point(213, 209);
            this.cmbBox_TempConvertToUnit.Name = "cmbBox_TempConvertToUnit";
            this.cmbBox_TempConvertToUnit.Size = new System.Drawing.Size(84, 21);
            this.cmbBox_TempConvertToUnit.TabIndex = 29;
            // 
            // lbl_TempConvertToUnit
            // 
            this.lbl_TempConvertToUnit.AutoSize = true;
            this.lbl_TempConvertToUnit.Location = new System.Drawing.Point(210, 191);
            this.lbl_TempConvertToUnit.Name = "lbl_TempConvertToUnit";
            this.lbl_TempConvertToUnit.Size = new System.Drawing.Size(56, 13);
            this.lbl_TempConvertToUnit.TabIndex = 28;
            this.lbl_TempConvertToUnit.Text = "Convert to";
            // 
            // btn_TempConvert
            // 
            this.btn_TempConvert.Location = new System.Drawing.Point(317, 207);
            this.btn_TempConvert.Name = "btn_TempConvert";
            this.btn_TempConvert.Size = new System.Drawing.Size(75, 23);
            this.btn_TempConvert.TabIndex = 27;
            this.btn_TempConvert.Text = "Convert";
            this.btn_TempConvert.UseVisualStyleBackColor = true;
            this.btn_TempConvert.Click += new System.EventHandler(this.Btn_TempConvert_Click);
            // 
            // lbl_TempText
            // 
            this.lbl_TempText.AutoSize = true;
            this.lbl_TempText.Location = new System.Drawing.Point(25, 191);
            this.lbl_TempText.Name = "lbl_TempText";
            this.lbl_TempText.Size = new System.Drawing.Size(67, 13);
            this.lbl_TempText.TabIndex = 26;
            this.lbl_TempText.Text = "Temperature";
            // 
            // cmbBox_UnitTemp
            // 
            this.cmbBox_UnitTemp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_UnitTemp.FormattingEnabled = true;
            this.cmbBox_UnitTemp.Items.AddRange(new object[] {
            "°F",
            "°C",
            "K"});
            this.cmbBox_UnitTemp.Location = new System.Drawing.Point(113, 209);
            this.cmbBox_UnitTemp.Name = "cmbBox_UnitTemp";
            this.cmbBox_UnitTemp.Size = new System.Drawing.Size(84, 21);
            this.cmbBox_UnitTemp.TabIndex = 25;
            // 
            // txtBox_UnitTemp
            // 
            this.txtBox_UnitTemp.Location = new System.Drawing.Point(25, 210);
            this.txtBox_UnitTemp.Name = "txtBox_UnitTemp";
            this.txtBox_UnitTemp.Size = new System.Drawing.Size(82, 20);
            this.txtBox_UnitTemp.TabIndex = 24;
            // 
            // UnitConversionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 320);
            this.Controls.Add(this.lbl_TempConvertedUnits);
            this.Controls.Add(this.txtBox_TempConverted);
            this.Controls.Add(this.cmbBox_TempConvertToUnit);
            this.Controls.Add(this.lbl_TempConvertToUnit);
            this.Controls.Add(this.btn_TempConvert);
            this.Controls.Add(this.lbl_TempText);
            this.Controls.Add(this.cmbBox_UnitTemp);
            this.Controls.Add(this.txtBox_UnitTemp);
            this.Controls.Add(this.lbl_VolumeConvertedUnits);
            this.Controls.Add(this.txtBox_VolumeConverted);
            this.Controls.Add(this.cmbBox_VolumeConvertToUnit);
            this.Controls.Add(this.lbl_VolumeConvertToUnit);
            this.Controls.Add(this.btn_VolumeConvert);
            this.Controls.Add(this.lbl_VolumeText);
            this.Controls.Add(this.cmbBox_UnitVolume);
            this.Controls.Add(this.txtBox_UnitVolume);
            this.Controls.Add(this.lbl_AreaConvertedUnits);
            this.Controls.Add(this.txtBox_AreaConverted);
            this.Controls.Add(this.cmbBox_AreaConvertToUnit);
            this.Controls.Add(this.lbl_AreaConvertToUnit);
            this.Controls.Add(this.btn_AreaConvert);
            this.Controls.Add(this.lbl_AreaText);
            this.Controls.Add(this.cmbBox_UnitArea);
            this.Controls.Add(this.txtBox_UnitArea);
            this.Controls.Add(this.lbl_LengthConvertedUnit);
            this.Controls.Add(this.txtBox_LengthConverted);
            this.Controls.Add(this.cmbBox_LengthConvertToUnit);
            this.Controls.Add(this.lbl_LengthConvertToUnit);
            this.Controls.Add(this.btn_ConvertLength);
            this.Controls.Add(this.lbl_Length);
            this.Controls.Add(this.cmbBox_UnitLength);
            this.Controls.Add(this.txtBox_UnitLength);
            this.Name = "UnitConversionForm";
            this.Text = "Unit Conversion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_UnitLength;
        private System.Windows.Forms.Label lbl_Length;
        private System.Windows.Forms.Button btn_ConvertLength;
        private System.Windows.Forms.Label lbl_LengthConvertToUnit;
        private System.Windows.Forms.ComboBox cmbBox_LengthConvertToUnit;
        private System.Windows.Forms.ComboBox cmbBox_UnitLength;
        private System.Windows.Forms.TextBox txtBox_LengthConverted;
        private System.Windows.Forms.Label lbl_LengthConvertedUnit;
        private System.Windows.Forms.TextBox txtBox_AreaConverted;
        private System.Windows.Forms.ComboBox cmbBox_AreaConvertToUnit;
        private System.Windows.Forms.Label lbl_AreaConvertToUnit;
        private System.Windows.Forms.Button btn_AreaConvert;
        private System.Windows.Forms.Label lbl_AreaText;
        private System.Windows.Forms.ComboBox cmbBox_UnitArea;
        private System.Windows.Forms.TextBox txtBox_UnitArea;
        private System.Windows.Forms.Label lbl_AreaConvertedUnits;
        private System.Windows.Forms.Label lbl_VolumeConvertedUnits;
        private System.Windows.Forms.TextBox txtBox_VolumeConverted;
        private System.Windows.Forms.ComboBox cmbBox_VolumeConvertToUnit;
        private System.Windows.Forms.Label lbl_VolumeConvertToUnit;
        private System.Windows.Forms.Button btn_VolumeConvert;
        private System.Windows.Forms.Label lbl_VolumeText;
        private System.Windows.Forms.ComboBox cmbBox_UnitVolume;
        private System.Windows.Forms.TextBox txtBox_UnitVolume;
        private System.Windows.Forms.Label lbl_TempConvertedUnits;
        private System.Windows.Forms.TextBox txtBox_TempConverted;
        private System.Windows.Forms.ComboBox cmbBox_TempConvertToUnit;
        private System.Windows.Forms.Label lbl_TempConvertToUnit;
        private System.Windows.Forms.Button btn_TempConvert;
        private System.Windows.Forms.Label lbl_TempText;
        private System.Windows.Forms.ComboBox cmbBox_UnitTemp;
        private System.Windows.Forms.TextBox txtBox_UnitTemp;
    }
}