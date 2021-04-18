
namespace SurveyingCalculator
{
    partial class HorizontalCurveForm
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
            this.radBtn_Feet = new System.Windows.Forms.RadioButton();
            this.radBtn_Meter = new System.Windows.Forms.RadioButton();
            this.grpBox_Units = new System.Windows.Forms.GroupBox();
            this.grpBox_CurveDefinition = new System.Windows.Forms.GroupBox();
            this.radBtn_ArcDefinition = new System.Windows.Forms.RadioButton();
            this.radBtn_ChordDefinition = new System.Windows.Forms.RadioButton();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.grpBox_PointOf = new System.Windows.Forms.GroupBox();
            this.txtBox_PointOfTangent = new System.Windows.Forms.TextBox();
            this.txtBox_PointOfCurvature = new System.Windows.Forms.TextBox();
            this.txtBox_PointOfIntersection = new System.Windows.Forms.TextBox();
            this.lbl_PointOfTangent = new System.Windows.Forms.Label();
            this.lbl_PointOfCurvature = new System.Windows.Forms.Label();
            this.lbl_PointOfIntersection = new System.Windows.Forms.Label();
            this.grpBox_Measurements = new System.Windows.Forms.GroupBox();
            this.txtBox_Tangent = new System.Windows.Forms.TextBox();
            this.lbl_Tangent = new System.Windows.Forms.Label();
            this.txtBox_MiddleOrdinate = new System.Windows.Forms.TextBox();
            this.txtBox_ExternalDistance = new System.Windows.Forms.TextBox();
            this.txtBox_LongChord = new System.Windows.Forms.TextBox();
            this.txtBox_LengthOfCurve = new System.Windows.Forms.TextBox();
            this.txtBox_Radius = new System.Windows.Forms.TextBox();
            this.lbl_DegreeOfSecond = new System.Windows.Forms.Label();
            this.lbl_DegreeOfCurveMinute = new System.Windows.Forms.Label();
            this.lbl_DegreeOfCurveDegree = new System.Windows.Forms.Label();
            this.txtBox_DegreeOfCurveSecond = new System.Windows.Forms.TextBox();
            this.txtBox_DegreeOfCurveMinute = new System.Windows.Forms.TextBox();
            this.txtBox_DegreeOfCurveDegree = new System.Windows.Forms.TextBox();
            this.lbl_DegreeOfCurve = new System.Windows.Forms.Label();
            this.lbl_LengthOfCurve = new System.Windows.Forms.Label();
            this.lbl_MiddleOrdinate = new System.Windows.Forms.Label();
            this.lbl_IntersectionSecond = new System.Windows.Forms.Label();
            this.lbl_IntersectionAngle = new System.Windows.Forms.Label();
            this.lbl_IntersectionMinute = new System.Windows.Forms.Label();
            this.lbl_IntersectionDegree = new System.Windows.Forms.Label();
            this.lbl_ExternalDistance = new System.Windows.Forms.Label();
            this.txtBox_IntersectionSecond = new System.Windows.Forms.TextBox();
            this.lbl_LongChord = new System.Windows.Forms.Label();
            this.txtBox_IntersectionMinute = new System.Windows.Forms.TextBox();
            this.lbl_Radius = new System.Windows.Forms.Label();
            this.txtBox_IntersectionDegree = new System.Windows.Forms.TextBox();
            this.cmbBox_Stations = new System.Windows.Forms.ComboBox();
            this.lbl_Stations = new System.Windows.Forms.Label();
            this.lbl_Measurement1 = new System.Windows.Forms.Label();
            this.lbl_Measurement2 = new System.Windows.Forms.Label();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.cmbBox_Measurement1 = new System.Windows.Forms.ComboBox();
            this.cmbBox_Measurement2 = new System.Windows.Forms.ComboBox();
            this.grpBox_Units.SuspendLayout();
            this.grpBox_CurveDefinition.SuspendLayout();
            this.grpBox_PointOf.SuspendLayout();
            this.grpBox_Measurements.SuspendLayout();
            this.SuspendLayout();
            // 
            // radBtn_Feet
            // 
            this.radBtn_Feet.AutoSize = true;
            this.radBtn_Feet.Location = new System.Drawing.Point(6, 19);
            this.radBtn_Feet.Name = "radBtn_Feet";
            this.radBtn_Feet.Size = new System.Drawing.Size(43, 17);
            this.radBtn_Feet.TabIndex = 0;
            this.radBtn_Feet.TabStop = true;
            this.radBtn_Feet.Text = "feet";
            this.radBtn_Feet.UseVisualStyleBackColor = true;
            // 
            // radBtn_Meter
            // 
            this.radBtn_Meter.AutoSize = true;
            this.radBtn_Meter.Location = new System.Drawing.Point(55, 19);
            this.radBtn_Meter.Name = "radBtn_Meter";
            this.radBtn_Meter.Size = new System.Drawing.Size(51, 17);
            this.radBtn_Meter.TabIndex = 1;
            this.radBtn_Meter.TabStop = true;
            this.radBtn_Meter.Text = "meter";
            this.radBtn_Meter.UseVisualStyleBackColor = true;
            // 
            // grpBox_Units
            // 
            this.grpBox_Units.Controls.Add(this.radBtn_Feet);
            this.grpBox_Units.Controls.Add(this.radBtn_Meter);
            this.grpBox_Units.Location = new System.Drawing.Point(12, 24);
            this.grpBox_Units.Name = "grpBox_Units";
            this.grpBox_Units.Size = new System.Drawing.Size(111, 53);
            this.grpBox_Units.TabIndex = 2;
            this.grpBox_Units.TabStop = false;
            this.grpBox_Units.Text = "Units";
            // 
            // grpBox_CurveDefinition
            // 
            this.grpBox_CurveDefinition.Controls.Add(this.radBtn_ArcDefinition);
            this.grpBox_CurveDefinition.Controls.Add(this.radBtn_ChordDefinition);
            this.grpBox_CurveDefinition.Location = new System.Drawing.Point(138, 24);
            this.grpBox_CurveDefinition.Name = "grpBox_CurveDefinition";
            this.grpBox_CurveDefinition.Size = new System.Drawing.Size(111, 53);
            this.grpBox_CurveDefinition.TabIndex = 3;
            this.grpBox_CurveDefinition.TabStop = false;
            this.grpBox_CurveDefinition.Text = "Curve Definition";
            // 
            // radBtn_ArcDefinition
            // 
            this.radBtn_ArcDefinition.AutoSize = true;
            this.radBtn_ArcDefinition.Location = new System.Drawing.Point(6, 19);
            this.radBtn_ArcDefinition.Name = "radBtn_ArcDefinition";
            this.radBtn_ArcDefinition.Size = new System.Drawing.Size(40, 17);
            this.radBtn_ArcDefinition.TabIndex = 0;
            this.radBtn_ArcDefinition.TabStop = true;
            this.radBtn_ArcDefinition.Text = "arc";
            this.radBtn_ArcDefinition.UseVisualStyleBackColor = true;
            // 
            // radBtn_ChordDefinition
            // 
            this.radBtn_ChordDefinition.AutoSize = true;
            this.radBtn_ChordDefinition.Location = new System.Drawing.Point(55, 19);
            this.radBtn_ChordDefinition.Name = "radBtn_ChordDefinition";
            this.radBtn_ChordDefinition.Size = new System.Drawing.Size(52, 17);
            this.radBtn_ChordDefinition.TabIndex = 1;
            this.radBtn_ChordDefinition.TabStop = true;
            this.radBtn_ChordDefinition.Text = "chord";
            this.radBtn_ChordDefinition.UseVisualStyleBackColor = true;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(138, 307);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 4;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // grpBox_PointOf
            // 
            this.grpBox_PointOf.Controls.Add(this.txtBox_PointOfTangent);
            this.grpBox_PointOf.Controls.Add(this.txtBox_PointOfCurvature);
            this.grpBox_PointOf.Controls.Add(this.txtBox_PointOfIntersection);
            this.grpBox_PointOf.Controls.Add(this.lbl_PointOfTangent);
            this.grpBox_PointOf.Controls.Add(this.lbl_PointOfCurvature);
            this.grpBox_PointOf.Controls.Add(this.lbl_PointOfIntersection);
            this.grpBox_PointOf.Location = new System.Drawing.Point(12, 93);
            this.grpBox_PointOf.Name = "grpBox_PointOf";
            this.grpBox_PointOf.Size = new System.Drawing.Size(245, 124);
            this.grpBox_PointOf.TabIndex = 5;
            this.grpBox_PointOf.TabStop = false;
            this.grpBox_PointOf.Text = "Station:  ";
            // 
            // txtBox_PointOfTangent
            // 
            this.txtBox_PointOfTangent.Location = new System.Drawing.Point(132, 88);
            this.txtBox_PointOfTangent.Name = "txtBox_PointOfTangent";
            this.txtBox_PointOfTangent.Size = new System.Drawing.Size(100, 20);
            this.txtBox_PointOfTangent.TabIndex = 5;
            // 
            // txtBox_PointOfCurvature
            // 
            this.txtBox_PointOfCurvature.Location = new System.Drawing.Point(132, 58);
            this.txtBox_PointOfCurvature.Name = "txtBox_PointOfCurvature";
            this.txtBox_PointOfCurvature.Size = new System.Drawing.Size(100, 20);
            this.txtBox_PointOfCurvature.TabIndex = 4;
            // 
            // txtBox_PointOfIntersection
            // 
            this.txtBox_PointOfIntersection.Location = new System.Drawing.Point(132, 26);
            this.txtBox_PointOfIntersection.Name = "txtBox_PointOfIntersection";
            this.txtBox_PointOfIntersection.Size = new System.Drawing.Size(100, 20);
            this.txtBox_PointOfIntersection.TabIndex = 3;
            // 
            // lbl_PointOfTangent
            // 
            this.lbl_PointOfTangent.AutoSize = true;
            this.lbl_PointOfTangent.Location = new System.Drawing.Point(8, 95);
            this.lbl_PointOfTangent.Name = "lbl_PointOfTangent";
            this.lbl_PointOfTangent.Size = new System.Drawing.Size(112, 13);
            this.lbl_PointOfTangent.TabIndex = 2;
            this.lbl_PointOfTangent.Text = "Point of Tangent (PT):";
            // 
            // lbl_PointOfCurvature
            // 
            this.lbl_PointOfCurvature.AutoSize = true;
            this.lbl_PointOfCurvature.Location = new System.Drawing.Point(8, 65);
            this.lbl_PointOfCurvature.Name = "lbl_PointOfCurvature";
            this.lbl_PointOfCurvature.Size = new System.Drawing.Size(118, 13);
            this.lbl_PointOfCurvature.TabIndex = 1;
            this.lbl_PointOfCurvature.Text = "Point of Curvature (PC):";
            // 
            // lbl_PointOfIntersection
            // 
            this.lbl_PointOfIntersection.AutoSize = true;
            this.lbl_PointOfIntersection.Location = new System.Drawing.Point(9, 33);
            this.lbl_PointOfIntersection.Name = "lbl_PointOfIntersection";
            this.lbl_PointOfIntersection.Size = new System.Drawing.Size(123, 13);
            this.lbl_PointOfIntersection.TabIndex = 0;
            this.lbl_PointOfIntersection.Text = "Point of Intersection (PI):";
            // 
            // grpBox_Measurements
            // 
            this.grpBox_Measurements.Controls.Add(this.txtBox_Tangent);
            this.grpBox_Measurements.Controls.Add(this.lbl_Tangent);
            this.grpBox_Measurements.Controls.Add(this.txtBox_MiddleOrdinate);
            this.grpBox_Measurements.Controls.Add(this.txtBox_ExternalDistance);
            this.grpBox_Measurements.Controls.Add(this.txtBox_LongChord);
            this.grpBox_Measurements.Controls.Add(this.txtBox_LengthOfCurve);
            this.grpBox_Measurements.Controls.Add(this.txtBox_Radius);
            this.grpBox_Measurements.Controls.Add(this.lbl_DegreeOfSecond);
            this.grpBox_Measurements.Controls.Add(this.lbl_DegreeOfCurveMinute);
            this.grpBox_Measurements.Controls.Add(this.lbl_DegreeOfCurveDegree);
            this.grpBox_Measurements.Controls.Add(this.txtBox_DegreeOfCurveSecond);
            this.grpBox_Measurements.Controls.Add(this.txtBox_DegreeOfCurveMinute);
            this.grpBox_Measurements.Controls.Add(this.txtBox_DegreeOfCurveDegree);
            this.grpBox_Measurements.Controls.Add(this.lbl_DegreeOfCurve);
            this.grpBox_Measurements.Controls.Add(this.lbl_LengthOfCurve);
            this.grpBox_Measurements.Controls.Add(this.lbl_MiddleOrdinate);
            this.grpBox_Measurements.Controls.Add(this.lbl_IntersectionSecond);
            this.grpBox_Measurements.Controls.Add(this.lbl_IntersectionAngle);
            this.grpBox_Measurements.Controls.Add(this.lbl_IntersectionMinute);
            this.grpBox_Measurements.Controls.Add(this.lbl_IntersectionDegree);
            this.grpBox_Measurements.Controls.Add(this.lbl_ExternalDistance);
            this.grpBox_Measurements.Controls.Add(this.txtBox_IntersectionSecond);
            this.grpBox_Measurements.Controls.Add(this.lbl_LongChord);
            this.grpBox_Measurements.Controls.Add(this.txtBox_IntersectionMinute);
            this.grpBox_Measurements.Controls.Add(this.lbl_Radius);
            this.grpBox_Measurements.Controls.Add(this.txtBox_IntersectionDegree);
            this.grpBox_Measurements.Location = new System.Drawing.Point(263, 24);
            this.grpBox_Measurements.Name = "grpBox_Measurements";
            this.grpBox_Measurements.Size = new System.Drawing.Size(306, 243);
            this.grpBox_Measurements.TabIndex = 6;
            this.grpBox_Measurements.TabStop = false;
            this.grpBox_Measurements.Text = "Measurements:";
            // 
            // txtBox_Tangent
            // 
            this.txtBox_Tangent.Location = new System.Drawing.Point(124, 205);
            this.txtBox_Tangent.Name = "txtBox_Tangent";
            this.txtBox_Tangent.Size = new System.Drawing.Size(100, 20);
            this.txtBox_Tangent.TabIndex = 38;
            // 
            // lbl_Tangent
            // 
            this.lbl_Tangent.AutoSize = true;
            this.lbl_Tangent.Location = new System.Drawing.Point(10, 212);
            this.lbl_Tangent.Name = "lbl_Tangent";
            this.lbl_Tangent.Size = new System.Drawing.Size(66, 13);
            this.lbl_Tangent.TabIndex = 37;
            this.lbl_Tangent.Text = "Tangent (T):";
            // 
            // txtBox_MiddleOrdinate
            // 
            this.txtBox_MiddleOrdinate.Location = new System.Drawing.Point(125, 154);
            this.txtBox_MiddleOrdinate.Name = "txtBox_MiddleOrdinate";
            this.txtBox_MiddleOrdinate.Size = new System.Drawing.Size(100, 20);
            this.txtBox_MiddleOrdinate.TabIndex = 36;
            // 
            // txtBox_ExternalDistance
            // 
            this.txtBox_ExternalDistance.Location = new System.Drawing.Point(125, 43);
            this.txtBox_ExternalDistance.Name = "txtBox_ExternalDistance";
            this.txtBox_ExternalDistance.Size = new System.Drawing.Size(100, 20);
            this.txtBox_ExternalDistance.TabIndex = 35;
            // 
            // txtBox_LongChord
            // 
            this.txtBox_LongChord.Location = new System.Drawing.Point(125, 124);
            this.txtBox_LongChord.Name = "txtBox_LongChord";
            this.txtBox_LongChord.Size = new System.Drawing.Size(100, 20);
            this.txtBox_LongChord.TabIndex = 34;
            // 
            // txtBox_LengthOfCurve
            // 
            this.txtBox_LengthOfCurve.Location = new System.Drawing.Point(125, 99);
            this.txtBox_LengthOfCurve.Name = "txtBox_LengthOfCurve";
            this.txtBox_LengthOfCurve.Size = new System.Drawing.Size(100, 20);
            this.txtBox_LengthOfCurve.TabIndex = 33;
            // 
            // txtBox_Radius
            // 
            this.txtBox_Radius.Location = new System.Drawing.Point(125, 179);
            this.txtBox_Radius.Name = "txtBox_Radius";
            this.txtBox_Radius.Size = new System.Drawing.Size(100, 20);
            this.txtBox_Radius.TabIndex = 32;
            // 
            // lbl_DegreeOfSecond
            // 
            this.lbl_DegreeOfSecond.AutoSize = true;
            this.lbl_DegreeOfSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DegreeOfSecond.Location = new System.Drawing.Point(283, 13);
            this.lbl_DegreeOfSecond.Name = "lbl_DegreeOfSecond";
            this.lbl_DegreeOfSecond.Size = new System.Drawing.Size(14, 16);
            this.lbl_DegreeOfSecond.TabIndex = 31;
            this.lbl_DegreeOfSecond.Text = "\"";
            // 
            // lbl_DegreeOfCurveMinute
            // 
            this.lbl_DegreeOfCurveMinute.AutoSize = true;
            this.lbl_DegreeOfCurveMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DegreeOfCurveMinute.Location = new System.Drawing.Point(212, 13);
            this.lbl_DegreeOfCurveMinute.Name = "lbl_DegreeOfCurveMinute";
            this.lbl_DegreeOfCurveMinute.Size = new System.Drawing.Size(12, 16);
            this.lbl_DegreeOfCurveMinute.TabIndex = 30;
            this.lbl_DegreeOfCurveMinute.Text = "\'";
            // 
            // lbl_DegreeOfCurveDegree
            // 
            this.lbl_DegreeOfCurveDegree.AutoSize = true;
            this.lbl_DegreeOfCurveDegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DegreeOfCurveDegree.Location = new System.Drawing.Point(159, 13);
            this.lbl_DegreeOfCurveDegree.Name = "lbl_DegreeOfCurveDegree";
            this.lbl_DegreeOfCurveDegree.Size = new System.Drawing.Size(14, 13);
            this.lbl_DegreeOfCurveDegree.TabIndex = 29;
            this.lbl_DegreeOfCurveDegree.Text = "o";
            // 
            // txtBox_DegreeOfCurveSecond
            // 
            this.txtBox_DegreeOfCurveSecond.Location = new System.Drawing.Point(230, 16);
            this.txtBox_DegreeOfCurveSecond.Name = "txtBox_DegreeOfCurveSecond";
            this.txtBox_DegreeOfCurveSecond.Size = new System.Drawing.Size(47, 20);
            this.txtBox_DegreeOfCurveSecond.TabIndex = 28;
            // 
            // txtBox_DegreeOfCurveMinute
            // 
            this.txtBox_DegreeOfCurveMinute.Location = new System.Drawing.Point(179, 16);
            this.txtBox_DegreeOfCurveMinute.Name = "txtBox_DegreeOfCurveMinute";
            this.txtBox_DegreeOfCurveMinute.Size = new System.Drawing.Size(27, 20);
            this.txtBox_DegreeOfCurveMinute.TabIndex = 27;
            // 
            // txtBox_DegreeOfCurveDegree
            // 
            this.txtBox_DegreeOfCurveDegree.Location = new System.Drawing.Point(125, 16);
            this.txtBox_DegreeOfCurveDegree.Name = "txtBox_DegreeOfCurveDegree";
            this.txtBox_DegreeOfCurveDegree.Size = new System.Drawing.Size(27, 20);
            this.txtBox_DegreeOfCurveDegree.TabIndex = 26;
            // 
            // lbl_DegreeOfCurve
            // 
            this.lbl_DegreeOfCurve.AutoSize = true;
            this.lbl_DegreeOfCurve.Location = new System.Drawing.Point(10, 23);
            this.lbl_DegreeOfCurve.Name = "lbl_DegreeOfCurve";
            this.lbl_DegreeOfCurve.Size = new System.Drawing.Size(105, 13);
            this.lbl_DegreeOfCurve.TabIndex = 25;
            this.lbl_DegreeOfCurve.Text = "Degree of Curve (D):";
            // 
            // lbl_LengthOfCurve
            // 
            this.lbl_LengthOfCurve.AutoSize = true;
            this.lbl_LengthOfCurve.Location = new System.Drawing.Point(10, 106);
            this.lbl_LengthOfCurve.Name = "lbl_LengthOfCurve";
            this.lbl_LengthOfCurve.Size = new System.Drawing.Size(101, 13);
            this.lbl_LengthOfCurve.TabIndex = 0;
            this.lbl_LengthOfCurve.Text = "Length of Curve (L):";
            // 
            // lbl_MiddleOrdinate
            // 
            this.lbl_MiddleOrdinate.AutoSize = true;
            this.lbl_MiddleOrdinate.Location = new System.Drawing.Point(10, 157);
            this.lbl_MiddleOrdinate.Name = "lbl_MiddleOrdinate";
            this.lbl_MiddleOrdinate.Size = new System.Drawing.Size(102, 13);
            this.lbl_MiddleOrdinate.TabIndex = 4;
            this.lbl_MiddleOrdinate.Text = "Middle Ordinate (M):";
            // 
            // lbl_IntersectionSecond
            // 
            this.lbl_IntersectionSecond.AutoSize = true;
            this.lbl_IntersectionSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IntersectionSecond.Location = new System.Drawing.Point(283, 69);
            this.lbl_IntersectionSecond.Name = "lbl_IntersectionSecond";
            this.lbl_IntersectionSecond.Size = new System.Drawing.Size(14, 16);
            this.lbl_IntersectionSecond.TabIndex = 24;
            this.lbl_IntersectionSecond.Text = "\"";
            // 
            // lbl_IntersectionAngle
            // 
            this.lbl_IntersectionAngle.AutoSize = true;
            this.lbl_IntersectionAngle.Location = new System.Drawing.Point(10, 79);
            this.lbl_IntersectionAngle.Name = "lbl_IntersectionAngle";
            this.lbl_IntersectionAngle.Size = new System.Drawing.Size(107, 13);
            this.lbl_IntersectionAngle.TabIndex = 5;
            this.lbl_IntersectionAngle.Text = "Intersection Angle (I):";
            // 
            // lbl_IntersectionMinute
            // 
            this.lbl_IntersectionMinute.AutoSize = true;
            this.lbl_IntersectionMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IntersectionMinute.Location = new System.Drawing.Point(212, 69);
            this.lbl_IntersectionMinute.Name = "lbl_IntersectionMinute";
            this.lbl_IntersectionMinute.Size = new System.Drawing.Size(12, 16);
            this.lbl_IntersectionMinute.TabIndex = 23;
            this.lbl_IntersectionMinute.Text = "\'";
            // 
            // lbl_IntersectionDegree
            // 
            this.lbl_IntersectionDegree.AutoSize = true;
            this.lbl_IntersectionDegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IntersectionDegree.Location = new System.Drawing.Point(159, 69);
            this.lbl_IntersectionDegree.Name = "lbl_IntersectionDegree";
            this.lbl_IntersectionDegree.Size = new System.Drawing.Size(14, 13);
            this.lbl_IntersectionDegree.TabIndex = 22;
            this.lbl_IntersectionDegree.Text = "o";
            // 
            // lbl_ExternalDistance
            // 
            this.lbl_ExternalDistance.AutoSize = true;
            this.lbl_ExternalDistance.Location = new System.Drawing.Point(10, 50);
            this.lbl_ExternalDistance.Name = "lbl_ExternalDistance";
            this.lbl_ExternalDistance.Size = new System.Drawing.Size(109, 13);
            this.lbl_ExternalDistance.TabIndex = 3;
            this.lbl_ExternalDistance.Text = "External Distance (E):";
            // 
            // txtBox_IntersectionSecond
            // 
            this.txtBox_IntersectionSecond.Location = new System.Drawing.Point(230, 72);
            this.txtBox_IntersectionSecond.Name = "txtBox_IntersectionSecond";
            this.txtBox_IntersectionSecond.Size = new System.Drawing.Size(47, 20);
            this.txtBox_IntersectionSecond.TabIndex = 21;
            // 
            // lbl_LongChord
            // 
            this.lbl_LongChord.AutoSize = true;
            this.lbl_LongChord.Location = new System.Drawing.Point(10, 131);
            this.lbl_LongChord.Name = "lbl_LongChord";
            this.lbl_LongChord.Size = new System.Drawing.Size(87, 13);
            this.lbl_LongChord.TabIndex = 2;
            this.lbl_LongChord.Text = "Long Chord (LC):";
            // 
            // txtBox_IntersectionMinute
            // 
            this.txtBox_IntersectionMinute.Location = new System.Drawing.Point(179, 72);
            this.txtBox_IntersectionMinute.Name = "txtBox_IntersectionMinute";
            this.txtBox_IntersectionMinute.Size = new System.Drawing.Size(27, 20);
            this.txtBox_IntersectionMinute.TabIndex = 20;
            // 
            // lbl_Radius
            // 
            this.lbl_Radius.AutoSize = true;
            this.lbl_Radius.Location = new System.Drawing.Point(10, 186);
            this.lbl_Radius.Name = "lbl_Radius";
            this.lbl_Radius.Size = new System.Drawing.Size(60, 13);
            this.lbl_Radius.TabIndex = 1;
            this.lbl_Radius.Text = "Radius (R):";
            // 
            // txtBox_IntersectionDegree
            // 
            this.txtBox_IntersectionDegree.Location = new System.Drawing.Point(125, 72);
            this.txtBox_IntersectionDegree.Name = "txtBox_IntersectionDegree";
            this.txtBox_IntersectionDegree.Size = new System.Drawing.Size(27, 20);
            this.txtBox_IntersectionDegree.TabIndex = 19;
            // 
            // cmbBox_Stations
            // 
            this.cmbBox_Stations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_Stations.FormattingEnabled = true;
            this.cmbBox_Stations.Items.AddRange(new object[] {
            "PI",
            "PC",
            "PT"});
            this.cmbBox_Stations.Location = new System.Drawing.Point(21, 280);
            this.cmbBox_Stations.Name = "cmbBox_Stations";
            this.cmbBox_Stations.Size = new System.Drawing.Size(54, 21);
            this.cmbBox_Stations.TabIndex = 6;
            // 
            // lbl_Stations
            // 
            this.lbl_Stations.AutoSize = true;
            this.lbl_Stations.Location = new System.Drawing.Point(30, 254);
            this.lbl_Stations.Name = "lbl_Stations";
            this.lbl_Stations.Size = new System.Drawing.Size(40, 13);
            this.lbl_Stations.TabIndex = 7;
            this.lbl_Stations.Text = "Station";
            // 
            // lbl_Measurement1
            // 
            this.lbl_Measurement1.AutoSize = true;
            this.lbl_Measurement1.Location = new System.Drawing.Point(90, 254);
            this.lbl_Measurement1.Name = "lbl_Measurement1";
            this.lbl_Measurement1.Size = new System.Drawing.Size(80, 13);
            this.lbl_Measurement1.TabIndex = 8;
            this.lbl_Measurement1.Text = "Measurement 1";
            // 
            // lbl_Measurement2
            // 
            this.lbl_Measurement2.AutoSize = true;
            this.lbl_Measurement2.Location = new System.Drawing.Point(176, 254);
            this.lbl_Measurement2.Name = "lbl_Measurement2";
            this.lbl_Measurement2.Size = new System.Drawing.Size(80, 13);
            this.lbl_Measurement2.TabIndex = 9;
            this.lbl_Measurement2.Text = "Measurement 2";
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Location = new System.Drawing.Point(48, 307);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(75, 23);
            this.btn_Calculate.TabIndex = 10;
            this.btn_Calculate.Text = "Calculate";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.Btn_Calculate_Click);
            // 
            // cmbBox_Measurement1
            // 
            this.cmbBox_Measurement1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_Measurement1.FormattingEnabled = true;
            this.cmbBox_Measurement1.Items.AddRange(new object[] {
            "D",
            "E",
            "I",
            "L",
            "LC",
            "M",
            "R",
            "T"});
            this.cmbBox_Measurement1.Location = new System.Drawing.Point(103, 280);
            this.cmbBox_Measurement1.Name = "cmbBox_Measurement1";
            this.cmbBox_Measurement1.Size = new System.Drawing.Size(54, 21);
            this.cmbBox_Measurement1.TabIndex = 11;
            // 
            // cmbBox_Measurement2
            // 
            this.cmbBox_Measurement2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_Measurement2.FormattingEnabled = true;
            this.cmbBox_Measurement2.Items.AddRange(new object[] {
            "D",
            "E",
            "I",
            "L",
            "LC",
            "M",
            "R",
            "T"});
            this.cmbBox_Measurement2.Location = new System.Drawing.Point(180, 280);
            this.cmbBox_Measurement2.Name = "cmbBox_Measurement2";
            this.cmbBox_Measurement2.Size = new System.Drawing.Size(54, 21);
            this.cmbBox_Measurement2.TabIndex = 12;
            // 
            // HorizontalCurveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 341);
            this.Controls.Add(this.cmbBox_Measurement2);
            this.Controls.Add(this.cmbBox_Measurement1);
            this.Controls.Add(this.btn_Calculate);
            this.Controls.Add(this.lbl_Measurement2);
            this.Controls.Add(this.lbl_Measurement1);
            this.Controls.Add(this.lbl_Stations);
            this.Controls.Add(this.cmbBox_Stations);
            this.Controls.Add(this.grpBox_Measurements);
            this.Controls.Add(this.grpBox_PointOf);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.grpBox_CurveDefinition);
            this.Controls.Add(this.grpBox_Units);
            this.Name = "HorizontalCurveForm";
            this.Text = "Horizontal Curve Calculation";
            this.grpBox_Units.ResumeLayout(false);
            this.grpBox_Units.PerformLayout();
            this.grpBox_CurveDefinition.ResumeLayout(false);
            this.grpBox_CurveDefinition.PerformLayout();
            this.grpBox_PointOf.ResumeLayout(false);
            this.grpBox_PointOf.PerformLayout();
            this.grpBox_Measurements.ResumeLayout(false);
            this.grpBox_Measurements.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radBtn_Feet;
        private System.Windows.Forms.RadioButton radBtn_Meter;
        private System.Windows.Forms.GroupBox grpBox_Units;
        private System.Windows.Forms.GroupBox grpBox_CurveDefinition;
        private System.Windows.Forms.RadioButton radBtn_ArcDefinition;
        private System.Windows.Forms.RadioButton radBtn_ChordDefinition;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.GroupBox grpBox_PointOf;
        private System.Windows.Forms.TextBox txtBox_PointOfTangent;
        private System.Windows.Forms.TextBox txtBox_PointOfCurvature;
        private System.Windows.Forms.TextBox txtBox_PointOfIntersection;
        private System.Windows.Forms.Label lbl_PointOfTangent;
        private System.Windows.Forms.Label lbl_PointOfCurvature;
        private System.Windows.Forms.Label lbl_PointOfIntersection;
        private System.Windows.Forms.GroupBox grpBox_Measurements;
        private System.Windows.Forms.Label lbl_IntersectionAngle;
        private System.Windows.Forms.Label lbl_MiddleOrdinate;
        private System.Windows.Forms.Label lbl_ExternalDistance;
        private System.Windows.Forms.Label lbl_LongChord;
        private System.Windows.Forms.Label lbl_Radius;
        private System.Windows.Forms.Label lbl_LengthOfCurve;
        private System.Windows.Forms.ComboBox cmbBox_Stations;
        private System.Windows.Forms.Label lbl_Stations;
        private System.Windows.Forms.TextBox txtBox_MiddleOrdinate;
        private System.Windows.Forms.TextBox txtBox_ExternalDistance;
        private System.Windows.Forms.TextBox txtBox_LongChord;
        private System.Windows.Forms.TextBox txtBox_LengthOfCurve;
        private System.Windows.Forms.TextBox txtBox_Radius;
        private System.Windows.Forms.Label lbl_DegreeOfSecond;
        private System.Windows.Forms.Label lbl_DegreeOfCurveMinute;
        private System.Windows.Forms.Label lbl_DegreeOfCurveDegree;
        private System.Windows.Forms.TextBox txtBox_DegreeOfCurveSecond;
        private System.Windows.Forms.TextBox txtBox_DegreeOfCurveMinute;
        private System.Windows.Forms.TextBox txtBox_DegreeOfCurveDegree;
        private System.Windows.Forms.Label lbl_DegreeOfCurve;
        private System.Windows.Forms.Label lbl_IntersectionSecond;
        private System.Windows.Forms.Label lbl_IntersectionMinute;
        private System.Windows.Forms.Label lbl_IntersectionDegree;
        private System.Windows.Forms.TextBox txtBox_IntersectionSecond;
        private System.Windows.Forms.TextBox txtBox_IntersectionMinute;
        private System.Windows.Forms.TextBox txtBox_IntersectionDegree;
        private System.Windows.Forms.Label lbl_Measurement1;
        private System.Windows.Forms.Label lbl_Measurement2;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.ComboBox cmbBox_Measurement1;
        private System.Windows.Forms.ComboBox cmbBox_Measurement2;
        private System.Windows.Forms.TextBox txtBox_Tangent;
        private System.Windows.Forms.Label lbl_Tangent;
    }
}