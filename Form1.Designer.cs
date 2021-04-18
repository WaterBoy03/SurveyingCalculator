
namespace SurveyingCalculator
{
    partial class IntroForm
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
            this.lbl_Welcome1 = new System.Windows.Forms.Label();
            this.btn_ToUnitConversions = new System.Windows.Forms.Button();
            this.btn_ToAngleConversions = new System.Windows.Forms.Button();
            this.btn_ToHorizontalCurveForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Welcome1
            // 
            this.lbl_Welcome1.AutoSize = true;
            this.lbl_Welcome1.Location = new System.Drawing.Point(113, 37);
            this.lbl_Welcome1.Name = "lbl_Welcome1";
            this.lbl_Welcome1.Size = new System.Drawing.Size(185, 13);
            this.lbl_Welcome1.TabIndex = 0;
            this.lbl_Welcome1.Text = "Welcome to the Surveying Calculator!";
            // 
            // btn_ToUnitConversions
            // 
            this.btn_ToUnitConversions.Location = new System.Drawing.Point(12, 96);
            this.btn_ToUnitConversions.Name = "btn_ToUnitConversions";
            this.btn_ToUnitConversions.Size = new System.Drawing.Size(99, 23);
            this.btn_ToUnitConversions.TabIndex = 1;
            this.btn_ToUnitConversions.Text = "Unit Conversion";
            this.btn_ToUnitConversions.UseVisualStyleBackColor = true;
            this.btn_ToUnitConversions.Click += new System.EventHandler(this.Btn_ToUnitConversions_Click);
            // 
            // btn_ToAngleConversions
            // 
            this.btn_ToAngleConversions.Location = new System.Drawing.Point(12, 134);
            this.btn_ToAngleConversions.Name = "btn_ToAngleConversions";
            this.btn_ToAngleConversions.Size = new System.Drawing.Size(99, 23);
            this.btn_ToAngleConversions.TabIndex = 2;
            this.btn_ToAngleConversions.Text = "Angle Conversion";
            this.btn_ToAngleConversions.UseVisualStyleBackColor = true;
            this.btn_ToAngleConversions.Click += new System.EventHandler(this.Btn_ToAngleConversions_Click);
            // 
            // btn_ToHorizontalCurveForm
            // 
            this.btn_ToHorizontalCurveForm.Location = new System.Drawing.Point(13, 175);
            this.btn_ToHorizontalCurveForm.Name = "btn_ToHorizontalCurveForm";
            this.btn_ToHorizontalCurveForm.Size = new System.Drawing.Size(98, 23);
            this.btn_ToHorizontalCurveForm.TabIndex = 3;
            this.btn_ToHorizontalCurveForm.Text = "Horizontal Curve";
            this.btn_ToHorizontalCurveForm.UseVisualStyleBackColor = true;
            this.btn_ToHorizontalCurveForm.Click += new System.EventHandler(this.Btn_ToHorizontalCurveForm_Click);
            // 
            // IntroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 322);
            this.Controls.Add(this.btn_ToHorizontalCurveForm);
            this.Controls.Add(this.btn_ToAngleConversions);
            this.Controls.Add(this.btn_ToUnitConversions);
            this.Controls.Add(this.lbl_Welcome1);
            this.Name = "IntroForm";
            this.Text = "Surveying Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Welcome1;
        private System.Windows.Forms.Button btn_ToUnitConversions;
        private System.Windows.Forms.Button btn_ToAngleConversions;
        private System.Windows.Forms.Button btn_ToHorizontalCurveForm;
    }
}

