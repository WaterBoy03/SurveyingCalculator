
namespace SurveyingCalculator
{
    partial class AngleConversionForm
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
            this.lbl_AngleConversion = new System.Windows.Forms.Label();
            this.txtBox_AngleConversion = new System.Windows.Forms.TextBox();
            this.cmbBox_AngleUnits = new System.Windows.Forms.ComboBox();
            this.cmbBox_ConvertAngleUnitsTo = new System.Windows.Forms.ComboBox();
            this.lbl_ConvertAngleTo = new System.Windows.Forms.Label();
            this.txtBox_ConvertedAngle = new System.Windows.Forms.TextBox();
            this.txtBox_ConvertedAzBearDec = new System.Windows.Forms.TextBox();
            this.lbl_AzBearConvertTo = new System.Windows.Forms.Label();
            this.cmbBox_AzBearConvertTo = new System.Windows.Forms.ComboBox();
            this.cmbBox_AzBearUnits = new System.Windows.Forms.ComboBox();
            this.txtBox_AzBearDec = new System.Windows.Forms.TextBox();
            this.lbl_AzBearLabel = new System.Windows.Forms.Label();
            this.txtBox_AngleConversionDegree = new System.Windows.Forms.TextBox();
            this.txtBox_AngleConversionMinute = new System.Windows.Forms.TextBox();
            this.txtBox_AngleConversionSecond = new System.Windows.Forms.TextBox();
            this.lbl_AngleConversionDegree = new System.Windows.Forms.Label();
            this.lbl_AngleConversionMinute = new System.Windows.Forms.Label();
            this.lbl_AngleConversionSecond = new System.Windows.Forms.Label();
            this.btn_AngleConversionConvert = new System.Windows.Forms.Button();
            this.lbl_ConvertedAngleSecond = new System.Windows.Forms.Label();
            this.lbl_ConvertedAngleMinute = new System.Windows.Forms.Label();
            this.lbl_ConvertedAngleDegree = new System.Windows.Forms.Label();
            this.txtBox_ConvertedAngleSecond = new System.Windows.Forms.TextBox();
            this.txtBox_ConvertedAngleMinute = new System.Windows.Forms.TextBox();
            this.txtBox_ConvertedAngleDegree = new System.Windows.Forms.TextBox();
            this.lbl_AzBearSecond = new System.Windows.Forms.Label();
            this.lbl_AzBearMinute = new System.Windows.Forms.Label();
            this.lbl_AzBearDegree = new System.Windows.Forms.Label();
            this.txtBox_AzBearSecond = new System.Windows.Forms.TextBox();
            this.txtBox_AzBearMinute = new System.Windows.Forms.TextBox();
            this.txtBox_AzBearDegree = new System.Windows.Forms.TextBox();
            this.lbl_ConvertedAngleUnits = new System.Windows.Forms.Label();
            this.cmbBox_BearingDirection = new System.Windows.Forms.ComboBox();
            this.btn_AzBearConvert = new System.Windows.Forms.Button();
            this.lbl_ConvertedAzBearSecond = new System.Windows.Forms.Label();
            this.lbl_ConvertedAzBearMinute = new System.Windows.Forms.Label();
            this.lbl_ConvertedAzBearDegree = new System.Windows.Forms.Label();
            this.txtBox_ConvertedAzBearSecond = new System.Windows.Forms.TextBox();
            this.txtBox_ConvertedAzBearMinute = new System.Windows.Forms.TextBox();
            this.txtBox_ConvertedAzBearDegree = new System.Windows.Forms.TextBox();
            this.lbl_ConvertedBearing = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_AngleConversion
            // 
            this.lbl_AngleConversion.AutoSize = true;
            this.lbl_AngleConversion.Location = new System.Drawing.Point(11, 24);
            this.lbl_AngleConversion.Name = "lbl_AngleConversion";
            this.lbl_AngleConversion.Size = new System.Drawing.Size(95, 13);
            this.lbl_AngleConversion.TabIndex = 0;
            this.lbl_AngleConversion.Text = "Angle Conversions";
            // 
            // txtBox_AngleConversion
            // 
            this.txtBox_AngleConversion.Location = new System.Drawing.Point(14, 43);
            this.txtBox_AngleConversion.Name = "txtBox_AngleConversion";
            this.txtBox_AngleConversion.Size = new System.Drawing.Size(100, 20);
            this.txtBox_AngleConversion.TabIndex = 1;
            // 
            // cmbBox_AngleUnits
            // 
            this.cmbBox_AngleUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_AngleUnits.Items.AddRange(new object[] {
            "decimal degree",
            "degree minute second",
            "radian",
            "gon"});
            this.cmbBox_AngleUnits.Location = new System.Drawing.Point(191, 41);
            this.cmbBox_AngleUnits.Name = "cmbBox_AngleUnits";
            this.cmbBox_AngleUnits.Size = new System.Drawing.Size(121, 21);
            this.cmbBox_AngleUnits.TabIndex = 2;
            this.cmbBox_AngleUnits.SelectedIndexChanged += new System.EventHandler(this.CmbBox_AngleUnits_SelectedIndexChanged);
            // 
            // cmbBox_ConvertAngleUnitsTo
            // 
            this.cmbBox_ConvertAngleUnitsTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_ConvertAngleUnitsTo.FormattingEnabled = true;
            this.cmbBox_ConvertAngleUnitsTo.Items.AddRange(new object[] {
            "decimal degree",
            "degree minute second",
            "radian",
            "gon"});
            this.cmbBox_ConvertAngleUnitsTo.Location = new System.Drawing.Point(318, 41);
            this.cmbBox_ConvertAngleUnitsTo.Name = "cmbBox_ConvertAngleUnitsTo";
            this.cmbBox_ConvertAngleUnitsTo.Size = new System.Drawing.Size(121, 21);
            this.cmbBox_ConvertAngleUnitsTo.TabIndex = 3;
            // 
            // lbl_ConvertAngleTo
            // 
            this.lbl_ConvertAngleTo.AutoSize = true;
            this.lbl_ConvertAngleTo.Location = new System.Drawing.Point(328, 22);
            this.lbl_ConvertAngleTo.Name = "lbl_ConvertAngleTo";
            this.lbl_ConvertAngleTo.Size = new System.Drawing.Size(60, 13);
            this.lbl_ConvertAngleTo.TabIndex = 4;
            this.lbl_ConvertAngleTo.Text = "Convert To";
            // 
            // txtBox_ConvertedAngle
            // 
            this.txtBox_ConvertedAngle.Location = new System.Drawing.Point(552, 43);
            this.txtBox_ConvertedAngle.Name = "txtBox_ConvertedAngle";
            this.txtBox_ConvertedAngle.Size = new System.Drawing.Size(100, 20);
            this.txtBox_ConvertedAngle.TabIndex = 5;
            // 
            // txtBox_ConvertedAzBearDec
            // 
            this.txtBox_ConvertedAzBearDec.Location = new System.Drawing.Point(589, 113);
            this.txtBox_ConvertedAzBearDec.Name = "txtBox_ConvertedAzBearDec";
            this.txtBox_ConvertedAzBearDec.Size = new System.Drawing.Size(100, 20);
            this.txtBox_ConvertedAzBearDec.TabIndex = 11;
            // 
            // lbl_AzBearConvertTo
            // 
            this.lbl_AzBearConvertTo.AutoSize = true;
            this.lbl_AzBearConvertTo.Location = new System.Drawing.Point(328, 92);
            this.lbl_AzBearConvertTo.Name = "lbl_AzBearConvertTo";
            this.lbl_AzBearConvertTo.Size = new System.Drawing.Size(60, 13);
            this.lbl_AzBearConvertTo.TabIndex = 10;
            this.lbl_AzBearConvertTo.Text = "Convert To";
            // 
            // cmbBox_AzBearConvertTo
            // 
            this.cmbBox_AzBearConvertTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_AzBearConvertTo.FormattingEnabled = true;
            this.cmbBox_AzBearConvertTo.Items.AddRange(new object[] {
            "azimuth decimal degree",
            "azimuth degree minute second",
            "bearing decimal degree",
            "bearing degree minute second"});
            this.cmbBox_AzBearConvertTo.Location = new System.Drawing.Point(318, 111);
            this.cmbBox_AzBearConvertTo.Name = "cmbBox_AzBearConvertTo";
            this.cmbBox_AzBearConvertTo.Size = new System.Drawing.Size(121, 21);
            this.cmbBox_AzBearConvertTo.TabIndex = 9;
            // 
            // cmbBox_AzBearUnits
            // 
            this.cmbBox_AzBearUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_AzBearUnits.FormattingEnabled = true;
            this.cmbBox_AzBearUnits.Items.AddRange(new object[] {
            "azimuth decimal degree",
            "azimuth degree minute second",
            "bearing decimal degree",
            "bearing degree minute second"});
            this.cmbBox_AzBearUnits.Location = new System.Drawing.Point(191, 111);
            this.cmbBox_AzBearUnits.Name = "cmbBox_AzBearUnits";
            this.cmbBox_AzBearUnits.Size = new System.Drawing.Size(121, 21);
            this.cmbBox_AzBearUnits.TabIndex = 8;
            this.cmbBox_AzBearUnits.SelectedIndexChanged += new System.EventHandler(this.CmbBox_AzBearUnits_SelectedIndexChanged);
            // 
            // txtBox_AzBearDec
            // 
            this.txtBox_AzBearDec.Location = new System.Drawing.Point(14, 112);
            this.txtBox_AzBearDec.Name = "txtBox_AzBearDec";
            this.txtBox_AzBearDec.Size = new System.Drawing.Size(100, 20);
            this.txtBox_AzBearDec.TabIndex = 7;
            // 
            // lbl_AzBearLabel
            // 
            this.lbl_AzBearLabel.AutoSize = true;
            this.lbl_AzBearLabel.Location = new System.Drawing.Point(11, 93);
            this.lbl_AzBearLabel.Name = "lbl_AzBearLabel";
            this.lbl_AzBearLabel.Size = new System.Drawing.Size(139, 13);
            this.lbl_AzBearLabel.TabIndex = 6;
            this.lbl_AzBearLabel.Text = "Azimuth-Bearing Conversion";
            // 
            // txtBox_AngleConversionDegree
            // 
            this.txtBox_AngleConversionDegree.Location = new System.Drawing.Point(13, 44);
            this.txtBox_AngleConversionDegree.Name = "txtBox_AngleConversionDegree";
            this.txtBox_AngleConversionDegree.Size = new System.Drawing.Size(27, 20);
            this.txtBox_AngleConversionDegree.TabIndex = 12;
            this.txtBox_AngleConversionDegree.Visible = false;
            // 
            // txtBox_AngleConversionMinute
            // 
            this.txtBox_AngleConversionMinute.Location = new System.Drawing.Point(67, 44);
            this.txtBox_AngleConversionMinute.Name = "txtBox_AngleConversionMinute";
            this.txtBox_AngleConversionMinute.Size = new System.Drawing.Size(27, 20);
            this.txtBox_AngleConversionMinute.TabIndex = 13;
            this.txtBox_AngleConversionMinute.Visible = false;
            // 
            // txtBox_AngleConversionSecond
            // 
            this.txtBox_AngleConversionSecond.Location = new System.Drawing.Point(118, 44);
            this.txtBox_AngleConversionSecond.Name = "txtBox_AngleConversionSecond";
            this.txtBox_AngleConversionSecond.Size = new System.Drawing.Size(47, 20);
            this.txtBox_AngleConversionSecond.TabIndex = 14;
            this.txtBox_AngleConversionSecond.Visible = false;
            // 
            // lbl_AngleConversionDegree
            // 
            this.lbl_AngleConversionDegree.AutoSize = true;
            this.lbl_AngleConversionDegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AngleConversionDegree.Location = new System.Drawing.Point(47, 41);
            this.lbl_AngleConversionDegree.Name = "lbl_AngleConversionDegree";
            this.lbl_AngleConversionDegree.Size = new System.Drawing.Size(14, 13);
            this.lbl_AngleConversionDegree.TabIndex = 15;
            this.lbl_AngleConversionDegree.Text = "o";
            this.lbl_AngleConversionDegree.Visible = false;
            // 
            // lbl_AngleConversionMinute
            // 
            this.lbl_AngleConversionMinute.AutoSize = true;
            this.lbl_AngleConversionMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AngleConversionMinute.Location = new System.Drawing.Point(100, 41);
            this.lbl_AngleConversionMinute.Name = "lbl_AngleConversionMinute";
            this.lbl_AngleConversionMinute.Size = new System.Drawing.Size(12, 16);
            this.lbl_AngleConversionMinute.TabIndex = 16;
            this.lbl_AngleConversionMinute.Text = "\'";
            this.lbl_AngleConversionMinute.Visible = false;
            // 
            // lbl_AngleConversionSecond
            // 
            this.lbl_AngleConversionSecond.AutoSize = true;
            this.lbl_AngleConversionSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AngleConversionSecond.Location = new System.Drawing.Point(171, 41);
            this.lbl_AngleConversionSecond.Name = "lbl_AngleConversionSecond";
            this.lbl_AngleConversionSecond.Size = new System.Drawing.Size(14, 16);
            this.lbl_AngleConversionSecond.TabIndex = 17;
            this.lbl_AngleConversionSecond.Text = "\"";
            this.lbl_AngleConversionSecond.Visible = false;
            // 
            // btn_AngleConversionConvert
            // 
            this.btn_AngleConversionConvert.Location = new System.Drawing.Point(457, 41);
            this.btn_AngleConversionConvert.Name = "btn_AngleConversionConvert";
            this.btn_AngleConversionConvert.Size = new System.Drawing.Size(75, 23);
            this.btn_AngleConversionConvert.TabIndex = 18;
            this.btn_AngleConversionConvert.Text = "Convert";
            this.btn_AngleConversionConvert.UseVisualStyleBackColor = true;
            this.btn_AngleConversionConvert.Click += new System.EventHandler(this.Btn_AngleConversionConvert_Click);
            // 
            // lbl_ConvertedAngleSecond
            // 
            this.lbl_ConvertedAngleSecond.AutoSize = true;
            this.lbl_ConvertedAngleSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ConvertedAngleSecond.Location = new System.Drawing.Point(710, 39);
            this.lbl_ConvertedAngleSecond.Name = "lbl_ConvertedAngleSecond";
            this.lbl_ConvertedAngleSecond.Size = new System.Drawing.Size(14, 16);
            this.lbl_ConvertedAngleSecond.TabIndex = 25;
            this.lbl_ConvertedAngleSecond.Text = "\"";
            this.lbl_ConvertedAngleSecond.Visible = false;
            // 
            // lbl_ConvertedAngleMinute
            // 
            this.lbl_ConvertedAngleMinute.AutoSize = true;
            this.lbl_ConvertedAngleMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ConvertedAngleMinute.Location = new System.Drawing.Point(639, 39);
            this.lbl_ConvertedAngleMinute.Name = "lbl_ConvertedAngleMinute";
            this.lbl_ConvertedAngleMinute.Size = new System.Drawing.Size(12, 16);
            this.lbl_ConvertedAngleMinute.TabIndex = 24;
            this.lbl_ConvertedAngleMinute.Text = "\'";
            this.lbl_ConvertedAngleMinute.Visible = false;
            // 
            // lbl_ConvertedAngleDegree
            // 
            this.lbl_ConvertedAngleDegree.AutoSize = true;
            this.lbl_ConvertedAngleDegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ConvertedAngleDegree.Location = new System.Drawing.Point(586, 39);
            this.lbl_ConvertedAngleDegree.Name = "lbl_ConvertedAngleDegree";
            this.lbl_ConvertedAngleDegree.Size = new System.Drawing.Size(14, 13);
            this.lbl_ConvertedAngleDegree.TabIndex = 23;
            this.lbl_ConvertedAngleDegree.Text = "o";
            this.lbl_ConvertedAngleDegree.Visible = false;
            // 
            // txtBox_ConvertedAngleSecond
            // 
            this.txtBox_ConvertedAngleSecond.Location = new System.Drawing.Point(657, 42);
            this.txtBox_ConvertedAngleSecond.Name = "txtBox_ConvertedAngleSecond";
            this.txtBox_ConvertedAngleSecond.Size = new System.Drawing.Size(47, 20);
            this.txtBox_ConvertedAngleSecond.TabIndex = 22;
            this.txtBox_ConvertedAngleSecond.Visible = false;
            // 
            // txtBox_ConvertedAngleMinute
            // 
            this.txtBox_ConvertedAngleMinute.Location = new System.Drawing.Point(606, 42);
            this.txtBox_ConvertedAngleMinute.Name = "txtBox_ConvertedAngleMinute";
            this.txtBox_ConvertedAngleMinute.Size = new System.Drawing.Size(27, 20);
            this.txtBox_ConvertedAngleMinute.TabIndex = 21;
            this.txtBox_ConvertedAngleMinute.Visible = false;
            // 
            // txtBox_ConvertedAngleDegree
            // 
            this.txtBox_ConvertedAngleDegree.Location = new System.Drawing.Point(552, 42);
            this.txtBox_ConvertedAngleDegree.Name = "txtBox_ConvertedAngleDegree";
            this.txtBox_ConvertedAngleDegree.Size = new System.Drawing.Size(27, 20);
            this.txtBox_ConvertedAngleDegree.TabIndex = 20;
            this.txtBox_ConvertedAngleDegree.Visible = false;
            // 
            // lbl_AzBearSecond
            // 
            this.lbl_AzBearSecond.AutoSize = true;
            this.lbl_AzBearSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AzBearSecond.Location = new System.Drawing.Point(171, 108);
            this.lbl_AzBearSecond.Name = "lbl_AzBearSecond";
            this.lbl_AzBearSecond.Size = new System.Drawing.Size(14, 16);
            this.lbl_AzBearSecond.TabIndex = 31;
            this.lbl_AzBearSecond.Text = "\"";
            this.lbl_AzBearSecond.Visible = false;
            // 
            // lbl_AzBearMinute
            // 
            this.lbl_AzBearMinute.AutoSize = true;
            this.lbl_AzBearMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AzBearMinute.Location = new System.Drawing.Point(100, 108);
            this.lbl_AzBearMinute.Name = "lbl_AzBearMinute";
            this.lbl_AzBearMinute.Size = new System.Drawing.Size(12, 16);
            this.lbl_AzBearMinute.TabIndex = 30;
            this.lbl_AzBearMinute.Text = "\'";
            this.lbl_AzBearMinute.Visible = false;
            // 
            // lbl_AzBearDegree
            // 
            this.lbl_AzBearDegree.AutoSize = true;
            this.lbl_AzBearDegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AzBearDegree.Location = new System.Drawing.Point(47, 108);
            this.lbl_AzBearDegree.Name = "lbl_AzBearDegree";
            this.lbl_AzBearDegree.Size = new System.Drawing.Size(14, 13);
            this.lbl_AzBearDegree.TabIndex = 29;
            this.lbl_AzBearDegree.Text = "o";
            this.lbl_AzBearDegree.Visible = false;
            // 
            // txtBox_AzBearSecond
            // 
            this.txtBox_AzBearSecond.Location = new System.Drawing.Point(118, 111);
            this.txtBox_AzBearSecond.Name = "txtBox_AzBearSecond";
            this.txtBox_AzBearSecond.Size = new System.Drawing.Size(47, 20);
            this.txtBox_AzBearSecond.TabIndex = 28;
            this.txtBox_AzBearSecond.Visible = false;
            // 
            // txtBox_AzBearMinute
            // 
            this.txtBox_AzBearMinute.Location = new System.Drawing.Point(67, 111);
            this.txtBox_AzBearMinute.Name = "txtBox_AzBearMinute";
            this.txtBox_AzBearMinute.Size = new System.Drawing.Size(27, 20);
            this.txtBox_AzBearMinute.TabIndex = 27;
            this.txtBox_AzBearMinute.Visible = false;
            // 
            // txtBox_AzBearDegree
            // 
            this.txtBox_AzBearDegree.Location = new System.Drawing.Point(13, 111);
            this.txtBox_AzBearDegree.Name = "txtBox_AzBearDegree";
            this.txtBox_AzBearDegree.Size = new System.Drawing.Size(27, 20);
            this.txtBox_AzBearDegree.TabIndex = 26;
            this.txtBox_AzBearDegree.Visible = false;
            // 
            // lbl_ConvertedAngleUnits
            // 
            this.lbl_ConvertedAngleUnits.AutoSize = true;
            this.lbl_ConvertedAngleUnits.Location = new System.Drawing.Point(659, 50);
            this.lbl_ConvertedAngleUnits.Name = "lbl_ConvertedAngleUnits";
            this.lbl_ConvertedAngleUnits.Size = new System.Drawing.Size(0, 13);
            this.lbl_ConvertedAngleUnits.TabIndex = 32;
            // 
            // cmbBox_BearingDirection
            // 
            this.cmbBox_BearingDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_BearingDirection.FormattingEnabled = true;
            this.cmbBox_BearingDirection.Items.AddRange(new object[] {
            "NE",
            "NW",
            "SE",
            "SW"});
            this.cmbBox_BearingDirection.Location = new System.Drawing.Point(12, 139);
            this.cmbBox_BearingDirection.Name = "cmbBox_BearingDirection";
            this.cmbBox_BearingDirection.Size = new System.Drawing.Size(49, 21);
            this.cmbBox_BearingDirection.TabIndex = 33;
            this.cmbBox_BearingDirection.Visible = false;
            // 
            // btn_AzBearConvert
            // 
            this.btn_AzBearConvert.Location = new System.Drawing.Point(457, 110);
            this.btn_AzBearConvert.Name = "btn_AzBearConvert";
            this.btn_AzBearConvert.Size = new System.Drawing.Size(75, 23);
            this.btn_AzBearConvert.TabIndex = 34;
            this.btn_AzBearConvert.Text = "Convert";
            this.btn_AzBearConvert.UseVisualStyleBackColor = true;
            this.btn_AzBearConvert.Click += new System.EventHandler(this.Btn_AzBearConvert_Click);
            // 
            // lbl_ConvertedAzBearSecond
            // 
            this.lbl_ConvertedAzBearSecond.AutoSize = true;
            this.lbl_ConvertedAzBearSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ConvertedAzBearSecond.Location = new System.Drawing.Point(748, 110);
            this.lbl_ConvertedAzBearSecond.Name = "lbl_ConvertedAzBearSecond";
            this.lbl_ConvertedAzBearSecond.Size = new System.Drawing.Size(14, 16);
            this.lbl_ConvertedAzBearSecond.TabIndex = 40;
            this.lbl_ConvertedAzBearSecond.Text = "\"";
            this.lbl_ConvertedAzBearSecond.Visible = false;
            // 
            // lbl_ConvertedAzBearMinute
            // 
            this.lbl_ConvertedAzBearMinute.AutoSize = true;
            this.lbl_ConvertedAzBearMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ConvertedAzBearMinute.Location = new System.Drawing.Point(677, 110);
            this.lbl_ConvertedAzBearMinute.Name = "lbl_ConvertedAzBearMinute";
            this.lbl_ConvertedAzBearMinute.Size = new System.Drawing.Size(12, 16);
            this.lbl_ConvertedAzBearMinute.TabIndex = 39;
            this.lbl_ConvertedAzBearMinute.Text = "\'";
            this.lbl_ConvertedAzBearMinute.Visible = false;
            // 
            // lbl_ConvertedAzBearDegree
            // 
            this.lbl_ConvertedAzBearDegree.AutoSize = true;
            this.lbl_ConvertedAzBearDegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ConvertedAzBearDegree.Location = new System.Drawing.Point(624, 110);
            this.lbl_ConvertedAzBearDegree.Name = "lbl_ConvertedAzBearDegree";
            this.lbl_ConvertedAzBearDegree.Size = new System.Drawing.Size(14, 13);
            this.lbl_ConvertedAzBearDegree.TabIndex = 38;
            this.lbl_ConvertedAzBearDegree.Text = "o";
            this.lbl_ConvertedAzBearDegree.Visible = false;
            // 
            // txtBox_ConvertedAzBearSecond
            // 
            this.txtBox_ConvertedAzBearSecond.Location = new System.Drawing.Point(695, 113);
            this.txtBox_ConvertedAzBearSecond.Name = "txtBox_ConvertedAzBearSecond";
            this.txtBox_ConvertedAzBearSecond.Size = new System.Drawing.Size(47, 20);
            this.txtBox_ConvertedAzBearSecond.TabIndex = 37;
            this.txtBox_ConvertedAzBearSecond.Visible = false;
            // 
            // txtBox_ConvertedAzBearMinute
            // 
            this.txtBox_ConvertedAzBearMinute.Location = new System.Drawing.Point(644, 113);
            this.txtBox_ConvertedAzBearMinute.Name = "txtBox_ConvertedAzBearMinute";
            this.txtBox_ConvertedAzBearMinute.Size = new System.Drawing.Size(27, 20);
            this.txtBox_ConvertedAzBearMinute.TabIndex = 36;
            this.txtBox_ConvertedAzBearMinute.Visible = false;
            // 
            // txtBox_ConvertedAzBearDegree
            // 
            this.txtBox_ConvertedAzBearDegree.Location = new System.Drawing.Point(590, 113);
            this.txtBox_ConvertedAzBearDegree.Name = "txtBox_ConvertedAzBearDegree";
            this.txtBox_ConvertedAzBearDegree.Size = new System.Drawing.Size(27, 20);
            this.txtBox_ConvertedAzBearDegree.TabIndex = 35;
            this.txtBox_ConvertedAzBearDegree.Visible = false;
            // 
            // lbl_ConvertedBearing
            // 
            this.lbl_ConvertedBearing.AutoSize = true;
            this.lbl_ConvertedBearing.Location = new System.Drawing.Point(557, 120);
            this.lbl_ConvertedBearing.Name = "lbl_ConvertedBearing";
            this.lbl_ConvertedBearing.Size = new System.Drawing.Size(22, 13);
            this.lbl_ConvertedBearing.TabIndex = 41;
            this.lbl_ConvertedBearing.Text = "NE";
            this.lbl_ConvertedBearing.Visible = false;
            // 
            // AngleConversionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 180);
            this.Controls.Add(this.lbl_ConvertedBearing);
            this.Controls.Add(this.lbl_ConvertedAzBearSecond);
            this.Controls.Add(this.lbl_ConvertedAzBearMinute);
            this.Controls.Add(this.lbl_ConvertedAzBearDegree);
            this.Controls.Add(this.txtBox_ConvertedAzBearSecond);
            this.Controls.Add(this.txtBox_ConvertedAzBearMinute);
            this.Controls.Add(this.txtBox_ConvertedAzBearDegree);
            this.Controls.Add(this.btn_AzBearConvert);
            this.Controls.Add(this.cmbBox_BearingDirection);
            this.Controls.Add(this.lbl_ConvertedAngleUnits);
            this.Controls.Add(this.lbl_AzBearSecond);
            this.Controls.Add(this.lbl_AzBearMinute);
            this.Controls.Add(this.lbl_AzBearDegree);
            this.Controls.Add(this.txtBox_AzBearSecond);
            this.Controls.Add(this.txtBox_AzBearMinute);
            this.Controls.Add(this.txtBox_AzBearDegree);
            this.Controls.Add(this.lbl_ConvertedAngleSecond);
            this.Controls.Add(this.lbl_ConvertedAngleMinute);
            this.Controls.Add(this.lbl_ConvertedAngleDegree);
            this.Controls.Add(this.txtBox_ConvertedAngleSecond);
            this.Controls.Add(this.txtBox_ConvertedAngleMinute);
            this.Controls.Add(this.txtBox_ConvertedAngleDegree);
            this.Controls.Add(this.btn_AngleConversionConvert);
            this.Controls.Add(this.lbl_AngleConversionSecond);
            this.Controls.Add(this.lbl_AngleConversionMinute);
            this.Controls.Add(this.lbl_AngleConversionDegree);
            this.Controls.Add(this.txtBox_AngleConversionSecond);
            this.Controls.Add(this.txtBox_AngleConversionMinute);
            this.Controls.Add(this.txtBox_AngleConversionDegree);
            this.Controls.Add(this.txtBox_ConvertedAzBearDec);
            this.Controls.Add(this.lbl_AzBearConvertTo);
            this.Controls.Add(this.cmbBox_AzBearConvertTo);
            this.Controls.Add(this.cmbBox_AzBearUnits);
            this.Controls.Add(this.txtBox_AzBearDec);
            this.Controls.Add(this.lbl_AzBearLabel);
            this.Controls.Add(this.txtBox_ConvertedAngle);
            this.Controls.Add(this.lbl_ConvertAngleTo);
            this.Controls.Add(this.cmbBox_ConvertAngleUnitsTo);
            this.Controls.Add(this.cmbBox_AngleUnits);
            this.Controls.Add(this.txtBox_AngleConversion);
            this.Controls.Add(this.lbl_AngleConversion);
            this.Name = "AngleConversionForm";
            this.Text = "Angle Conversion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_AngleConversion;
        private System.Windows.Forms.TextBox txtBox_AngleConversion;
        private System.Windows.Forms.ComboBox cmbBox_AngleUnits;
        private System.Windows.Forms.ComboBox cmbBox_ConvertAngleUnitsTo;
        private System.Windows.Forms.Label lbl_ConvertAngleTo;
        private System.Windows.Forms.TextBox txtBox_ConvertedAngle;
        private System.Windows.Forms.TextBox txtBox_ConvertedAzBearDec;
        private System.Windows.Forms.Label lbl_AzBearConvertTo;
        private System.Windows.Forms.ComboBox cmbBox_AzBearConvertTo;
        private System.Windows.Forms.ComboBox cmbBox_AzBearUnits;
        private System.Windows.Forms.TextBox txtBox_AzBearDec;
        private System.Windows.Forms.Label lbl_AzBearLabel;
        private System.Windows.Forms.TextBox txtBox_AngleConversionDegree;
        private System.Windows.Forms.TextBox txtBox_AngleConversionMinute;
        private System.Windows.Forms.TextBox txtBox_AngleConversionSecond;
        private System.Windows.Forms.Label lbl_AngleConversionDegree;
        private System.Windows.Forms.Label lbl_AngleConversionMinute;
        private System.Windows.Forms.Label lbl_AngleConversionSecond;
        private System.Windows.Forms.Button btn_AngleConversionConvert;
        private System.Windows.Forms.Label lbl_ConvertedAngleSecond;
        private System.Windows.Forms.Label lbl_ConvertedAngleMinute;
        private System.Windows.Forms.Label lbl_ConvertedAngleDegree;
        private System.Windows.Forms.TextBox txtBox_ConvertedAngleSecond;
        private System.Windows.Forms.TextBox txtBox_ConvertedAngleMinute;
        private System.Windows.Forms.TextBox txtBox_ConvertedAngleDegree;
        private System.Windows.Forms.Label lbl_AzBearSecond;
        private System.Windows.Forms.Label lbl_AzBearMinute;
        private System.Windows.Forms.Label lbl_AzBearDegree;
        private System.Windows.Forms.TextBox txtBox_AzBearSecond;
        private System.Windows.Forms.TextBox txtBox_AzBearMinute;
        private System.Windows.Forms.TextBox txtBox_AzBearDegree;
        private System.Windows.Forms.Label lbl_ConvertedAngleUnits;
        private System.Windows.Forms.ComboBox cmbBox_BearingDirection;
        private System.Windows.Forms.Button btn_AzBearConvert;
        private System.Windows.Forms.Label lbl_ConvertedAzBearSecond;
        private System.Windows.Forms.Label lbl_ConvertedAzBearMinute;
        private System.Windows.Forms.Label lbl_ConvertedAzBearDegree;
        private System.Windows.Forms.TextBox txtBox_ConvertedAzBearSecond;
        private System.Windows.Forms.TextBox txtBox_ConvertedAzBearMinute;
        private System.Windows.Forms.TextBox txtBox_ConvertedAzBearDegree;
        private System.Windows.Forms.Label lbl_ConvertedBearing;
    }
}