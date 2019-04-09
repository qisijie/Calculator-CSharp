/*
 * Written by 暗丶dark(an丶dark   or   an_dark)
 * My blog: light.abdosoft.cn
 * My Bilibili space: https://space.bilibili.com/189781174
*/


using Microsoft.Win32;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Calculator
{
    public partial class MainForm : Form
    {

        // Create the ToolTip and associate with the Form container.
        ToolTip toolTip1 = new ToolTip();

        int inputnumber, pointnumber;
        decimal number1 = 0m, number2 = 0m, result, pi = 3.1415926m, v1n = 0m, v2n = 0m, v3n = 0m, ren = 0m;
        enum Operator { none, plus, minus, multiplication, division, power, squareroot }
        /*
         * 计算模式
         * Calculation mode
         * 計算模式
         * Режим расчета
         */
        Operator mode = Operator.none;

        enum Selected { none, square, rectangle, triangle, parallelogram, trapezium, circle, ring }
        /*
         * 面积计算模式
         * Area calculation mode
         * 面積計算模式
         * Режим расчета площади
         */

        Selected select = Selected.none;

        enum v { none, v1, v2, v3 };
        v which = v.none;
        /*
         * 面积计算输入框
         * Area calculation input window
         * 面積計算輸入框
         * Область ввода окно расчета
         */

        bool ifequal = false, ifpoint = false, ifmore = false;

        public MainForm()
        {
            InitializeComponent();
            Opacity = 0.75;
        }

        /*--数字输入键--*/
        /*--Numeric input keys--*/
        /*--Цифровые клавиши ввода--*/

        private void no1_Click(object sender, EventArgs e)
        {
            inputnumber = 1;
            cal(inputnumber);
            if (pointnumber >= 1)
            {
                pointnumber = pointnumber + 1;
                ifpoint = true;
            }
        }

        private void no2_Click(object sender, EventArgs e)
        {
            inputnumber = 2;
            cal(inputnumber);
            if (ifpoint == true)
            {
                pointnumber = pointnumber + 1;
                ifpoint = true;
            }
        }

        private void no3_Click(object sender, EventArgs e)
        {
            inputnumber = 3;
            cal(inputnumber);
            if (ifpoint == true)
            {
                pointnumber = pointnumber + 1;
                ifpoint = true;
            }
        }

        private void no4_Click(object sender, EventArgs e)
        {
            inputnumber = 4;
            cal(inputnumber);
            if (ifpoint == true)
            {
                pointnumber = pointnumber + 1;
                ifpoint = true;
            }
        }

        private void no5_Click(object sender, EventArgs e)
        {
            inputnumber = 5;
            cal(inputnumber);
            if (ifpoint == true)
            {
                pointnumber = pointnumber + 1;
                ifpoint = true;
            }
        }

        private void no6_Click(object sender, EventArgs e)
        {
            inputnumber = 6;
            cal(inputnumber);
            if (ifpoint == true)
            {
                pointnumber = pointnumber + 1;
                ifpoint = true;
            }
        }

        private void no7_Click(object sender, EventArgs e)
        {
            inputnumber = 7;
            cal(inputnumber);
            if (ifpoint == true)
            {
                pointnumber = pointnumber + 1;
                ifpoint = true;
            }
        }

        private void no8_Click(object sender, EventArgs e)
        {
            inputnumber = 8;
            cal(inputnumber);
            if (ifpoint == true)
            {
                pointnumber = pointnumber + 1;
                ifpoint = true;
            }
        }

        private void no9_Click(object sender, EventArgs e)
        {
            inputnumber = 9;
            cal(inputnumber);
            if (ifpoint == true)
            {
                pointnumber = pointnumber + 1;
                ifpoint = true;
            }
        }

        private void no0_Click(object sender, EventArgs e)
        {
            inputnumber = 0;
            cal(inputnumber);
            if (ifpoint == true)
            {
                pointnumber = pointnumber + 1;
                ifpoint = true;
            }
        }



        private void point_Click(object sender, EventArgs e)
        {
            if (ifpoint == false)
            {
                pointnumber = pointnumber + 1;
                ifpoint = true;
            }
            if (pointnumber == 1)
            {
                if(select == Selected.none)
                {
                    if (mode == Operator.none || mode == Operator.squareroot)
                    {
                        labelout.Text = Convert.ToString(number1) + ".";
                    }
                    else
                    {
                        labelout.Text = Convert.ToString(number2) + ".";
                    }
                }
                else
                {
                    switch (which)
                    {
                        case v.v1:
                            v1.Text = Convert.ToString(v1n) + ".";
                            break;
                        case v.v2:
                            v2.Text = Convert.ToString(v2n) + ".";
                            break;
                        case v.v3:
                            v3.Text = Convert.ToString(v3n) + ".";
                            break;
                    }
                }
            }
        }

        private void plus_Click(object sender, EventArgs e)
        {
            if (ifequal == true)
            {
                number1 = result;
                result = 0m;
                number2 = 0m;
            }
            mode = Operator.plus;
            labelout.Text = Convert.ToString(number2);
            labelbefore.Text = Convert.ToString(number1);
            calmode.Text = "+";
            ifpoint = false;
            pointnumber = 0;
            ifequal = false;
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (ifequal == true)
            {
                number1 = result;
                result = 0m;
                number2 = 0m;
            }
            mode = Operator.minus;
            labelout.Text = Convert.ToString(number2);
            labelbefore.Text = Convert.ToString(number1);
            calmode.Text = "-";
            ifpoint = false;
            pointnumber = 0;
            ifequal = false;
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            if (ifequal == true)
            {
                number1 = result;
                result = 0m;
                number2 = 0m;
            }
            mode = Operator.multiplication;
            labelout.Text = Convert.ToString(number2);
            labelbefore.Text = Convert.ToString(number1);
            calmode.Text = "*";
            ifpoint = false;
            pointnumber = 0;
            ifequal = false;
        }

        private void division_Click(object sender, EventArgs e)
        {
            if (ifequal == true)
            {
                number1 = result;
                result = 0m;
                number2 = 0m;
            }
            mode = Operator.division;
            labelout.Text = Convert.ToString(number2);
            labelbefore.Text = Convert.ToString(number1);
            calmode.Text = "/";
            ifpoint = false;
            pointnumber = 0;
            ifequal = false;
        }

        private void clean_Click(object sender, EventArgs e)
        {
            if (select == Selected.none)
            {
                number1 = 0m;
                number2 = 0m;
                result = 0m;
                labelout.Text = Convert.ToString(result);
                labelbefore.Text = "";
                calmode.Text = "";
            }
            else
            {
                switch (select)
                {
                    case Selected.square:
                        select = Selected.square;
                        Selected1.Enabled = true;
                        Selected2.Enabled = false;
                        Selected3.Enabled = false;
                        v1.Text = "边";
                        v2.Text = "";
                        v3.Text = "";
                        break;
                    case Selected.rectangle:
                        select = Selected.rectangle;
                        Selected1.Enabled = true;
                        Selected2.Enabled = true;
                        Selected3.Enabled = false;
                        v1.Text = "长";
                        v2.Text = "宽";
                        v3.Text = "";
                        break;
                    case Selected.triangle:
                        select = Selected.triangle;
                        Selected1.Enabled = true;
                        Selected2.Enabled = true;
                        Selected3.Enabled = false;
                        v1.Text = "底";
                        v2.Text = "高";
                        v3.Text = "";
                        break;
                    case Selected.parallelogram:
                        select = Selected.parallelogram;
                        Selected1.Enabled = true;
                        Selected2.Enabled = true;
                        Selected3.Enabled = false;
                        v1.Text = "底";
                        v2.Text = "高";
                        v3.Text = "";
                        break;
                    case Selected.trapezium:
                        select = Selected.trapezium;
                        Selected1.Enabled = true;
                        Selected2.Enabled = true;
                        Selected3.Enabled = true;
                        v1.Text = "下底";
                        v2.Text = "上底";
                        v3.Text = "高";
                        break;
                    case Selected.circle:
                        select = Selected.circle;
                        Selected1.Enabled = true;
                        Selected2.Enabled = false;
                        Selected3.Enabled = false;
                        v1.Text = "半径";
                        v2.Text = "";
                        v3.Text = "";
                        break;
                    case Selected.ring:
                        select = Selected.circle;
                        Selected1.Enabled = true;
                        Selected2.Enabled = true;
                        Selected3.Enabled = false;
                        v1.Text = "半径1";
                        v2.Text = "半径2";
                        v3.Text = "";
                        break;
                }
                re.Text = "";
                v1n = 0m;
                v2n = 0m;
                v3n = 0m;
            }

            ifequal = false;
            ifpoint = false;
            mode = Operator.none;
            pointnumber = 0;
        }

        private void power_Click(object sender, EventArgs e)
        {
            if (ifequal == true)
            {
                number1 = result;
                result = 0m;
                number2 = 0m;
            }
            mode = Operator.power;
            labelout.Text = Convert.ToString(number2);
            labelbefore.Text = Convert.ToString(number1);
            calmode.Text = "^";
            ifpoint = false;
            pointnumber = 0;
            ifequal = false;
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.Show();
        }

        private void 我的Bilibili空间ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://space.bilibili.com/189781174");
        }

        private void Selected1_Click(object sender, EventArgs e)
        {
            which = v.v1;
        }

        private void Selected2_Click(object sender, EventArgs e)
        {
            which = v.v2;
        }

        private void Selected3_Click(object sender, EventArgs e)
        {
            which = v.v3;
        }

        private void nonec_CheckedChanged(object sender, EventArgs e)
        {
            select = Selected.none;
            Selected1.Enabled = false;
            Selected2.Enabled = false;
            Selected3.Enabled = false;
            v1.Text = "";
            v2.Text = "";
            v3.Text = "";
            re.Text = "";
        }

        private void squarec_CheckedChanged(object sender, EventArgs e)
        {
            select = Selected.square;
            Selected1.Enabled = true;
            Selected2.Enabled = false;
            Selected3.Enabled = false;
            v1.Text = "边";
            v2.Text = "";
            v3.Text = "";
            re.Text = "";
        }

        private void rectanglec_CheckedChanged(object sender, EventArgs e)
        {
            select = Selected.rectangle;
            Selected1.Enabled = true;
            Selected2.Enabled = true;
            Selected3.Enabled = false;
            v1.Text = "长";
            v2.Text = "宽";
            v3.Text = "";
            re.Text = "";
        }

        private void triangle_CheckedChanged(object sender, EventArgs e)
        {
            select = Selected.triangle;
            Selected1.Enabled = true;
            Selected2.Enabled = true;
            Selected3.Enabled = false;
            v1.Text = "底";
            v2.Text = "高";
            v3.Text = "";
            re.Text = "";
        }

        private void parallelogramc_CheckedChanged(object sender, EventArgs e)
        {
            select = Selected.parallelogram;
            Selected1.Enabled = true;
            Selected2.Enabled = true;
            Selected3.Enabled = false;
            v1.Text = "底";
            v2.Text = "高";
            v3.Text = "";
            re.Text = "";
        }

        private void gotit_Click(object sender, EventArgs e)
        {
            switch (select)
            {
                case Selected.square:
                    ren = Convert.ToDecimal(Math.Pow(Convert.ToDouble(v1n), 2));
                    re.Text = Convert.ToString(ren);
                    break;
                case Selected.rectangle:
                    ren = v1n * v2n;
                    re.Text = Convert.ToString(ren);
                    break;
                case Selected.triangle:
                    ren = v1n * v2n / 2;
                    re.Text = Convert.ToString(ren);
                    break;
                case Selected.parallelogram:
                    ren = v1n * v2n;
                    re.Text = Convert.ToString(ren);
                    break;
                case Selected.trapezium:
                    ren = (v1n + v2n) * v3n / 2;
                    re.Text = Convert.ToString(ren);
                    break;
                case Selected.circle:
                    ren = pi * Convert.ToDecimal(Math.Pow(Convert.ToDouble(v1n), 2));
                    re.Text = Convert.ToString(ren);
                    break;
                case Selected.ring:
                    ren = pi * Convert.ToDecimal(Math.Pow(Convert.ToDouble(Math.Max(v1n, v2n)), 2)) - pi * Convert.ToDecimal(Math.Pow(Convert.ToDouble(Math.Min(v1n, v2n)), 2)) ; 
                    re.Text = Convert.ToString(ren);
                    break;
            }
        }

        private void trapeziumc_CheckedChanged(object sender, EventArgs e)
        {
            select = Selected.trapezium;
            Selected1.Enabled = true;
            Selected2.Enabled = true;
            Selected3.Enabled = true;
            v1.Text = "下底";
            v2.Text = "上底";
            v3.Text = "高";
            re.Text = "";
        }

        private void circle_CheckedChanged(object sender, EventArgs e)
        {
            select = Selected.circle;
            Selected1.Enabled = true;
            Selected2.Enabled = false;
            Selected3.Enabled = false;
            v1.Text = "半径";
            v2.Text = "";
            v3.Text = "";
            re.Text = "";
        }

        private void ringc_CheckedChanged(object sender, EventArgs e)
        {
            select = Selected.circle;
            Selected1.Enabled = true;
            Selected2.Enabled = true;
            Selected3.Enabled = false;
            v1.Text = "半径1";
            v2.Text = "半径2";
            v3.Text = "";
            re.Text = "";
        }

        private void 我的个人网站ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://light.abdosoft.cn");
        }

        private void more_CheckedChanged(object sender, EventArgs e)
        {
            if (ifmore == true)
            {
                ifmore = false;
                MaximumSize = new Size(428, 583);
                MinimumSize = new Size(428, 583);
                which = v.none;
                select = Selected.none;
                nonec.Checked = true;

                plus.Enabled = true;
                minus.Enabled = true;
                multiplication.Enabled = true;
                division.Enabled = true;
                power.Enabled = true;
                squareroot.Enabled = true;
                equal.Enabled = true;
            }
            else
            {
                ifmore = true;
                MaximumSize = new Size(836, 583);
                MinimumSize = new Size(836, 583);
                which = v.none;
                select = Selected.none;
                nonec.Checked = true;

                plus.Enabled = false;
                minus.Enabled = false;
                multiplication.Enabled = false;
                division.Enabled = false;
                power.Enabled = false;
                squareroot.Enabled = false;
                equal.Enabled = false;
            }
        }

        private void squareroot_Click(object sender, EventArgs e)
        {
            if (ifequal == true)
            {
                number1 = result;
                result = 0m;
                number2 = 0m;
            }
            mode = Operator.squareroot;
            labelout.Text = Convert.ToString(number1);
            calmode.Text = "√";
            ifpoint = false;
            pointnumber = 0;
            ifequal = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            if (nonec.Checked == true)
            {
                select = Selected.none;
                Selected1.Enabled = false;
                Selected2.Enabled = false;
                Selected3.Enabled = false;
                v1.Text = "";
                v2.Text = "";
                v3.Text = "";
            }

            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;

            // Set up the ToolTip text for the Button and Checkbox.
            toolTip1.SetToolTip(no1, "1");
            toolTip1.SetToolTip(no2, "2");
            toolTip1.SetToolTip(no3, "3");
            toolTip1.SetToolTip(no4, "4");
            toolTip1.SetToolTip(no5, "5");
            toolTip1.SetToolTip(no6, "6");
            toolTip1.SetToolTip(no7, "7");
            toolTip1.SetToolTip(no8, "8");
            toolTip1.SetToolTip(no9, "9");
            toolTip1.SetToolTip(no0, "0");
            toolTip1.SetToolTip(plus, "加法");
            toolTip1.SetToolTip(minus, "减法");
            toolTip1.SetToolTip(multiplication, "乘法");
            toolTip1.SetToolTip(division, "除法");
            toolTip1.SetToolTip(power, "乘方(第一个数是底数)");
            toolTip1.SetToolTip(squareroot, "开平方");
            toolTip1.SetToolTip(clean, "清除");
            toolTip1.SetToolTip(equal, "等于");
            toolTip1.SetToolTip(point, "小数点(按 Shift 来查看更多)");

            ifmore = false;
            MaximumSize = new Size(428, 583);
            MinimumSize = new Size(428, 583);
        }

        private void equal_Click(object sender, EventArgs e)
        {
            switch (mode)
            {
                case Operator.none: result = number1; break;
                case Operator.plus: result = number1 + number2; break;
                case Operator.minus: result = number1 - number2; break;
                case Operator.multiplication: result = number1 * number2; break;
                case Operator.division: result = number1 / number2; break;
                case Operator.power: result = Convert.ToDecimal(Math.Pow(Convert.ToDouble(Math.Truncate(number1)), Convert.ToDouble(number2))); break;
                case Operator.squareroot: result = Convert.ToDecimal(Math.Sqrt(Convert.ToDouble(Math.Truncate(number1)))); break;
            }
            labelout.Text = Convert.ToString(result);
            labelbefore.Text = "";
            calmode.Text = "";
            ifequal = true;
        }

        void cal(int an)
        {
            if (select == Selected.none)
            {
                if (ifpoint == false)
                {
                    if (mode == Operator.none || mode == Operator.squareroot)
                    {
                        number1 = number1 * 10 + Convert.ToDecimal(an);
                        labelout.Text = Convert.ToString(number1);
                    }
                    else
                    {
                        number2 = number2 * 10 + Convert.ToDecimal(an);
                        labelout.Text = Convert.ToString(number2);
                    }
                }
                else
                {
                    if (mode == Operator.none || mode == Operator.squareroot)
                    {
                        number1 = number1 + Convert.ToDecimal(an) / Convert.ToDecimal(Math.Pow(10, Convert.ToDouble(pointnumber)));
                        labelout.Text = Convert.ToString(number1);
                    }
                    else
                    {
                        number2 = number2 + Convert.ToDecimal(an) / Convert.ToDecimal(Math.Pow(10, Convert.ToDouble(pointnumber)));
                        labelout.Text = Convert.ToString(number2);
                    }
                }
            }
            else
            {
                if (ifpoint == false)
                {
                    switch (which)
                    {
                        case v.v1:
                            v1n = v1n * 10 + Convert.ToDecimal(an);
                            v1.Text = Convert.ToString(v1n);
                            break;
                        case v.v2:
                            v2n = v2n * 10 + Convert.ToDecimal(an);
                            v2.Text = Convert.ToString(v2n);
                            break;
                        case v.v3:
                            v3n = v3n * 10 + Convert.ToDecimal(an);
                            v3.Text = Convert.ToString(v3n);
                            break;
                    }
                }
                else
                {
                    switch (which)
                    {
                        case v.v1:
                            v1n = v1n + Convert.ToDecimal(an) / Convert.ToDecimal(Math.Pow(10, Convert.ToDouble(pointnumber)));
                            v1.Text = Convert.ToString(v1n);
                            break;
                        case v.v2:
                            v2n = v2n + Convert.ToDecimal(an) / Convert.ToDecimal(Math.Pow(10, Convert.ToDouble(pointnumber)));
                            v2.Text = Convert.ToString(v2n);
                            break;
                        case v.v3:
                            v3n = v3n + Convert.ToDecimal(an) / Convert.ToDecimal(Math.Pow(10, Convert.ToDouble(pointnumber)));
                            v3.Text = Convert.ToString(v3n);
                            break;
                    }
                }
            }

        }

    }
}
