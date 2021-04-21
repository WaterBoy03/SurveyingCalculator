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
    public partial class HorizontalCurveForm : Form
    {

        /// <summary>
        /// The enum is used to sort with types of variables are selected.
        /// The stations are first, so they will always be the first element of the array.
        /// </summary>
        public enum VariablesOfHorizontalCurves
        {
            PI,
            PC,
            PT,
            D,
            E,
            I,
            L,
            LC,
            M,
            R,
            T
        }

        public HorizontalCurveForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The Calculate button leads to the calculations of the missing variables.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Btn_Calculate_Click(object sender, EventArgs e)
        {
            bool measurementBox;

            measurementBox = MeasurementBoxCheckForDuplicatesOrIncompatibleOptions(cmbBox_Measurement1.Text, cmbBox_Measurement2.Text);
            if(measurementBox==true)
            {
                bool blankCheck;
                blankCheck = HorizontalCurveBlankCheck();
                if(blankCheck==true)
                {
                    List<(VariablesOfHorizontalCurves variableType, double variableNumber)> givenVariables = new List<(VariablesOfHorizontalCurves, double)>();
                    string whatMeasurement1 = cmbBox_Measurement1.Text;
                    string whatMeasurement2 = cmbBox_Measurement2.Text;
                    string whatStation = cmbBox_Stations.Text;
                    double measurementNumber1 = CaseForComboBoxToNumbers(cmbBox_Measurement1.Text);
                    double measurementNumber2 = CaseForComboBoxToNumbers(cmbBox_Measurement2.Text);
                    double stationNumber = CaseForComboBoxToNumbers(cmbBox_Stations.Text);

                    //This is to prevent calculations of the measurements are under 0.
                    if (measurementNumber1 > 0 && measurementNumber2 > 0)
                    {
                        givenVariables.Add(((VariablesOfHorizontalCurves)Enum.Parse(typeof(VariablesOfHorizontalCurves), whatMeasurement1), measurementNumber1));
                        givenVariables.Add(((VariablesOfHorizontalCurves)Enum.Parse(typeof(VariablesOfHorizontalCurves), whatMeasurement2), measurementNumber2));
                        givenVariables.Add(((VariablesOfHorizontalCurves)Enum.Parse(typeof(VariablesOfHorizontalCurves), whatStation), stationNumber));
                        SortingTheListToEquations(givenVariables);
                    }

                }
            }

        }


        /// <summary>
        /// This method splits the list apart so it can be sorted into the necessary equations and then displayed.
        /// It is big because there is like 24 different options it need to choose from.
        /// </summary>
        /// <param name="givenVariables"></param>
        void SortingTheListToEquations(List<(VariablesOfHorizontalCurves variableType, double variableNumber)> givenVariables)
        {
            //The list is sorted by the Enum, which has the stationing before the other 
            //variables, meaning they will always at index 0.
            givenVariables.Sort();
            string stationType=givenVariables[0].variableType.ToString(); ;
            double stationStationing = givenVariables[0].variableNumber;
            string variableType1=givenVariables[1].variableType.ToString();
            double variableNumber1 = givenVariables[1].variableNumber;
            string variableType2 = givenVariables[2].variableType.ToString(); ;
            double variableNumber2 = givenVariables[2].variableNumber;

            double D, E, I, L, LC, M, PC, PI, PT, R, T;
            
            if (variableType1=="D"&&variableType2=="E")
            {
                D = variableNumber1;
                E = variableNumber2;

                R = DegreeOfCurveToRadius(D);
                I = 180 / Math.PI * 2 * Math.Acos(R / (R + E));
                L = RadiusAndIntersectionDegreeToLengthOfCurve(R, I);
                LC = RadiusAndIntersectionDegreeToLongChord(R, I);
                M = RadiusAndIntersectionDegreeToMiddleOrdinate(R, I);
                T = RadiusAndIntersectionDegreeToTangent(R, I);

                DisplayVariablesInTheirTextBoxes(L, txtBox_LengthOfCurve);
                DisplayVariablesInTheirTextBoxes(LC, txtBox_LongChord);
                DisplayVariablesInTheirTextBoxes(M, txtBox_MiddleOrdinate);
                DisplayVariablesInTheirTextBoxes(R, txtBox_Radius);
                DisplayVariablesInTheirTextBoxes(T, txtBox_Tangent);
                DisplayAnglesInTheirTextBoxess(I, txtBox_IntersectionDegree, txtBox_IntersectionMinute, txtBox_IntersectionSecond);
            }

            else if(variableType1 == "D" && variableType2 == "I")
            {
                D = variableNumber1;
                I = variableNumber2;

                R = DegreeOfCurveToRadius(D);
                E = RadiusAndIntersectionDegreeToExternalDistance(R, I);
                L = RadiusAndIntersectionDegreeToLengthOfCurve(R, I);
                LC = RadiusAndIntersectionDegreeToLongChord(R, I);
                M = RadiusAndIntersectionDegreeToMiddleOrdinate(R, I);
                T = RadiusAndIntersectionDegreeToTangent(R, I);
            }

            else if(variableType1=="D" && variableType2=="L")
            {
                D = variableNumber1;
                L = variableNumber2;

                R = DegreeOfCurveToRadius(D);
                I = (L / R) * (180 / Math.PI);
                E = RadiusAndIntersectionDegreeToExternalDistance(R, I);
                LC = RadiusAndIntersectionDegreeToLongChord(R, I);
                M = RadiusAndIntersectionDegreeToMiddleOrdinate(R, I);
                T = RadiusAndIntersectionDegreeToTangent(R, I);
            }

            else if(variableType1 == "D" && variableType2 == "LC")
            {
                D = variableNumber1;
                LC = variableNumber2;

                R = DegreeOfCurveToRadius(D);
                I = 2 * Math.Atan(LC / (2 * R)) * (180 / Math.PI);
                E = RadiusAndIntersectionDegreeToExternalDistance(R, I);
                L = RadiusAndIntersectionDegreeToLengthOfCurve(R, I);
                M = RadiusAndIntersectionDegreeToMiddleOrdinate(R, I);
                T = RadiusAndIntersectionDegreeToTangent(R, I);
            }

            else if(variableType1 == "D" && variableType2 == "M")
            {
                D = variableNumber1;
                M = variableNumber2;

                R = DegreeOfCurveToRadius(D);
                I = (180 / Math.PI) * 2 * Math.Acos((R - M) / R);
                E = RadiusAndIntersectionDegreeToExternalDistance(R, I);
                L = RadiusAndIntersectionDegreeToLengthOfCurve(R, I);
                LC = RadiusAndIntersectionDegreeToLongChord(R, I);
                T = RadiusAndIntersectionDegreeToTangent(R, I);
               
            }

            else if(variableType1 == "D" && variableType2 == "T")
            {
                D = variableNumber1;
                T = variableNumber2;

                R = DegreeOfCurveToRadius(D);
                I = (180 / Math.PI) * 2 * Math.Atan(T / R);
                E = RadiusAndIntersectionDegreeToExternalDistance(R, I);
                L = RadiusAndIntersectionDegreeToLengthOfCurve(R, I);
                LC = RadiusAndIntersectionDegreeToLongChord(R, I);
                M = RadiusAndIntersectionDegreeToMiddleOrdinate(R, I);
            }

            else if(variableType1 == "E" && variableType2 == "I")
            {
                E = variableNumber1;
                I = variableNumber2;

                R = E / ((1 / Math.Cos(I * Math.PI / 360)) - 1);
                D = RadiusToDegreeOfCurve(R);
                L = RadiusAndIntersectionDegreeToLengthOfCurve(R, I);
                LC = RadiusAndIntersectionDegreeToLongChord(R, I);
                M = RadiusAndIntersectionDegreeToMiddleOrdinate(R, I);
                T = RadiusAndIntersectionDegreeToTangent(R, I);
            }

            else if(variableType1 == "E" && variableType2 == "M")
            {
                E = variableNumber1;
                M = variableNumber2;

                I = (180 / Math.PI) * 2 * Math.Acos(M / E);
                R = M / (1 - (1 / Math.Cos(I * Math.PI / 360)));
                D = RadiusToDegreeOfCurve(R);
                L = RadiusAndIntersectionDegreeToLengthOfCurve(R, I);
                LC = RadiusAndIntersectionDegreeToLongChord(R, I);
                T = RadiusAndIntersectionDegreeToTangent(R, I);
            }

            else if(variableType1 == "E" && variableType2 == "R")
            {
                E = variableNumber1;
                R = variableNumber2;

                D = RadiusToDegreeOfCurve(R);
                I = (180 / Math.PI) * 2 * Math.Acos(R / (R + E));
                L = RadiusAndIntersectionDegreeToLengthOfCurve(R, I);
                LC = RadiusAndIntersectionDegreeToLongChord(R, I);
                M = RadiusAndIntersectionDegreeToMiddleOrdinate(R, I);
                T = RadiusAndIntersectionDegreeToTangent(R, I);
            }

            else if(variableType1 == "E" && variableType2 == "T")
            {
                E = variableNumber1;
                T = variableNumber2;

                I = (180 / Math.PI) * 4 * Math.Atan(E / T);
                R = T * Math.Tan(I * Math.PI / 360);
                D = RadiusToDegreeOfCurve(R);
                L = RadiusAndIntersectionDegreeToLengthOfCurve(R, I);
                LC = RadiusAndIntersectionDegreeToLongChord(R, I);
                M = RadiusAndIntersectionDegreeToMiddleOrdinate(R, I);
            }

            else if(variableType1 == "I" && variableType2 == "L")
            {
                I = variableNumber1;
                L = variableNumber2;

                R = L / (I * Math.PI / 180);
                D = RadiusToDegreeOfCurve(R);
                E = RadiusAndIntersectionDegreeToExternalDistance(R, I);
                LC = RadiusAndIntersectionDegreeToLongChord(R, I);
                M = RadiusAndIntersectionDegreeToMiddleOrdinate(R, I);
                T = RadiusAndIntersectionDegreeToTangent(R, I);
            }

            else if(variableType1 == "I" && variableType2 == "LC")
            {
                I = variableNumber1;
                LC = variableNumber2;

                R = LC / (2 * Math.Sin(I * Math.PI / 360));
                D = RadiusToDegreeOfCurve(R);
                E = RadiusAndIntersectionDegreeToExternalDistance(R, I);
                L = RadiusAndIntersectionDegreeToLengthOfCurve(R, I);
                M = RadiusAndIntersectionDegreeToMiddleOrdinate(R, I);
                T = RadiusAndIntersectionDegreeToTangent(R, I);
            }

            else if (variableType1 == "I" && variableType2 == "M")
            {
                I = variableNumber1;
                M = variableNumber2;

                R = M / (1 - Math.Cos(I * Math.PI / 360));
                D = RadiusToDegreeOfCurve(R);
                E = RadiusAndIntersectionDegreeToExternalDistance(R, I);
                L = RadiusAndIntersectionDegreeToLengthOfCurve(R, I);
                LC = RadiusAndIntersectionDegreeToLongChord(R, I);
                T = RadiusAndIntersectionDegreeToTangent(R, I);
            }

            else if(variableType1 == "I" && variableType2 == "R")
            {
                I = variableNumber1;
                R = variableNumber2;

                D = RadiusToDegreeOfCurve(R);
                E = RadiusAndIntersectionDegreeToExternalDistance(R, I);
                L = RadiusAndIntersectionDegreeToLengthOfCurve(R, I);
                LC = RadiusAndIntersectionDegreeToLongChord(R, I);
                M = RadiusAndIntersectionDegreeToMiddleOrdinate(R, I);
                T = RadiusAndIntersectionDegreeToTangent(R, I);
            }

            else if (variableType1 == "I" && variableType2 == "T")
            {
                I = variableNumber1;
                T = variableNumber2;

                R = T / Math.Tan(I * Math.PI / 360);
                D = RadiusToDegreeOfCurve(R);
                E = RadiusAndIntersectionDegreeToExternalDistance(R, I);
                L = RadiusAndIntersectionDegreeToLengthOfCurve(R, I);
                LC = RadiusAndIntersectionDegreeToLongChord(R, I);
                M = RadiusAndIntersectionDegreeToMiddleOrdinate(R, I);
            }

            else if (variableType1 == "L" && variableType2 == "R")
            {
                L = variableNumber1;
                R = variableNumber2;

                D = RadiusToDegreeOfCurve(R);
                I = 180 / Math.PI * L / R;
                E = RadiusAndIntersectionDegreeToExternalDistance(R, I);
                L = RadiusAndIntersectionDegreeToLengthOfCurve(R, I);
                LC = RadiusAndIntersectionDegreeToLongChord(R, I);
                M = RadiusAndIntersectionDegreeToMiddleOrdinate(R, I);
                T = RadiusAndIntersectionDegreeToTangent(R, I);
            }

            else if(variableType1 == "LC" && variableType2 == "R")
            {
                LC = variableNumber1;
                R = variableNumber2;

                D = RadiusToDegreeOfCurve(R);
                I = (180 / Math.PI) * 2 * Math.Atan(LC / (2 * R));
                E = RadiusAndIntersectionDegreeToExternalDistance(R, I);
                L = RadiusAndIntersectionDegreeToLengthOfCurve(R, I);
                M = RadiusAndIntersectionDegreeToMiddleOrdinate(R, I);
                T = RadiusAndIntersectionDegreeToTangent(R, I);
            }

            else if(variableType1 == "M" && variableType2 == "R")
            {
                M = variableNumber1;
                R = variableNumber2;

                D = RadiusToDegreeOfCurve(R);
                I = (180 / Math.PI) * 2 * Math.Acos((R - M) / M);
                E = RadiusAndIntersectionDegreeToExternalDistance(R, I);
                L = RadiusAndIntersectionDegreeToLengthOfCurve(R, I);
                LC = RadiusAndIntersectionDegreeToLongChord(R, I);
                M = RadiusAndIntersectionDegreeToMiddleOrdinate(R, I);
                T = RadiusAndIntersectionDegreeToTangent(R, I);
            }

            else
            {
                R = variableNumber1;
                T = variableNumber2;

                D = RadiusToDegreeOfCurve(R);
                I = (180 / Math.PI) * 2 * Math.Atan(T / R);
                E = RadiusAndIntersectionDegreeToExternalDistance(R, I);
                L = RadiusAndIntersectionDegreeToLengthOfCurve(R, I);
                LC = RadiusAndIntersectionDegreeToLongChord(R, I);
                M = RadiusAndIntersectionDegreeToMiddleOrdinate(R, I);
            }

            //This section is for determinging the stationing based on the known station.
            if(stationType == "PC")
            {
                PC = stationStationing;

                PI = PC + T;
                PT = PC + L;
            }
            else if(stationType == "PI")
            {
                PI = stationStationing;

                PC = PI - T;
                PT = PC + L;
            }
            else
            {
                PT = stationStationing;

                PC = PT - L;
                PI = PC + T;
            }

            DisplayAnglesInTheirTextBoxess(D, txtBox_DegreeOfCurveDegree, txtBox_DegreeOfCurveMinute, txtBox_DegreeOfCurveSecond);
            DisplayVariablesInTheirTextBoxes(E, txtBox_ExternalDistance);
            DisplayAnglesInTheirTextBoxess(I, txtBox_IntersectionDegree, txtBox_IntersectionMinute, txtBox_IntersectionSecond);
            DisplayVariablesInTheirTextBoxes(L, txtBox_LengthOfCurve);
            DisplayVariablesInTheirTextBoxes(LC, txtBox_LongChord);
            DisplayVariablesInTheirTextBoxes(M, txtBox_MiddleOrdinate);
            DisplayVariablesInTheirTextBoxes(PC, txtBox_PointOfCurvature);
            DisplayVariablesInTheirTextBoxes(PI, txtBox_PointOfIntersection);
            DisplayVariablesInTheirTextBoxes(PT, txtBox_PointOfTangent);
            DisplayVariablesInTheirTextBoxes(R, txtBox_Radius);
            DisplayVariablesInTheirTextBoxes(T, txtBox_Tangent);

        }


        /// <summary>
        /// The method displays the variables into a text box.
        /// </summary>
        /// <param name="number"></param>
        /// <param name="textBox"></param>
        void DisplayVariablesInTheirTextBoxes(double number,TextBox textBox)
        {
            textBox.Text = number.ToString();
        }

        /// <summary>
        /// The method takes decimal degrees and breaks it into three different text boxes for DMS.
        /// </summary>
        /// <param name="decimalDegree"></param>
        /// <param name="degreeBox"></param>
        /// <param name="minuteBox"></param>
        /// <param name="secondBox"></param>
        void DisplayAnglesInTheirTextBoxess(double decimalDegree, TextBox degreeBox, TextBox minuteBox, TextBox secondBox)
        {
            double degree = Math.Truncate(decimalDegree);
            double minute = Math.Truncate(decimalDegree * 60 - degree * 60);
            double second = ((decimalDegree - degree) * 60 - minute) * 60;

            degreeBox.Text = degree.ToString();
            minuteBox.Text = minute.ToString();
            secondBox.Text = Math.Abs(second).ToString("n4");


        }

        /// <summary>
        /// This method validates the text box entries, based on selected response of the combo boxes.
        /// It uses a case system to combo boxes's selections and numbers into a list for equations.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        double CaseForComboBoxToNumbers(string text)
        {
            
            double answer=0;
            switch(text)
            {
                case "PI":
                    {
                        if((!double.TryParse(txtBox_PointOfIntersection.Text, out answer)))
                        {
                            MessageBox.Show("Please do not enter letters.");
                        }
                        
                        break;
                    }

                case "PC":
                    {
                        if ((!double.TryParse(txtBox_PointOfCurvature.Text, out answer)))
                        {
                            MessageBox.Show("Please do not enter letters.");
                        }
                        
                        break;
                    }

                case "PT":
                    {
                        if ((!double.TryParse(txtBox_PointOfTangent.Text, out answer)))
                        {
                            MessageBox.Show("Please do not enter letters.");
                        }
                       
                        break;
                    }

                case "D":
                    {
                        double second;
                        int degree, minute;

                        if (!int.TryParse(txtBox_DegreeOfCurveDegree.Text, out degree) ||
                                !int.TryParse(txtBox_DegreeOfCurveMinute.Text, out minute) ||
                                !double.TryParse(txtBox_DegreeOfCurveSecond.Text, out second))
                        {
                            MessageBox.Show("Please do not enter letter. Degrees and minutes need to be integers");
                        }

                        else if (minute >= 60 || second >= 60)
                        {
                            MessageBox.Show("Minutes and seconds can not be larger than 59.");
                        }
                        else if(degree < 0 || minute < 0 || second < 0)
                        {
                            MessageBox.Show("Please do not enter numbers under 0.");
                        }
                        else
                        {
                            answer = degree +(Convert.ToDouble(minute) / 60) + (second / 3600);
                            if (answer == 0)
                            {
                                MessageBox.Show("Please do not have 0 decimal degrees.");
                            }
                           
                        }
                        break;
                    }

                case "E":
                    {
                        if ((!double.TryParse(txtBox_ExternalDistance.Text, out answer)) || answer <= 0)
                        {
                            MessageBox.Show("Please do not enter letters or numbers at or below 0.");
                        }
                        
                        break;
                    }

                case "I":
                    {
                        double second;
                        int degree, minute;

                        if (!int.TryParse(txtBox_IntersectionDegree.Text, out degree) ||
                                !int.TryParse(txtBox_IntersectionMinute.Text, out minute) ||
                                !double.TryParse(txtBox_IntersectionSecond.Text, out second))
                        {
                            MessageBox.Show("Please do not enter letter. Degrees and minutes need to be integers");
                        }

                        else if (minute >= 60 || second >= 60)
                        {
                            MessageBox.Show("Minutes and seconds can not be larger than 59.");
                        }
                        else if (degree < 0 || minute <0 || second < 0)
                        {
                            MessageBox.Show("Please do not enter numbers under 0.");
                        }
                        else
                        {
                            answer = degree + (Convert.ToDouble(minute) / 60) + (second / 3600);
                            if(answer==0)
                            {
                                MessageBox.Show("Please do not have 0 decimal degrees.");
                            }
                            
                        }
                        break;
                    }
                case "L":
                    {
                        if ((!double.TryParse(txtBox_LengthOfCurve.Text, out answer)) || answer <= 0)
                        {
                            MessageBox.Show("Please do not enter letters or numbers at or below 0.");
                        }
                        break;                        
                    }
                case "LC":
                    {
                        if ((!double.TryParse(txtBox_LongChord.Text, out answer)) || answer <= 0)
                        {
                            MessageBox.Show("Please do not enter letters or numbers at or below 0.");
                        }
                        
                        break;
                    }
                case "M":
                    {
                        if ((!double.TryParse(txtBox_MiddleOrdinate.Text, out answer)) || answer <= 0)
                        {
                            MessageBox.Show("Please do not enter letters or numbers at or below 0.");
                        }
                       
                        break;
                    }
                case "R":
                    {
                        if ((!double.TryParse(txtBox_Radius.Text, out answer)) || answer <= 0)
                        {
                            MessageBox.Show("Please do not enter letters or numbers at or below 0.");
                        }
                       
                        break;
                    }
                case "T":
                    {
                        if ((!double.TryParse(txtBox_Tangent.Text, out answer)) || answer <= 0)
                        {
                            MessageBox.Show("Please do not enter letters or numbers at or below 0.");
                        }
                        
                        break;
                    }
                default:
                    {
                        break;
                    }
            }

            return answer;
        }

        /// <summary>
        /// A method to check if the user entered everything they need for the calculation. This does not validate
        /// the inputs.
        /// </summary>
        /// <returns></returns>
        bool HorizontalCurveBlankCheck()
        {
            bool noBlank;
            bool stationBlank=BlankTextBoxCheck(cmbBox_Stations.Text);
            bool measurement1Blank=BlankTextBoxCheck(cmbBox_Measurement1.Text);
            bool measurement2Blank=BlankTextBoxCheck(cmbBox_Measurement2.Text);

            if (radBtn_ArcDefinition.Checked == false && radBtn_ChordDefinition.Checked == false)
            {
                MessageBox.Show("Please select either arc or chord definintion.");
                noBlank = false;
            }
            else if (radBtn_Feet.Checked == false && radBtn_Meter.Checked == false)
            {
                MessageBox.Show("Please select either feet or meter for the units.");
                noBlank = false;
            }
            else if (cmbBox_Measurement1.Text == "" || cmbBox_Measurement2.Text == "" || cmbBox_Stations.Text == "")
            {
                MessageBox.Show("Please select an option from the drop down lists.");
                noBlank = false;
            }
            else if (stationBlank == false)
            {
                MessageBox.Show($"Please fill in {cmbBox_Stations.Text}.");
                noBlank = false;
            }
            else if (measurement1Blank == false)
            {
                MessageBox.Show($"Please fill in {cmbBox_Measurement1.Text}.");
                noBlank = false;
            }
            else if (measurement2Blank==false)
            {
                MessageBox.Show($"Please fill in {cmbBox_Measurement2.Text}.");
                noBlank = false;
            }

            else
            {
                noBlank = true;
            }
            return noBlank;

        }

        /// <summary>
        /// I'm not sure if there was an easier why of checking if the text boxes that the user selected are filled.
        /// Maybe if I redid my display to only have three text boxes to imput data, but that would mean I would
        /// have to play with not displaying the measurements that are used to calculate the other variables.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        bool BlankTextBoxCheck(string text)
        {
            bool noBlank = true;
            if (text == "PI")
            {
                if (txtBox_PointOfIntersection.Text == "")
                {
                    noBlank = false;
                }
            }
            else if (text == "PC")
            {
                if (txtBox_PointOfCurvature.Text == "")
                {
                    noBlank = false;
                }
            }
            else if (text == "PT")
            {
                if (txtBox_PointOfTangent.Text == "")
                {
                    noBlank = false;
                }
            }
            else if (text == "D")
            {
                if (txtBox_DegreeOfCurveDegree.Text == "" ||
                    txtBox_DegreeOfCurveMinute.Text == "" ||
                    txtBox_DegreeOfCurveSecond.Text == "")
                {
                    noBlank = false;
                }
            }
            else if (text == "E")
            {
                if (txtBox_ExternalDistance.Text == "")
                {
                    noBlank = false;
                }
            }
            else if (text == "I")
            {
                if (txtBox_IntersectionDegree.Text == "" ||
                    txtBox_IntersectionMinute.Text == "" ||
                    txtBox_IntersectionSecond.Text == "")
                {
                    noBlank = false;
                }
            }
            else if (text == "L")
            {
                if (txtBox_LengthOfCurve.Text == "L")
                {
                    noBlank = false;
                }
            }
            else if (text == "LC")
            {
                if (txtBox_LongChord.Text == "")
                {
                    {
                        noBlank = false;
                    }
                }
            }
            else if (text == "M")
            {
                if (txtBox_MiddleOrdinate.Text == "")
                {
                    noBlank = false;
                }
            }
            else if (text == "R")
            {
                if(txtBox_Radius.Text=="")
                {
                    noBlank = false;
                }
            }
            else if (text=="T")
            {
                if(txtBox_Tangent.Text=="")
                {
                    noBlank = false;
                }
            }
            else
            {
                noBlank = false;
            }

                return noBlank;
        }

        /// <summary>
        /// A big method to prevent duplicates or measurements that are incompatible for the calculations for the curve.
        /// I tried to search for a way to turn off certain list options for the combo boxes but I was not finding any
        /// easy fixes. I decided to use a method I know would work, but not with the desired effect of removing the
        /// option for duplicates or incompatible measurements.
        /// </summary>
        /// <param name="text1"></param>
        /// <param name="text2"></param>
        /// <returns></returns>
        bool MeasurementBoxCheckForDuplicatesOrIncompatibleOptions(string text1, string text2)
        {
            bool measurementBox;
            if (text1==text2)
            {
                MessageBox.Show("No duplicate variables are allowed.");
                measurementBox = false;
            }
            else if((text1=="E"||text2=="E")&&(text1=="L"||text2=="L"))
            {
                MessageBox.Show("Those are incompatible measurements");
                measurementBox = false;
            }
            else if ((text1 == "E" || text2 == "E") && (text1 == "LC" || text2 == "LC"))
            {
                MessageBox.Show("Those are incompatible measurements");
                measurementBox = false;
            }
            else if ((text1 == "L" || text2 == "L") && (text1 == "LC" || text2 == "LC"))
            {
                MessageBox.Show("Those are incompatible measurements");
                measurementBox = false;
            }
            else if ((text1 == "L" || text2 == "L") && (text1 == "M" || text2 == "M"))
            {
                MessageBox.Show("Those are incompatible measurements");
                measurementBox = false;
            }
            else if ((text1 == "L" || text2 == "L") && (text1 == "T" || text2 == "T"))
            {
                MessageBox.Show("Those are incompatible measurements");
                measurementBox = false;
            }
            else if ((text1 == "LC" || text2 == "LC") && (text1 == "M" || text2 == "M"))
            {
                MessageBox.Show("Those are incompatible measurements");
                measurementBox = false;
            }
            else if ((text1 == "T" || text2 == "T") && (text1 == "LC" || text2 == "LC"))
            {
                MessageBox.Show("Those are incompatible measurements");
                measurementBox = false;
            }
            else if ((text1 == "M" || text2 == "M") && (text1 == "T" || text2 == "T"))
            {
                MessageBox.Show("Those are incompatible measurements");
                measurementBox = false;
            }
            else
            {
                measurementBox = true;
            }

            return measurementBox;
        }

        /// <summary>
        /// THe method resets the page so the user can start fresh.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Btn_Clear_Click(object sender, EventArgs e)
        {
            txtBox_DegreeOfCurveDegree.Text = "";
            txtBox_DegreeOfCurveMinute.Text = "";
            txtBox_DegreeOfCurveSecond.Text = "";
            txtBox_IntersectionDegree.Text = "";
            txtBox_IntersectionMinute.Text = "";
            txtBox_IntersectionSecond.Text = "";
            txtBox_LengthOfCurve.Text = "";
            txtBox_PointOfCurvature.Text = "";
            txtBox_PointOfIntersection.Text = "";
            txtBox_PointOfTangent.Text = "";
            txtBox_Radius.Text = "";
            txtBox_ExternalDistance.Text = "";
            txtBox_Tangent.Text = "";
            txtBox_LongChord.Text = "";
            txtBox_MiddleOrdinate.Text = "";

            radBtn_ArcDefinition.Checked = false;
            radBtn_ChordDefinition.Checked = false;
            radBtn_Feet.Checked = false;
            radBtn_Meter.Checked = false;

            cmbBox_Measurement1.SelectedIndex=-1;
            cmbBox_Measurement2.SelectedIndex=-1;
            cmbBox_Stations.SelectedIndex=-1;
        }

        #region Math Operations

        /// <summary>
        /// A method to convert the degree of curve to a radius.
        /// </summary>
        /// <param name="degree"></param>
        /// <returns></returns>
        double DegreeOfCurveToRadius(double degree)
        {
            double radius;

            //I changed it so the if statement was dependent on if the Chord Definition was checked.
            //The problem was that I had 500 instead of 50 for the radius calculation.
            if(radBtn_ChordDefinition.Checked==true)
            {
                double rad = degree * Math.PI / 180;
                radius = 50 / Math.Sin(rad / 2);
            }
            else
            {
                
                radius = 18000 / (Math.PI * degree);
            }

            if(radBtn_Meter.Checked==true)
            {
                radius = radius * .3048;
            }

            return radius;
        }

        /// <summary>
        /// A method to convert the radius to degree of curve.
        /// </summary>
        /// <param name="radius"></param>
        /// <returns></returns>
        double RadiusToDegreeOfCurve(double radius)
        {
            double degreeOfCurve;

            //I made the if statement dependent on if the chord definition is checked as it was not giving me the right answer.
            //fixed on 4/20/21
            if(radBtn_ChordDefinition.Checked==true)
            {
                double degreeRad;
                if (radBtn_Feet.Checked == true)
                {
                    degreeRad = 2 * Math.Asin(50 / radius);
                    degreeOfCurve = degreeRad * 180 / Math.PI;
                }

                //A conversion into feet from meters as the equation was made for feet.
                else
                {
                    degreeRad = 2 * Math.Asin(50 / (radius / .3048));
                    degreeOfCurve = degreeRad * 180 / Math.PI;
                }
                
            }
            else
            {
               if (radBtn_Feet.Checked == true)
                {
                    degreeOfCurve = 18000 / (Math.PI * radius);
                }

                //A conversion into feet from meters as the equation was made for feet.
                else
                {
                    degreeOfCurve = 18000 / (Math.PI * radius/.3048);
                } 
            }
            return degreeOfCurve;
        }

        /// <summary>
        /// A method to use the radius and Intersection Degree to get the External Distance.
        /// </summary>
        /// <param name="radius"></param>
        /// <param name="iDegree"></param>
        /// <returns></returns>
        double RadiusAndIntersectionDegreeToExternalDistance(double radius, double iDegree)
        {
            double iRad = iDegree * Math.PI / 180;
            double distance;

            distance = radius * (1/Math.Cos(iRad / 2) -1);


            return distance;
        }

        /// <summary>
        /// A method to use the radius and Intersection Degree to get the Length of Curve.
        /// </summary>
        /// <param name="radius"></param>
        /// <param name="iDegree"></param>
        /// <returns></returns>
        double RadiusAndIntersectionDegreeToLengthOfCurve(double radius, double iDegree)
        {
            double iRad = iDegree * Math.PI / 180;
            double length;

            length = radius * iRad;

            return length;
        }


        /// <summary>
        /// A method to use the radius and Intersection Degree to get the Long Chord.
        /// </summary>
        /// <param name="radius"></param>
        /// <param name="iDegree"></param>
        /// <returns></returns>
        double RadiusAndIntersectionDegreeToLongChord(double radius, double iDegree)
        {
            double iRad = iDegree * Math.PI / 180;
            double chord;

            chord = 2*radius * Math.Sin(iRad / 2);

            return chord;
        }

        /// <summary>
        /// A method to use the radius and Intersection Degree to get the Middle Ordinate.
        /// </summary>
        /// <param name="radius"></param>
        /// <param name="iDegree"></param>
        /// <returns></returns>
        double RadiusAndIntersectionDegreeToMiddleOrdinate(double radius, double iDegree)
        {
            double iRad = iDegree * Math.PI / 180;
            double distance;

            distance = radius * (1 - Math.Cos(iRad / 2));


            return distance;
        }

        /// <summary>
        /// A method to use the radius and Intersection Degree to get the Tangent.
        /// </summary>
        /// <param name="radius"></param>
        /// <param name="iDegree"></param>
        /// <returns></returns>
        double RadiusAndIntersectionDegreeToTangent(double radius, double iDegree)
        {
            double iRad = iDegree * Math.PI / 180;
            double tangent;

            tangent = radius * Math.Tan(iRad / 2);

            return tangent;
        }

        #endregion
    }
}
