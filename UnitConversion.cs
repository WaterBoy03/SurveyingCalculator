using System;
using System.Windows.Forms;

namespace SurveyingCalculator
{
    public partial class UnitConversionForm : Form
    {
        public UnitConversionForm()
        {
            InitializeComponent();
        }

        
        void Btn_ConvertLength_Click(object sender, EventArgs e)
        {
            double lengthInMeters = 0;
            double answer = 0;

            if(!double.TryParse(txtBox_UnitLength.Text, out double length)||length<0)
            {
                MessageBox.Show("The length must be a number above 0.");
            }
            else if(cmbBox_UnitLength.Text==""||cmbBox_LengthConvertToUnit.Text=="")
            {
                MessageBox.Show("Please select the units for the conversion.");
            }

            else
            {
                lbl_LengthConvertedUnit.Text = cmbBox_LengthConvertToUnit.Text;
                lengthInMeters = LengthConvertToMeters(length, cmbBox_UnitLength.Text);
                answer = ConvertedLengthToWantedUnits(lengthInMeters, cmbBox_LengthConvertToUnit.Text);
                txtBox_LengthConverted.Text = answer.ToString();
            }
        }

        double ConvertedLengthToWantedUnits(double length, string text)
        {
            double convertedLength = 0;
            if (text == "International ft")
            {
                convertedLength = length / .3048;
            }
            else if (text == "U.S. Survey ft")
            {
                convertedLength = length / 1200 * 3927;
            }
            else if (text == "km")
            {
                convertedLength = length / 1000;
            }
            else if (text == "mile")
            {
                convertedLength = length / 1609.244;
            }
            else if (text == "rod")
            {
                convertedLength = length / 16.5 / 1200 * 3927;
            }
            else if (text == "Gunter's chain")
            {
                convertedLength = length / 66 / 1200 * 3927;
            }
            else
            {
                convertedLength = length;
            }
            return convertedLength;
        }

        /// <summary>
        /// This method converts the users input to meters.
        /// </summary>
        /// <param name="length"></param>
        /// <param name="cmbBox_UnitLength1"></param>
        /// <returns></returns>
        double LengthConvertToMeters(double length, string text)
        {
            double convertedLength = 0;
            if (text == "International ft")
            {
                convertedLength = length * .3048;
            }
            else if (text == "U.S. Survey ft")
            {
                convertedLength = length * 1200 / 3927;
            }
            else if(text=="km")
            {
                convertedLength = length * 1000;
            }
            else if (text == "mile")
            {
                convertedLength = length * 1609.244;
            }
            else if (text=="rod")
            {
                convertedLength=length * 16.5 * 1200 / 3927;
            }
            else if(text== "Gunter's chain")
            {
                convertedLength = length * 66 * 1200 / 3927;
            }
            else
            {
                convertedLength = length;
            }
            return convertedLength;
        }

        void Btn_AreaConvert_Click(object sender, EventArgs e)
        {
            double areaInSqMeters = 0;
            double answer = 0;

            if (!double.TryParse(txtBox_UnitArea.Text, out double area) || area < 0)
            {
                MessageBox.Show("The area must be a number above 0.");
            }
            else if (cmbBox_UnitArea.Text == "" || cmbBox_AreaConvertToUnit.Text == "")
            {
                MessageBox.Show("Please select the units for the conversion.");
            }

            else
            {
                lbl_AreaConvertedUnits.Text = cmbBox_AreaConvertToUnit.Text;
                areaInSqMeters = AreaConvertToSqMeters(area, cmbBox_UnitArea.Text);
                answer = ConvertedAreaToWantedUnits(areaInSqMeters, cmbBox_AreaConvertToUnit.Text);
                txtBox_AreaConverted.Text = answer.ToString();
            }
        }

        double ConvertedAreaToWantedUnits(double area, string text)
        {
            double convertedArea = 0;

            if (text == "sq ft")
            {
                convertedArea = area * 10.76;
            }
            else if (text == "sq km")
            {
                convertedArea = area / 1000000;
            }
            else if (text == "hectare")
            {
                convertedArea = area / 10000;
            }
            else if (text == "acre")
            {
                convertedArea = area / 4046.9;
            }
            else if (text == "sq mile")
            {
                convertedArea = area / 2590016;
            }
            else
            {
                convertedArea = area;
            }

            return convertedArea;
        }

        double AreaConvertToSqMeters(double area, string text)
        {
            double convertedArea = 0;

            if(text=="sq ft")
            {
                convertedArea = area / 10.76;
            }
            else if(text=="sq km")
            {
                convertedArea = area * 1000000; 
            }
            else if(text=="hectare")
            {
                convertedArea = area * 10000;
            }
            else if(text=="acre")
            {
                convertedArea = area * 4046.9;
            }
            else if(text=="sq mile")
            {
                convertedArea = area * 2590016;
            }
            else
            {
                convertedArea = area;
            }

            return convertedArea;
        }

        void Btn_VolumeConvert_Click(object sender, EventArgs e)
        {
            double volumeInCMeters = 0;
            double answer = 0;

            if (!double.TryParse(txtBox_UnitVolume.Text, out double volume) || volume < 0)
            {
                MessageBox.Show("The volume must be a number above 0.");
            }
            else if (cmbBox_UnitVolume.Text == "" || cmbBox_VolumeConvertToUnit.Text == "")
            {
                MessageBox.Show("Please select the units for the conversion.");
            }

            else
            {
                lbl_VolumeConvertedUnits.Text = cmbBox_VolumeConvertToUnit.Text;
                volumeInCMeters = VolumeConvertToSqMeters(volume, cmbBox_UnitVolume.Text);
                answer = ConvertedVolumeToWantedUnits(volumeInCMeters, cmbBox_VolumeConvertToUnit.Text);
                txtBox_VolumeConverted.Text = answer.ToString();
            }
        }

       double ConvertedVolumeToWantedUnits(double volume, string text)
        {
            double volumeConverted = 0;

            if (text == "c m")
            {
                volumeConverted = volume / 35.31;
            }
            else if (text == "c yd")
            {
                volumeConverted = volume / 27;
            }
            else if (text == "litre")
            {
                volumeConverted = volume * 28.317;
            }
            else if (text == "U.S. gal")
            {
                volumeConverted = volume * 7.481;
            }
            else if (text == "Imperial gal")
            {
                volumeConverted = volume * 6.229;
            }
            else
            {
                volumeConverted = volume;
            }


            return volumeConverted;
        }

        double VolumeConvertToSqMeters(double volume, string text)
        {
            double volumeConverted = 0;

            if(text=="c m")
            {
                volumeConverted = volume * 35.31;
            }
            else if(text=="c yd")
            {
                volumeConverted = volume * 27;
            }
            else if(text=="litre")
            {
                volumeConverted = volume / 28.317;
            }
            else if(text== "U.S. gal")
            {
                volumeConverted = volume / 7.481;
            }
            else if(text=="Imperial gal")
            {
                volumeConverted = volume / 6.229;
            }
            else
            {
                volumeConverted = volume;
            }


            return volumeConverted;
        }


        /// <summary>
        /// The button method converts the temperature between degrees.
        /// I put a limit on how low of an input a user can enter based on being below 0 K. 4/20/2021
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Btn_TempConvert_Click(object sender, EventArgs e)
        {
            double tempConverted = 0;
            double answer = 0;

            if (!double.TryParse(txtBox_UnitTemp.Text, out double temp))
            {
                MessageBox.Show("Please enter a number.");
            }
            else if (cmbBox_UnitTemp.Text == "" || cmbBox_TempConvertToUnit.Text == "")
            {
                MessageBox.Show("Please select the units for the conversion.");
            }
            else if (cmbBox_UnitTemp.Text== "°F" && temp <-459.67)
            {
                MessageBox.Show("That is below absolute 0.");
            }
            else if (cmbBox_UnitTemp.Text == "°C" && temp < -273.15)
            {
                MessageBox.Show("That is below absolute 0.");
            }
            else if (cmbBox_UnitTemp.Text == "K" && temp < 0)
            {
                MessageBox.Show("That is below absolute 0.");
            }

            else
            {
                lbl_TempConvertedUnits.Text = cmbBox_TempConvertToUnit.Text;
                tempConverted = TempConvertToCelsius(temp, cmbBox_UnitTemp.Text);
                answer = ConvertedTempToWantedUnits(tempConverted, cmbBox_TempConvertToUnit.Text);
                txtBox_TempConverted.Text = answer.ToString();
            }
        }

        double ConvertedTempToWantedUnits(double temp, string text)
        {
            double tempConverted = 0;
            if (text == "°F")
            {
                tempConverted = temp*9/5 + 32;
            }
            else if (text == "K")
            {
                tempConverted = temp + 273.15;
            }
            else
            {
                tempConverted = temp;
            }
            return tempConverted;
        }

        double TempConvertToCelsius(double temp, string text)
        {
            double tempConverted=0;
            if(text== "°F")
            {
                tempConverted = (temp - 32) * 5 / 9;
            }
            else if(text=="K")
            {
                tempConverted = temp - 273.15;
            }
            else
            {
                tempConverted = temp;
            }
            return tempConverted;
        }
    }
}
