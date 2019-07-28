using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Calculator_WinForm
{
    public partial class Main : Form
    {
        double number1 = 0, number2 = 0, result;
        int pointnumber;

        enum Operator { none, addition, minus, multiplication, division, power, squareroot }
        Operator mode = Operator.none;
        bool isequal = false, ispoint = false, isnegative = false, isnumberpad = false;

        public Main()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            addnumber(1);
            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            addnumber(2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            addnumber(3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            addnumber(4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            addnumber(5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            addnumber(6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            addnumber(7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            addnumber(8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            addnumber(9);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            addnumber(0);
        }

        private void btnpoint_Click(object sender, EventArgs e)
        {
            point();
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            equal();
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
            negative();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            labelout.Text = Convert.ToString(number1);
            labelmode.Text = "";
            labelbefore.Text = "";
            Fourslb.Focus();
            Fourslb.Text = "";
        }

        private void btnclean_Click(object sender, EventArgs e)
        {
            clean();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            back();
        }

        private void numberpad_CheckedChanged(object sender, EventArgs e)
        {
            if(isnumberpad == false)
            {
                isnumberpad = true;
            }
            else
            {
                isnumberpad = false;
            }
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            switch (Convert.ToInt32(e.KeyCode))
            {
                case 0x61://vbKeyNumpad1 数字键盘1 键
                    addnumber(1);
                    break;
                case 0x62://vbKeyNumpad2 数字键盘2 键
                    addnumber(2);
                    break;
                case 0x63://vbKeyNumpad3 数字键盘3 键
                    addnumber(3);
                    break;
                case 0x64://vbKeyNumpad4 数字键盘4 键
                    addnumber(4);
                    break;
                case 0x65://vbKeyNumpad5 数字键盘5 键
                    addnumber(5);
                    break;
                case 0x66://vbKeyNumpad6 数字键盘6 键
                    addnumber(6);
                    break;
                case 0x67://vbKeyNumpad7 数字键盘7 键
                    addnumber(7);
                    break;
                case 0x68://vbKeyNumpad8 数字键盘8 键
                    addnumber(8);
                    break;
                case 0x69://vbKeyNumpad9 数字键盘9 键
                    addnumber(9);
                    break;
                case 0x60://vbKeyNumpad0 数字键盘0 键
                    addnumber(0);
                    break;


                case 0x6B://vbKeyAdd 数字键盘加号 (+) 键
                    mode = Operator.addition;
                    switchmode();
                    break;
                case 0x6D://vbKeySubtract 数字键盘减号 (-) 键
                    mode = Operator.minus;
                    switchmode();
                    break;
                case 0x6A://vbKeyMultiply 数字键盘乘号 (*) 键
                    mode = Operator.multiplication;
                    switchmode();
                    break;
                case 0x6F://vbKeyDivide 数字键盘除号 (/) 键
                    mode = Operator.division;
                    switchmode();
                    break;
                case 80://vbKeyP P 键 (Power)
                    mode = Operator.power;
                    switchmode();
                    break;
                case 83://vbKeyS S 键 (Squareroot)
                    mode = Operator.squareroot;
                    switchmode();
                    break;


                case 0x6C://vbKeySeparator 数字键盘Enter 键
                    equal();
                    break;
                case 0xD://vbKeyReturn Enter 键
                    equal();
                    break;
                case 0x8://vbKeyBack Backspace 键
                    back();
                    break;
                case 78://vbKeyN N 键 (Negative)
                    negative();
                    break;
                case 67://vbKeyC C 键 (Clean)
                    clean();
                    break;
                case 0x6E://vbKeyDecimal 数字键盘小数点 (.) 键
                    point();
                    break;
                case 190:// "./>" 小数点 (.) 键
                    point();
                    break;


                case 49://vbKey1 1 键
                    if (isnumberpad == false)
                        addnumber(1);
                    break;
                case 50://vbKey2 2 键
                    if (isnumberpad == false)
                        addnumber(2);
                    break;
                case 51://vbKey3 3 键
                    if (isnumberpad == false)
                        addnumber(3);
                    break;
                case 52://vbKey4 4 键
                    if (isnumberpad == false)
                        addnumber(4);
                    break;
                case 53://vbKey5 5 键
                    if (isnumberpad == false)
                        addnumber(5);
                    break;
                case 54://vbKey6 6 键
                    if (isnumberpad == false)
                        addnumber(6);
                    break;
                case 55://vbKey7 7 键
                    if (isnumberpad == false)
                        addnumber(7);
                    break;
                case 56://vbKey8 8 键
                    if (isnumberpad == false)
                        addnumber(8);
                    break;
                case 57://vbKey9 9 键
                    if (isnumberpad == false)
                        addnumber(9);
                    break;
                case 48://vbKey0 0 键
                    if (isnumberpad == false)
                        addnumber(0);
                    break;
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

            Fourslb.Focus();
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
            if (isequal == true && number1 == 0)
            {
                number1 = result;
            }
            if (mode != Operator.squareroot)
            {
                labelbefore.Text = Convert.ToString(number1);
                labelout.Text = Convert.ToString(number2);
            }

            Fourslb.Focus();
        }

        public void clean()
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

            Fourslb.Focus();
        }

        public void back()
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

                Fourslb.Focus();
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

            Fourslb.Focus();
        }

        public void negative()
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

            Fourslb.Focus();
        }

        public void equal()
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
            mode = Operator.none;

            Fourslb.Focus();
        }

        public void point()
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

            Fourslb.Focus();
        }
    }
}
