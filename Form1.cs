using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// **************************************************
//
// Title: Surveying Calculator 
// Description: A calculator to help with surveying computations.
// Application Type: WinForms
// Author: Momrik, Anthony (A.J.)
// Dated Created: 4/7/2021
// Last Modified: 
//
// **************************************************

namespace SurveyingCalculator
{
    public partial class IntroForm : Form
    {
        public IntroForm()
        {
            InitializeComponent();
        }

        void Btn_ToUnitConversions_Click(object sender, EventArgs e)
        {
            UnitConversionForm unitConversionForm = new UnitConversionForm();
            unitConversionForm.Show();
        }

        void Btn_ToAngleConversions_Click(object sender, EventArgs e)
        {
            AngleConversionForm angleConversionForm = new AngleConversionForm();
            angleConversionForm.Show();
        }

        void Btn_ToHorizontalCurveForm_Click(object sender, EventArgs e)
        {
            HorizontalCurveForm horizontalCurveForm = new HorizontalCurveForm();
            horizontalCurveForm.Show();
        }
    }
}
