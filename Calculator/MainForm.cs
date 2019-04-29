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
        ToolTip Tip = new ToolTip();

        int inputnumber, pointnumber;
        double number1 = 0, number2 = 0, result, pi = 3.14, v1n = 0, v2n = 0, v3n = 0, ren = 0;
        enum Operator { none, plus, minus, multiplication, division, power, squareroot }
        /*
         * 计算模式
         * Calculation mode
         * 計算模式
         * Режим расчета
         */
        Operator mode = Operator.none;

        enum Selected { none, square, triangle, parallelogram, trapezium, circle, semicircle, ring, rectangle, cube, cuboid, columnar, cone, FrustumOfACone, sphere, SphericalSegment }
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
         * 计算输入框
         * calculation input window
         * 計算輸入框
         * ввода окно расчета
         */


        enum cs { none, area, volume }
        cs csmode = cs.none;
        
        bool ifequal = false, ifpoint = false, ifmore = false;

        public MainForm()
        {
            InitializeComponent();
            //Opacity = 0.75;
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
                result = 0;
                number2 = 0;
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
                result = 0;
                number2 = 0;
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
                result = 0;
                number2 = 0;
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
                result = 0;
                number2 = 0;
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
            cleanall();
        }

        private void power_Click(object sender, EventArgs e)
        {
            if (ifequal == true)
            {
                number1 = result;
                result = 0;
                number2 = 0;
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
        
        private void 我的Github空间ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/qisijie");
        }

        private void 我的Gitee空间ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://gitee.com/qisijie");
        }

        private void 我的GitLel空间ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://gitlab.com/qisijie");
        }

        private void gitHubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/qisijie/CalOfan_dark");
        }

        private void giteeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://gitee.com/qisijie/CalOfan_dark");
        }

        private void gitLabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://gitlab.com/qisijie/CalOfan_dark");
        }

        private void gotit_Click(object sender, EventArgs e)
        {
            switch (select)
            {
                case Selected.square:
                    ren = Math.Pow(v1n,2);
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
                    ren = pi * Math.Pow(Convert.ToDouble(v1n), 2);
                    re.Text = Convert.ToString(ren);
                    break;
                case Selected.semicircle:
                    ren = pi * Math.Pow(Convert.ToDouble(v1n), 2) / 2;
                    re.Text = Convert.ToString(ren);
                    break;
                case Selected.ring:
                    ren = pi * Math.Pow(Convert.ToDouble(Math.Max(v1n, v2n)), 2) - pi * Math.Pow(Convert.ToDouble(Math.Min(v1n, v2n)), 2) ; 
                    re.Text = Convert.ToString(ren);
                    break;
                case Selected.rectangle:
                    ren = v1n * v2n;
                    re.Text = Convert.ToString(ren);
                    break;
                case Selected.cube:
                    ren = Math.Pow(Convert.ToDouble(v1n), 3);
                    re.Text = Convert.ToString(ren);
                    break;
                case Selected.cuboid:
                    ren = v1n * v2n * v3n;
                    re.Text = Convert.ToString(ren);
                    break;
                case Selected.columnar:
                    ren = pi * Math.Pow(Convert.ToDouble(v1n), 2) * v2n;
                    re.Text = Convert.ToString(ren);
                    break;
                case Selected.cone:
                    ren = pi * Math.Pow(Convert.ToDouble(v1n), 2) * v2n / 3;
                    re.Text = Convert.ToString(ren);
                    break;
                case Selected.FrustumOfACone:
                    ren = pi * v3n *(Math.Pow(v1n, 2) + Math.Pow(v2n, 2) + (v1n * v2n)) / 3;
                    re.Text = Convert.ToString(ren);
                    break;
                case Selected.sphere:
                    ren = pi * Math.Pow(v1n, 3) / 3 * 4;
                    re.Text = Convert.ToString(ren);
                    break;
            }
        }
        
        private void modelll_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (modelll.Text)
            {
                case "无":
                    select = Selected.none;
                    cleanall();

                    csmode = cs.none;
                    sc();
                    break;
                case "正方形":
                    select = Selected.square;
                    cleanall();

                    csmode = cs.area;
                    sc();
                    break;
                case "三角形":
                    select = Selected.triangle;
                    cleanall();

                    csmode = cs.area;
                    sc();
                    break;
                case "平行四边形":
                    select = Selected.parallelogram;
                    cleanall();

                    csmode = cs.area;
                    sc();
                    break;
                case "梯形":
                    select = Selected.trapezium;
                    cleanall();

                    csmode = cs.area;
                    sc();
                    break;
                case "圆形":
                    select = Selected.circle;
                    cleanall();

                    csmode = cs.area;
                    sc();
                    break;
                case "半圆形":
                    select = Selected.semicircle;
                    cleanall();

                    csmode = cs.area;
                    sc();
                    break;
                case "圆环":
                    select = Selected.ring;
                    cleanall();

                    csmode = cs.area;
                    sc();
                    break;
                case "长方形":
                    select = Selected.rectangle;
                    cleanall();

                    csmode = cs.area;
                    sc();
                    break;
                case "正方体":
                    select = Selected.cube;
                    cleanall();

                    csmode = cs.volume;
                    sc();
                    break;
                case "长方体":
                    select = Selected.cuboid;
                    cleanall();

                    csmode = cs.volume;
                    sc();
                    break;
                case "圆柱体":
                    select = Selected.columnar;
                    cleanall();

                    csmode = cs.volume;
                    sc();
                    break;
                case "圆锥体":
                    select = Selected.cone;
                    cleanall();

                    csmode = cs.volume;
                    sc();
                    break;
                case "圆台":
                    select = Selected.FrustumOfACone;
                    cleanall();

                    csmode = cs.volume;
                    sc();
                    break;
                case "球体":
                    select = Selected.sphere;
                    cleanall();

                    csmode = cs.volume;
                    sc();
                    break;
            }
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

                plus.Enabled = false;
                minus.Enabled = false;
                multiplication.Enabled = false;
                division.Enabled = false;
                power.Enabled = false;
                squareroot.Enabled = false;
                equal.Enabled = false;
            }
            cleanall();
        }

        private void squareroot_Click(object sender, EventArgs e)
        {
            if (ifequal == true)
            {
                number1 = result;
                result = 0;
                number2 = 0;
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
            

            // Set up the delays for the ToolTip.
            Tip.AutoPopDelay = 5000;
            Tip.InitialDelay = 1000;
            Tip.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            Tip.ShowAlways = true;

            // Set up the ToolTip text for the Button and Checkbox.
            Tip.SetToolTip(no1, "1");
            Tip.SetToolTip(no2, "2");
            Tip.SetToolTip(no3, "3");
            Tip.SetToolTip(no4, "4");
            Tip.SetToolTip(no5, "5");
            Tip.SetToolTip(no6, "6");
            Tip.SetToolTip(no7, "7");
            Tip.SetToolTip(no8, "8");
            Tip.SetToolTip(no9, "9");
            Tip.SetToolTip(no0, "0");
            Tip.SetToolTip(plus, "加法");
            Tip.SetToolTip(minus, "减法");
            Tip.SetToolTip(multiplication, "乘法");
            Tip.SetToolTip(division, "除法");
            Tip.SetToolTip(power, "乘方(第一个数是底数)");
            Tip.SetToolTip(squareroot, "开平方");
            Tip.SetToolTip(clean, "清除");
            Tip.SetToolTip(equal, "等于");
            Tip.SetToolTip(point, "小数点");

            Tip.SetToolTip(more, "点击我来打开/关闭更多功能");
            Tip.SetToolTip(Selected1, "点击我来选中当前文本框");
            Tip.SetToolTip(Selected2, "点击我来选中当前文本框");
            Tip.SetToolTip(Selected3, "点击我来选中当前文本框");
            Tip.SetToolTip(modelll, "点击我来选择模式");

            ifmore = false;
            MaximumSize = new Size(428, 583);
            MinimumSize = new Size(428, 583);

            sc();
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
                case Operator.power: result = Math.Pow(Convert.ToDouble(Math.Truncate(number1)), Convert.ToDouble(number2)); break;
                case Operator.squareroot: result = Math.Sqrt(Convert.ToDouble(Math.Truncate(number1))); break;
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
                    if (mode == Operator.none || mode == Operator.squareroot)
                    {
                        number1 = number1 + an / Math.Pow(10, Convert.ToDouble(pointnumber));
                        labelout.Text = Convert.ToString(number1);
                    }
                    else
                    {
                        number2 = number2 + an / Math.Pow(10, Convert.ToDouble(pointnumber));
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
                            v1n = v1n * 10 + an;
                            v1.Text = Convert.ToString(v1n);
                            break;
                        case v.v2:
                            v2n = v2n * 10 + an;
                            v2.Text = Convert.ToString(v2n);
                            break;
                        case v.v3:
                            v3n = v3n * 10 + an;
                            v3.Text = Convert.ToString(v3n);
                            break;
                    }
                }
                else
                {
                    switch (which)
                    {
                        case v.v1:
                            v1n = v1n + an / Math.Pow(10, Convert.ToDouble(pointnumber));
                            v1.Text = Convert.ToString(v1n);
                            break;
                        case v.v2:
                            v2n = v2n + an / Math.Pow(10, Convert.ToDouble(pointnumber));
                            v2.Text = Convert.ToString(v2n);
                            break;
                        case v.v3:
                            v3n = v3n + an / Math.Pow(10, Convert.ToDouble(pointnumber));
                            v3.Text = Convert.ToString(v3n);
                            break;
                    }
                }
            }

        }
        
        void sc()
        {
            switch (csmode)
            {
                case cs.none:
                    cslabel.Text = "无:";
                    break;
                case cs.area:
                    cslabel.Text = "面积:";
                    break;
                case cs.volume:
                    cslabel.Text = "体积:";
                    break;
            }
        }

        void cleanall()
        {
            if (select == Selected.none)
            {
                number1 = 0;
                number2 = 0;
                result = 0;
                labelout.Text = Convert.ToString(result);
                labelbefore.Text = "";
                calmode.Text = "";

                Selected1.Enabled = false;
                Selected2.Enabled = false;
                Selected3.Enabled = false;
                v1.Text = "";
                v2.Text = "";
                v3.Text = "";
                
                csmode = cs.none;
                sc();
            }
            else
            {
                switch (select)
                {

                    case Selected.square:
                        Selected1.Enabled = true;
                        Selected2.Enabled = false;
                        Selected3.Enabled = false;
                        v1.Text = "边";
                        v2.Text = "";
                        v3.Text = "";

                        csmode = cs.area;
                        sc();
                        break;
                    case Selected.triangle:
                        Selected1.Enabled = true;
                        Selected2.Enabled = true;
                        Selected3.Enabled = false;
                        v1.Text = "底";
                        v2.Text = "高";
                        v3.Text = "";

                        csmode = cs.area;
                        sc();
                        break;
                    case Selected.parallelogram:
                        Selected1.Enabled = true;
                        Selected2.Enabled = true;
                        Selected3.Enabled = false;
                        v1.Text = "底";
                        v2.Text = "高";
                        v3.Text = "";

                        csmode = cs.area;
                        sc();
                        break;
                    case Selected.trapezium:
                        Selected1.Enabled = true;
                        Selected2.Enabled = true;
                        Selected3.Enabled = true;
                        v1.Text = "下底";
                        v2.Text = "上底";
                        v3.Text = "高";

                        csmode = cs.area;
                        sc();
                        break;
                    case Selected.circle:
                        Selected1.Enabled = true;
                        Selected2.Enabled = false;
                        Selected3.Enabled = false;
                        v1.Text = "半径";
                        v2.Text = "";
                        v3.Text = "";

                        csmode = cs.area;
                        sc();
                        break;
                    case Selected.semicircle:
                        Selected1.Enabled = true;
                        Selected2.Enabled = false;
                        Selected3.Enabled = false;
                        v1.Text = "半径";
                        v2.Text = "";
                        v3.Text = "";

                        csmode = cs.area;
                        sc();
                        break;
                    case Selected.ring:
                        Selected1.Enabled = true;
                        Selected2.Enabled = true;
                        Selected3.Enabled = false;
                        v1.Text = "半径1";
                        v2.Text = "半径2";
                        v3.Text = "";

                        csmode = cs.area;
                        sc();
                        break;
                    case Selected.rectangle:
                        Selected1.Enabled = true;
                        Selected2.Enabled = true;
                        Selected3.Enabled = false;
                        v1.Text = "长";
                        v2.Text = "宽";
                        v3.Text = "";

                        csmode = cs.area;
                        sc();
                        break;
                    case Selected.cube:
                        Selected1.Enabled = true;
                        Selected2.Enabled = false;
                        Selected3.Enabled = false;
                        v1.Text = "棱";
                        v2.Text = "";
                        v3.Text = "";

                        csmode = cs.volume;
                        sc();
                        break;
                    case Selected.columnar:
                        Selected1.Enabled = true;
                        Selected2.Enabled = true;
                        Selected3.Enabled = false;
                        v1.Text = "半径";
                        v2.Text = "高";
                        v3.Text = "";

                        csmode = cs.volume;
                        sc();
                        break;
                    case Selected.cone:
                        Selected1.Enabled = true;
                        Selected2.Enabled = true;
                        Selected3.Enabled = false;
                        v1.Text = "半径";
                        v2.Text = "高";
                        v3.Text = "";

                        csmode = cs.volume;
                        sc();
                        break;
                    case Selected.FrustumOfACone:
                        Selected1.Enabled = true;
                        Selected2.Enabled = true;
                        Selected3.Enabled = true;
                        v1.Text = "上底半径";
                        v2.Text = "下底半径";
                        v3.Text = "高";

                        csmode = cs.volume;
                        sc();
                        break;
                    case Selected.sphere:
                        Selected1.Enabled = true;
                        Selected2.Enabled = false;
                        Selected3.Enabled = false;
                        v1.Text = "半径";
                        v2.Text = "";
                        v3.Text = "";

                        csmode = cs.volume;
                        sc();
                        break;
                }
                re.Text = "";
                v1n = 0;
                v2n = 0;
                v3n = 0;
            }

            ifequal = false;
            ifpoint = false;
            mode = Operator.none;
            pointnumber = 0;
        }

    }
}
