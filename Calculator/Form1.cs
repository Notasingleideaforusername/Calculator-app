using System.Text.Json.Serialization;

namespace Calculator
{


    public partial class Form1 : Form
    {

        double labelValue = 0;
        double supportValue = 0;
        char action = 'n';
        int p;
        bool digits_present = false;
        int w;
        string str;

        public Form1()
        {
            InitializeComponent();
            str = Convert.ToString(labelValue);
        }

        private Label GetLabel1()
        {
            return label1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (!int.TryParse(str, out p))
            {
                digits_present = true;
                w = str.Length - str.LastIndexOf(',');
            }
            else
            {
                digits_present = false;
            }


            if (digits_present == true)
            {
                labelValue = labelValue + (Math.Pow(0.1, w) * 1);
                str = Convert.ToString(labelValue);
                label1.Text = str;
            }
            else
            {
                labelValue *= 10;
                labelValue += 1;
                str = Convert.ToString(labelValue);
                label1.Text = str;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(str, out p))
            {
                digits_present = true;
                w = str.Length - str.LastIndexOf(',');
            }
            else
            {
                digits_present = false;
            }


            if (digits_present == true)
            {
                labelValue = labelValue + (Math.Pow(0.1, w) * 2);
                str = Convert.ToString(labelValue);
                label1.Text = str;
            }
            else
            {
                labelValue *= 10;
                labelValue += 2;
                str = Convert.ToString(labelValue);
                label1.Text = str;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(str, out p))
            {
                digits_present = true;
                w = str.Length - str.LastIndexOf(',');
            }
            else
            {
                digits_present = false;
            }


            if (digits_present == true)
            {
                labelValue = labelValue + (Math.Pow(0.1, w) * 3);
                str = Convert.ToString(labelValue);
                label1.Text = str;
            }
            else
            {
                labelValue *= 10;
                labelValue += 3;
                str = Convert.ToString(labelValue);
                label1.Text = str;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(str, out p))
            {
                digits_present = true;
                w = str.Length - str.LastIndexOf(',');
            }
            else
            {
                digits_present = false;
            }


            if (digits_present == true)
            {
                labelValue = labelValue + (Math.Pow(0.1, w) * 4);
                str = Convert.ToString(labelValue);
                label1.Text = str;
            }
            else
            {
                labelValue *= 10;
                labelValue += 4;
                str = Convert.ToString(labelValue);
                label1.Text = str;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(str, out p))
            {
                digits_present = true;
                w = str.Length - str.LastIndexOf(',');
            }
            else
            {
                digits_present = false;
            }


            if (digits_present == true)
            {
                labelValue = labelValue + (Math.Pow(0.1, w) * 5);
                str = Convert.ToString(labelValue);
                label1.Text = str;
            }
            else
            {
                labelValue *= 10;
                labelValue += 5;
                str = Convert.ToString(labelValue);
                label1.Text = str;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(str, out p))
            {
                digits_present = true;
                w = str.Length - str.LastIndexOf(',');
            }
            else
            {
                digits_present = false;
            }


            if (digits_present == true)
            {
                labelValue = labelValue + (Math.Pow(0.1, w) * 6);
                str = Convert.ToString(labelValue);
                label1.Text = str;
            }
            else
            {
                labelValue *= 10;
                labelValue += 6;
                str = Convert.ToString(labelValue);
                label1.Text = str;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(str, out p))
            {
                digits_present = true;
                w = str.Length - str.LastIndexOf(',');
            }
            else
            {
                digits_present = false;
            }


            if (digits_present == true)
            {
                labelValue = labelValue + (Math.Pow(0.1, w) * 7);
                str = Convert.ToString(labelValue);
                label1.Text = str;
            }
            else
            {
                labelValue *= 10;
                labelValue += 7;
                str = Convert.ToString(labelValue);
                label1.Text = str;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(str, out p))
            {
                digits_present = true;
                w = str.Length - str.LastIndexOf(',');
            }
            else
            {
                digits_present = false;
            }


            if (digits_present == true)
            {
                labelValue = labelValue + (Math.Pow(0.1, w) * 8);
                str = Convert.ToString(labelValue);
                label1.Text = str;
            }
            else
            {
                labelValue *= 10;
                labelValue += 8;
                str = Convert.ToString(labelValue);
                label1.Text = str;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(str, out p))
            {
                digits_present = true;
                w = str.Length - str.LastIndexOf(',');
            }
            else
            {
                digits_present = false;
            }


            if (digits_present == true)
            {
                labelValue = labelValue + (Math.Pow(0.1, w) * 9);
                str = Convert.ToString(labelValue);
                label1.Text = str;
            }
            else
            {
                labelValue *= 10;
                labelValue += 9;
                str = Convert.ToString(labelValue);
                label1.Text = str;
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(str, out p))
            {
                digits_present = true;
                w = str.Length - str.LastIndexOf(',');
            }
            else
            {
                digits_present = false;
            }


            if (digits_present == true)
            {
                labelValue = labelValue + (Math.Pow(0.1, w) * 0);
                str = Convert.ToString(labelValue);
                label1.Text = str;
            }
            else
            {
                labelValue *= 10;
                labelValue += 1;
                str = Convert.ToString(labelValue);
                label1.Text = str;
            }
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            labelValue = 0;
            supportValue = 0;
            digits_present = false;
            str = Convert.ToString(labelValue);
            label2.Text = Convert.ToString(supportValue);
            label3.Text = "";

            label1.Text = str;
        }

        private void plusbutton_Click(object sender, EventArgs e)
        {
            action = '+';
            supportValue = labelValue;
            label2.Text = Convert.ToString(supportValue);
            label3.Text = Convert.ToString(action);
            labelValue = 0;
            str = Convert.ToString(labelValue);
            label1.Text = str;
        }

        private void minusbutton_Click(object sender, EventArgs e)
        {
            action = '-';
            supportValue = labelValue;
            label2.Text = Convert.ToString(supportValue);
            label3.Text = Convert.ToString(action);
            labelValue = 0;
            str = Convert.ToString(labelValue);
            label1.Text = str;
        }

        private void multiplybutton_Click(object sender, EventArgs e)
        {
            action = 'x';
            supportValue = labelValue;
            label2.Text = Convert.ToString(supportValue);
            label3.Text = Convert.ToString(action);
            labelValue = 0;
            str = Convert.ToString(labelValue);
            label1.Text = str;
        }

        private void dividebutton_Click(object sender, EventArgs e)
        {
            action = '/';
            supportValue = labelValue;
            label2.Text = Convert.ToString(supportValue);
            label3.Text = Convert.ToString(action);
            labelValue = 0;
            str = Convert.ToString(labelValue);
            label1.Text = str;
        }

        private void equalsbutton_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            label3.Text = "";
            switch (action)
            {
                case '+':
                    labelValue += supportValue;
                    label1.Text = Convert.ToString(labelValue);
                    break;

                case '-':
                    labelValue = supportValue - labelValue;
                    label1.Text = Convert.ToString(labelValue);
                    break;

                case 'x':
                    labelValue *= supportValue;
                    label1.Text = Convert.ToString(labelValue);
                    break;

                case '/':
                    if (supportValue != 0)
                    {
                        labelValue = supportValue / labelValue;
                        label1.Text = Convert.ToString(labelValue);
                    }
                    else
                    {
                        label1.Text = "Unable to calculate (dividing by 0)";
                    }
                    break;
            }
            supportValue = 0;
        }

        private void floatbutton_Click(object sender, EventArgs e)
        {
            digits_present = true;
            str = string.Concat(Convert.ToString(labelValue), ",");
            label1.Text = str;

        }
    }
}