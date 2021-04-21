using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SurveyingCalculator
{
    public partial class AngleConversionForm : Form
    {
        public AngleConversionForm()
        {
            InitializeComponent();
        }

        void Btn_AngleConversionConvert_Click(object sender, EventArgs e)
        {
            double radian;

            if (cmbBox_AngleUnits.Text == "" || cmbBox_ConvertAngleUnitsTo.Text == "")
            {
                MessageBox.Show("Please select the units for the conversion.");
            }
            else
            {               

                if (cmbBox_AngleUnits.Text == "degree minute second")
                {
                   
                    double decimalDegree;
                    

                    //A method to change empty Degree, Minute, and/or Second text boxes to zero.
                    FillsInDMSBlanksWithZeroes(txtBox_ConvertedAngleDegree, txtBox_AngleConversionMinute, txtBox_AngleConversionSecond);

                    //validates for numbers
                    decimalDegree = ValitationOfTheDMSToDecDeg(txtBox_AngleConversionDegree, txtBox_AngleConversionMinute, txtBox_AngleConversionSecond,"");
                    radian = decimalDegree * Math.PI / 180;

                    //added on 4/20/2021 to reduce angles to between 0 and 2*PI.
                    double over2PICheck = Math.Floor(radian / (2 * Math.PI));
                    radian = radian - over2PICheck * 2 * Math.PI;

                    ConvertedAngleAnswerAndVisibility(radian, cmbBox_ConvertAngleUnitsTo.Text);


                }

                //This section is for the non-DMS angles
                else
                {
                    //Validates for numbers
                    if (!double.TryParse(txtBox_AngleConversion.Text, out double angle))
                    {
                        MessageBox.Show("Please do not enter letters.");
                    }
                    else
                    {
                        radian = ConversionOfAngleToRadians(angle, cmbBox_AngleUnits.Text);
                        ConvertedAngleAnswerAndVisibility(radian, cmbBox_ConvertAngleUnitsTo.Text);
                    }
                }
            }
        }

        /// <summary>
        /// This method is to convert the non-DMS angles into radians.
        /// </summary>
        /// <param name="angle"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        double ConversionOfAngleToRadians(double angle, string text)
        {
            double radian;

            if (text == "decimal degree")
            {
                radian = angle * Math.PI / 180;
            }
            else if (text == "gon")
            {
                radian = angle * Math.PI / 200;
            }
            else
            {
                radian = angle;
            }

            //added on 4/20/2021 to reduce angles to between 0 and 2*PI.
            double over2PICheck = Math.Floor(radian / (2*Math.PI));
            radian = radian - over2PICheck * 2 * Math.PI;

            return radian;
        }


        /// <summary>
        /// When "degree minute second" is selected, it makes a set of text boxes and labels visible
        /// while making the common text box invisible.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CmbBox_AngleUnits_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBox_AngleUnits.Text == "degree minute second")
            {
                lbl_AngleConversionDegree.Visible = true;
                lbl_AngleConversionMinute.Visible = true;
                lbl_AngleConversionSecond.Visible = true;
                txtBox_AngleConversionDegree.Visible = true;
                txtBox_AngleConversionMinute.Visible = true;
                txtBox_AngleConversionSecond.Visible = true;
                txtBox_AngleConversion.Visible = false;

            }
            else
            {
                lbl_AngleConversionDegree.Visible = false;
                lbl_AngleConversionMinute.Visible = false;
                lbl_AngleConversionSecond.Visible = false;
                txtBox_AngleConversionDegree.Visible = false;
                txtBox_AngleConversionMinute.Visible = false;
                txtBox_AngleConversionSecond.Visible = false;
                txtBox_AngleConversion.Visible = true;
            }
        }


        /// <summary>
        /// This method is to calculate the wanted conversion while making certain text boxes visible.
        /// </summary>
        /// <param name="radian"></param>
        /// <param name="text"></param>
        void ConvertedAngleAnswerAndVisibility(double radian, string text)
        {
            double convertedAngle;
            if (text == "degree minute second")
            {
                lbl_ConvertedAngleDegree.Visible = true;
                lbl_ConvertedAngleMinute.Visible = true;
                lbl_ConvertedAngleSecond.Visible = true;
                txtBox_ConvertedAngleDegree.Visible = true;
                txtBox_ConvertedAngleMinute.Visible = true;
                txtBox_ConvertedAngleSecond.Visible = true;
                txtBox_ConvertedAngle.Visible = false;
                lbl_ConvertedAngleUnits.Visible = false;

                convertedAngle = radian * 180 / Math.PI;
                DecimalDegreeToDMSAndTextBoxes(convertedAngle, txtBox_ConvertedAngleDegree, txtBox_ConvertedAngleMinute, txtBox_ConvertedAngleSecond);
                
            }
            else
            {
                lbl_ConvertedAngleDegree.Visible = false;
                lbl_ConvertedAngleMinute.Visible = false;
                lbl_ConvertedAngleSecond.Visible = false;
                txtBox_ConvertedAngleDegree.Visible = false;
                txtBox_ConvertedAngleMinute.Visible = false;
                txtBox_ConvertedAngleSecond.Visible = false;
                txtBox_ConvertedAngle.Visible = true;
                lbl_ConvertedAngleUnits.Visible = true;
                lbl_ConvertedAngleUnits.Text = text;

                if (text == "decimal degree")
                {
                    convertedAngle = radian * 180 / Math.PI;
                }
                else if (text == "gon")
                {
                    convertedAngle = radian * 200 / Math.PI;
                }
                else
                {
                    convertedAngle = radian;
                }
                txtBox_ConvertedAngle.Text = convertedAngle.ToString();

            }
        }

        /// <summary>
        /// The method converts decimal degree into DMS format.
        /// It also display the DMS in their text box.
        /// </summary>
        /// <param name="decimalDegree"></param>
        /// <param name="txtBox_Degree"></param>
        /// <param name="txtBox_Minute"></param>
        /// <param name="txtBox_Second"></param>
        void DecimalDegreeToDMSAndTextBoxes(double decimalDegree,
            TextBox txtBox_Degree, TextBox txtBox_Minute, TextBox txtBox_Second)
        {
            double degree = Math.Truncate(decimalDegree);
            double minute = Math.Truncate(decimalDegree * 60 - degree * 60);
            double second = ((decimalDegree - degree) * 60 - minute) * 60;
            if (degree == 0 && minute != 0)
            {
                txtBox_Degree.Text = degree.ToString();
                txtBox_Minute.Text = minute.ToString();
                txtBox_Second.Text = Math.Abs(second).ToString("n4");
            }
            else if (degree == 0 && minute == 0)
            {
                txtBox_Degree.Text = degree.ToString();
                txtBox_Minute.Text = minute.ToString();
                txtBox_Second.Text = second.ToString("n4");
            }
            else
            {
                txtBox_Degree.Text = degree.ToString();
                txtBox_Minute.Text = Math.Abs(minute).ToString();
                txtBox_Second.Text = Math.Abs(second).ToString("n4");
            }
        }

        /// <summary>
        /// The method display different text boxes and combo box, based on if the angle is in
        /// decimal degrees or DMS or an azimuth or bearing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CmbBox_AzBearUnits_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBox_AzBearUnits.Text == "bearing degree minute second")
            {
                lbl_AzBearDegree.Visible = true;
                lbl_AzBearMinute.Visible = true;
                lbl_AzBearSecond.Visible = true;
                cmbBox_BearingDirection.Visible = true;
                txtBox_AzBearDegree.Visible = true;
                txtBox_AzBearMinute.Visible = true;
                txtBox_AzBearSecond.Visible = true;
                txtBox_AzBearDec.Visible = false;
            }
            else if (cmbBox_AzBearUnits.Text == "bearing decimal degree")
            {
                lbl_AzBearDegree.Visible = false;
                lbl_AzBearMinute.Visible = false;
                lbl_AzBearSecond.Visible = false;
                cmbBox_BearingDirection.Visible = true;
                txtBox_AzBearDegree.Visible = false;
                txtBox_AzBearMinute.Visible = false;
                txtBox_AzBearSecond.Visible = false;
                txtBox_AzBearDec.Visible = true;
            }
            else if (cmbBox_AzBearUnits.Text == "azimuth degree minute second")
            {
                lbl_AzBearDegree.Visible = true;
                lbl_AzBearMinute.Visible = true;
                lbl_AzBearSecond.Visible = true;
                cmbBox_BearingDirection.Visible = false;
                txtBox_AzBearDegree.Visible = true;
                txtBox_AzBearMinute.Visible = true;
                txtBox_AzBearSecond.Visible = true;
                txtBox_AzBearDec.Visible = false;
            }
            else
            {
                lbl_AzBearDegree.Visible = false;
                lbl_AzBearMinute.Visible = false;
                lbl_AzBearSecond.Visible = false;
                cmbBox_BearingDirection.Visible = false;
                txtBox_AzBearDegree.Visible = false;
                txtBox_AzBearMinute.Visible = false;
                txtBox_AzBearSecond.Visible = false;
                txtBox_AzBearDec.Visible = true;
            }
        }

        /// <summary>
        /// The button that leads to the conversions of azimuths and bearings.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Btn_AzBearConvert_Click(object sender, EventArgs e)
        {
            if (cmbBox_AzBearUnits.Text == "" || cmbBox_AzBearConvertTo.Text == "")
            {
                MessageBox.Show("Please select the units for the conversion.");
            }
            else if ((cmbBox_AzBearUnits.Text == "bearing decimal degree" ||
                cmbBox_AzBearUnits.Text == "bearing decimal degree") &&
                cmbBox_BearingDirection.Text == "")
            {
                MessageBox.Show("Please select a direction for the bearing.");
            }
            else
            {

                double decimalDegree;
                double azimuth;
                
                if (cmbBox_AzBearUnits.Text == "bearing degree minute second" || cmbBox_AzBearUnits.Text == "azimuth degree minute second")
                {


                    //Fills in the blank text boxes of the degree, minute, and/or second with zeroes.
                    FillsInDMSBlanksWithZeroes(txtBox_AzBearDegree, txtBox_AzBearMinute, txtBox_AzBearSecond);


                    //validates for numbers
                    decimalDegree = ValitationOfTheDMSToDecDeg(txtBox_AzBearDegree, txtBox_AzBearMinute, txtBox_AzBearSecond, cmbBox_AzBearUnits.Text);
                                    
                }
                else
                {
                    decimalDegree = ValidationOfAnyDoubleNumber(txtBox_AzBearDec,cmbBox_AzBearUnits.Text);
                }
                azimuth = TurningDecimalDegreesIntoAzimuths(decimalDegree);
                DisplayingAzimuthOrBearing(azimuth, cmbBox_AzBearConvertTo.Text);

            }

            
        }

        /// <summary>
        /// A method for displaying Azimuths and Bearings.
        /// </summary>
        /// <param name="azimuth"></param>
        /// <param name="text"></param>
        void DisplayingAzimuthOrBearing(double azimuth, string text)
        {
            (string direction, double decDegree) bearing;
            bearing.direction = "";
            bearing.decDegree = 0;

            if (text== "azimuth degree minute second")
            {
                lbl_ConvertedAzBearDegree.Visible = true;
                lbl_ConvertedAzBearMinute.Visible = true;
                lbl_ConvertedAzBearSecond.Visible = true;
                lbl_ConvertedBearing.Visible = false;
                txtBox_ConvertedAzBearDec.Visible = false;
                txtBox_ConvertedAzBearDegree.Visible = true;
                txtBox_ConvertedAzBearMinute.Visible = true;
                txtBox_ConvertedAzBearSecond.Visible = true;
                DecimalDegreeToDMSAndTextBoxes(azimuth, txtBox_ConvertedAzBearDegree, txtBox_ConvertedAzBearMinute, txtBox_ConvertedAzBearSecond);
            }
            else if(text== "bearing degree minute second")
            {
                lbl_ConvertedAzBearDegree.Visible = true;
                lbl_ConvertedAzBearMinute.Visible = true;
                lbl_ConvertedAzBearSecond.Visible = true;
                lbl_ConvertedBearing.Visible = true;
                txtBox_ConvertedAzBearDec.Visible = false;
                txtBox_ConvertedAzBearDegree.Visible = true;
                txtBox_ConvertedAzBearMinute.Visible = true;
                txtBox_ConvertedAzBearSecond.Visible = true;

                bearing = CalculationsForBearings(azimuth);
                DecimalDegreeToDMSAndTextBoxes(bearing.decDegree, txtBox_ConvertedAzBearDegree, txtBox_ConvertedAzBearMinute, txtBox_ConvertedAzBearSecond);
                lbl_ConvertedBearing.Text = bearing.direction;
            }

            else if (text=="bearing decimal degree")
            {
                lbl_ConvertedAzBearDegree.Visible = false;
                lbl_ConvertedAzBearMinute.Visible = false;
                lbl_ConvertedAzBearSecond.Visible = false;
                lbl_ConvertedBearing.Visible = true;
                txtBox_ConvertedAzBearDec.Visible = true;
                txtBox_ConvertedAzBearDegree.Visible = false;
                txtBox_ConvertedAzBearMinute.Visible = false;
                txtBox_ConvertedAzBearSecond.Visible = false;

                bearing = CalculationsForBearings(azimuth);
                txtBox_ConvertedAzBearDec.Text = bearing.decDegree.ToString();

                lbl_ConvertedBearing.Text = bearing.direction;
            }
            else
            {
                lbl_ConvertedAzBearDegree.Visible = false;
                lbl_ConvertedAzBearMinute.Visible = false;
                lbl_ConvertedAzBearSecond.Visible = false;
                lbl_ConvertedBearing.Visible = false;
                txtBox_ConvertedAzBearDec.Visible = true;
                txtBox_ConvertedAzBearDegree.Visible = false;
                txtBox_ConvertedAzBearMinute.Visible = false;
                txtBox_ConvertedAzBearSecond.Visible = false;

                txtBox_ConvertedAzBearDec.Text = azimuth.ToString();
            }
        }

        /// <summary>
        /// The method is to compute the bearing's direction and angle.
        /// </summary>
        /// <param name="azimuth"></param>
        /// <returns></returns>
        static (string direction, double degree) CalculationsForBearings(double azimuth)
        {
            (string direction, double decDegree) bearing;
            bearing.direction = "";
            bearing.decDegree = 0;

            if(azimuth > 90 && azimuth < 180)
            {
                bearing.decDegree = 180 - azimuth;
                bearing.direction = "SE";
            }
            else if(azimuth >= 180 && azimuth < 270)
            {
                bearing.decDegree = azimuth - 180;
                bearing.direction = "SW";
            }
            else if(azimuth >=270 && azimuth < 360)
            {
                bearing.decDegree = 360 - azimuth;
                bearing.direction = "NW";
            }
            else
            {
                bearing.decDegree = azimuth;
                bearing.direction = "NE";
            }

            return bearing;
        }

        /// <summary>
        /// The method converts the degrees into azimuths.
        /// </summary>
        /// <param name="decimalDegree"></param>
        /// <returns></returns>
        double TurningDecimalDegreesIntoAzimuths(double decimalDegree)
        {
            double azimuthDecDegree;
            if(cmbBox_AzBearUnits.Text=="bearing decimal degree"||
                cmbBox_AzBearUnits.Text== "bearing degree minute second")
            {
                if(cmbBox_BearingDirection.Text=="NW")
                {
                    azimuthDecDegree = 360 - decimalDegree;
                }
                else if(cmbBox_BearingDirection.Text=="SW")
                {
                    azimuthDecDegree = decimalDegree + 180;
                }
                else if (cmbBox_BearingDirection.Text=="SE")
                {
                    azimuthDecDegree = 180 - decimalDegree;
                }
                else
                {
                    azimuthDecDegree = decimalDegree;
                }

            }
            else
            {
                //I used Math.Floor because I need the lower rounding to be multiplied by 360.
                    double over360Check = Math.Floor(decimalDegree / 360);
                    azimuthDecDegree = decimalDegree - over360Check * 360;
                
            }
            return azimuthDecDegree;
        }

        /// <summary>
        /// A method that validate user entered Degrees, Minutes, and Seconds.
        /// </summary>
        /// <param name="txtBox_Degree"></param>
        /// <param name="txtBox_Minute"></param>
        /// <param name="txtBox_Second"></param>
        /// <returns></returns>
        double ValitationOfTheDMSToDecDeg(TextBox txtBox_Degree, TextBox txtBox_Minute, TextBox txtBox_Second, string bearing)
        {
            double decimalDegree = 0;
            double second;
            int degree, minute;

            if (!int.TryParse(txtBox_Degree.Text, out degree) ||
                    !int.TryParse(txtBox_Minute.Text, out minute) ||
                    !double.TryParse(txtBox_Second.Text, out second))
            {
                MessageBox.Show("Please do not enter letter. Degrees and minutes need to be integers");
            }

            else if (minute >= 60 || second >= 60)
            {
                MessageBox.Show("Minutes and seconds can not be larger than 59.");
            }

            //validates that the minutes and seconds are not negative
            else if (degree != 0)
            {
                if (minute < 0 || second < 0)
                {
                    MessageBox.Show("Only the degree section needs the negative sign.");
                }
                else
                {
                    decimalDegree = Math.Sign(degree) * (Math.Abs(degree) + (Convert.ToDouble(minute) / 60) + (second / 3600));

                }

            }
            else if (degree == 0 && minute != 0)
            {
                if (second < 0)
                {
                    MessageBox.Show("Only the minute section needs the negative sign when the degree is 0.");
                }
                else
                {
                    decimalDegree = Math.Sign(minute) * (Convert.ToDouble(Math.Abs(minute)) / 60 + second / 3600);

                }
            }

            else
            {
                decimalDegree = second / 3600;

            }
            if(bearing== "bearing degree minute second" && (decimalDegree<0||decimalDegree>90))
            {
                MessageBox.Show("Bearings can only be between 0° and 90°.");
            }

            return decimalDegree;

        }

        /// <summary>
        /// A method that validates doubles.
        /// </summary>
        /// <param name="txtBox1"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        double ValidationOfAnyDoubleNumber(TextBox txtBox1,string text)
        {
            double decimalDegree = 0;
            if (!double.TryParse(txtBox1.Text, out double angle))
            {
                MessageBox.Show("Please do not enter letters.");

            }
            else if (text== "bearing decimal degree" && (angle<0||angle>90))
            {
                MessageBox.Show("Bearings can only be between 0° and 90°.");
            }
            else
            {
                decimalDegree = angle;
            }
            return decimalDegree;
        }

        /// <summary>
        /// A method that fills in the blank DMS boxes with 0.
        /// </summary>
        /// <param name="txtBox1"></param>
        /// <param name="txtBox2"></param>
        /// <param name="txtBox3"></param>
        void FillsInDMSBlanksWithZeroes(TextBox txtBox1, TextBox txtBox2, TextBox txtBox3)
        {
            while (txtBox1.Text == "" ||
                        txtBox2.Text == "" ||
                        txtBox3.Text == "")
            {
                if (txtBox1.Text == "")
                {
                    txtBox1.Text = "0";
                }
                else if (txtBox2.Text == "")
                {
                    txtBox2.Text = "0";
                }
                else
                {
                    txtBox3.Text = "0";
                }
            }
        }
    }
}
