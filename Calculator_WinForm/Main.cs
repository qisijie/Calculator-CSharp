using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_WinForm
{
    public partial class Main : Form
    {
        double number1 = 0, number2 = 0, result;
        int inputnumber, pointnumber;

        enum Operator { none, addition, minus, multiplication, division, power, squareroot }
        Operator mode = Operator.none;
        bool isequal = false, ispoint = false, isnegative = false;

        public Main()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            inputnumber = 1;
            addnumber(inputnumber);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            inputnumber = 2;
            addnumber(inputnumber);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            inputnumber = 3;
            addnumber(inputnumber);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            inputnumber = 4;
            addnumber(inputnumber);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            inputnumber = 5;
            addnumber(inputnumber);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            inputnumber = 6;
            addnumber(inputnumber);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            inputnumber = 7;
            addnumber(inputnumber);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            inputnumber = 8;
            addnumber(inputnumber);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            inputnumber = 9;
            addnumber(inputnumber);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            inputnumber = 0;
            addnumber(inputnumber);
        }

        private void btnpoint_Click(object sender, EventArgs e)
        {
            if (ispoint == false)
            {
                pointnumber = 1;
                if (mode == Operator.none || mode == Operator.squareroot)
                {
                    labelout.Text = Convert.ToString(number1) + ".";
                }
                else
                {
                    labelout.Text = Convert.ToString(number2) + ".";
                }
                ispoint = true;
            }
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            switch (mode)
            {
                case Operator.addition:
                    result = number1 + number2;
                    break;
                case Operator.minus:
                    result = number1 - number2;
                    break;
                case Operator.multiplication:
                    result = number1 * number2;
                    break;
                case Operator.division:
                    result = number1 / number2;
                    break;
                case Operator.power:
                    result = Math.Pow(number1, number2);
                    break;
                case Operator.squareroot:
                    result = Math.Sqrt(number1);
                    break;
            }
            number1 = 0;
            number2 = 0;
            isequal = true;
            labelbefore.Text = "";
            labelmode.Text = "";
            labelout.Text = Convert.ToString(result);
        }

        private void btnaddition_Click(object sender, EventArgs e)
        {
            mode = Operator.addition;
            switchmode();
        }

        private void btnsubtraction_Click(object sender, EventArgs e)
        {
            mode = Operator.minus;
            switchmode();
        }

        private void btnmultiplication_Click(object sender, EventArgs e)
        {
            mode = Operator.multiplication;
            switchmode();
        }

        private void btndivision_Click(object sender, EventArgs e)
        {
            mode = Operator.division;
            switchmode();
        }

        private void btnpower_Click(object sender, EventArgs e)
        {
            mode = Operator.power;
            switchmode();
        }

        private void btnsquareroot_Click(object sender, EventArgs e)
        {
            mode = Operator.squareroot;
            switchmode();
        }

        private void btnnegative_Click(object sender, EventArgs e)
        {
            if (isnegative == false)
            {
                isnegative = true;
            }
            else
            {
                isnegative = false;
            }

            if (mode == Operator.none)
            {
                number1 = number1 * -1;
                labelout.Text = Convert.ToString(number1);
            }
            else
            {
                number2 = number2 * -1;
                labelout.Text = Convert.ToString(number2);
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            labelout.Text = Convert.ToString(number1);
            labelmode.Text = "";
            labelbefore.Text = "";
        }

        private void btnclean_Click(object sender, EventArgs e)
        {
            cleanall();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            if (ispoint == false)
            {
                if (mode == Operator.none || mode == Operator.squareroot)
                {
                    if (number1 >= 10 || number1 <= -10)
                    {
                        number1 = Convert.ToDouble(Convert.ToString(number1).Substring(0, Convert.ToString(number1).Length - 1));
                    }
                    else if (number1 < 10 || number1 > -10)
                    {
                        number1 = 0;
                    }

                    labelout.Text = Convert.ToString(number1);
                }
                else
                {
                    if (number2 >= 10 || number2 <= -10)
                    {
                        number2 = Convert.ToDouble(Convert.ToString(number2).Substring(0, Convert.ToString(number2).Length - 1));
                    }
                    else if (number2 < 10 || number2 > -10)
                    {
                        number2 = 0;
                    }

                    labelout.Text = Convert.ToString(number2);
                }
            }
            else
            {
                if (mode == Operator.none || mode == Operator.squareroot)
                {

                    number1 = Convert.ToDouble(Convert.ToString(number1).Substring(0, Convert.ToString(number1).Length - 1));
                    labelout.Text = Convert.ToString(number1);
                    pointnumber = pointnumber - 1;
                    if (pointnumber == 1)
                    {
                        ispoint = false;
                        pointnumber = 0;
                    }
                }
                else
                {
                    number2 = Convert.ToDouble(Convert.ToString(number2).Substring(0, Convert.ToString(number2).Length - 1));
                    labelout.Text = Convert.ToString(number2);
                    pointnumber = pointnumber - 1;
                    if (pointnumber == 1)
                    {
                        ispoint = false;
                        pointnumber = 0;
                    }
                }
            }
        }





        public void addnumber(int an)
        {
            if (isnegative == true)
            {
                if (pointnumber == 0)
                {
                    if (mode == Operator.none || mode == Operator.squareroot)
                    {
                        number1 = number1 * 10 - an;
                        labelout.Text = Convert.ToString(number1);
                    }
                    else
                    {
                        number2 = number2 * 10 - an;
                        labelout.Text = Convert.ToString(number2);
                    }
                }
                else
                {
                    pointnumber = pointnumber + 1;
                    if (mode == Operator.none || mode == Operator.squareroot)
                    {
                        number1 = number1 - an / Math.Pow(10, pointnumber - 1);
                        labelout.Text = Convert.ToString(number1);
                    }
                    else
                    {
                        number2 = number2 - an / Math.Pow(10, pointnumber - 1);
                        labelout.Text = Convert.ToString(number2);
                    }
                }
            }
            else
            {
                if (pointnumber == 0)
                {
                    if (mode == Operator.none || mode == Operator.squareroot)
                    {
                        number1 = number1 * 10 + an;
                        labelout.Text = Convert.ToString(number1);
                    }
                    else
                    {
                        number2 = number2 * 10 + an;
                        labelout.Text = Convert.ToString(number2);
                    }
                }
                else
                {
                    pointnumber = pointnumber + 1;
                    if (mode == Operator.none || mode == Operator.squareroot)
                    {
                        number1 = number1 + an / Math.Pow(10, pointnumber - 1);
                        labelout.Text = Convert.ToString(number1);
                    }
                    else
                    {
                        number2 = number2 + an / Math.Pow(10, pointnumber - 1);
                        labelout.Text = Convert.ToString(number2);
                    }
                }
            }
        }

        public void switchmode()
        {
            switch (mode)
            {
                case Operator.addition:
                    labelmode.Text = "+";
                    break;
                case Operator.minus:
                    labelmode.Text = "-";
                    break;
                case Operator.multiplication:
                    labelmode.Text = "*";
                    break;
                case Operator.division:
                    labelmode.Text = "/";
                    break;
                case Operator.power:
                    labelmode.Text = "^";
                    break;
                case Operator.squareroot:
                    labelmode.Text = "√";
                    break;
            }

            ispoint = false;
            pointnumber = 0;
            if (isequal == true)
            {
                number1 = result;
            }
            if (mode != Operator.squareroot)
            {
                labelbefore.Text = Convert.ToString(number1);
                labelout.Text = Convert.ToString(number2);
            }
        }

        public void cleanall()
        {
            number1 = 0;
            number2 = 0;
            labelout.Text = Convert.ToString(number1);
            labelbefore.Text = "";
            labelmode.Text = "";
            isequal = false;
            mode = Operator.none;
            ispoint = false;
            pointnumber = 0;
            isnegative = false;
        }
    }
}
