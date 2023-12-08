using System.Data;

namespace Лаба_3._5
{
    public partial class Form1 : Form
    {
        bool mode_label_1 = false;
        bool mode_label_2 = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = button_equal;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)//Configure buttons配置按键
        {
            if (mode_label_1)
            {
                label1.Text = "0";
                mode_label_1 = false;
            }
            if (mode_label_2)
            {
                label1.Text = "0";
                label2.Text = "";
                mode_label_1 = false;
                mode_label_2 = false;
            }
            if (e.KeyCode == Keys.Back) button_del_Click(null, null);
            if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0) button1_Click(null, null);
            if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1) button_1_Click(null, null);
            if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2) button_2_Click(null, null);
            if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3) button_3_Click(null, null);
            if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4) button_4_Click(null, null);
            if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5) button_5_Click(null, null);
            if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6) button_6_Click(null, null);
            if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7) button_7_Click(null, null);
            if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8) button_8_Click(null, null);
            if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9) button_9_Click(null, null);
            if (e.KeyCode == Keys.C || e.KeyCode == Keys.NumLock) button_clear_Click(null, null);
            if (e.KeyCode == Keys.OemPeriod || e.KeyCode == Keys.Decimal) button_dot_Click(null, null);

            if (e.KeyCode == Keys.Add) button_plus_Click(null, null);//加号键
            if (e.KeyCode == Keys.Subtract) button_minus_Click(null, null);// 减号键
            if (e.KeyCode == Keys.Multiply) button_multiplication_Click(null, null);//乘号键
            if (e.KeyCode == Keys.Divide) button_division_Click(null, null);//除号键
            if (e.KeyCode == Keys.Enter) button_equal_Click(null, null);//回车键

            if (label2.Text.Contains("="))
            {
                label2.Text += " ";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length < 10)
            {
                if (label1.Text != "0") label1.Text += "0";
            }
        }
        private void button_del_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length > 1)
            {
                label1.Text = label1.Text.Substring(0, label1.Text.Length - 1);
            }
            else
            {
                if (label1.Text != "0")
                    label1.Text = "0";
            }
        }
        private void button_1_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length < 10)
            {
                if (label1.Text == "0") label1.Text = "1";
                else label1.Text += "1";
            }
        }
        private void button_2_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length < 10)
            {
                if (label1.Text == "0") label1.Text = "2";
                else label1.Text += "2";
            }
        }
        private void button_3_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length < 10)
            {
                if (label1.Text == "0") label1.Text = "3";
                else label1.Text += "3";
            }
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length < 10)
            {
                if (label1.Text == "0") label1.Text = "4";
                else label1.Text += "4";
            }
        }
        private void button_5_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length < 10)
            {
                if (label1.Text == "0") label1.Text = "5";
                else label1.Text += "5";
            }
        }
        private void button_6_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length < 10)
            {
                if (label1.Text == "0") label1.Text = "6";
                else label1.Text += "6";
            }
        }
        private void button_7_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length < 10)
            {
                if (label1.Text == "0") label1.Text = "7";
                else label1.Text += "7";
            }
        }
        private void button_8_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length < 10)
            {
                if (label1.Text == "0") label1.Text = "8";
                else label1.Text += "8";
            }
        }
        private void button_9_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length < 10)
            {
                if (label1.Text == "0") label1.Text = "9";
                else label1.Text += "9";
            }
        }
        private void button_dot_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length < 9)
            {
                if (!label1.Text.Contains("."))
                {
                    if (label1.Text == "0") label1.Text = "0.";
                    else label1.Text += ".";
                }
            }

        }
        private void button_clear_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            label2.Text = "";
        }
        private void button_multiplication_Click(object sender, EventArgs e)
        {
            Combining_characters(label1.Text);
            label2.Text += "*";
        }
        private void button_division_Click(object sender, EventArgs e)
        {
            Combining_characters(label1.Text);
            label2.Text += "/";
        }
        private void button_minus_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0") label1.Text = "-";
            else
            {
                Combining_characters(label1.Text);
                label2.Text += "-";
            }
        }
        private void button_plus_Click(object sender, EventArgs e)
        {
            Combining_characters(label1.Text);
            label2.Text += "+";
        }
        private void button_equal_Click(object sender, EventArgs e)
        {
            if (!label2.Text.Contains("="))
            {
                label2.Text = label2.Text + label1.Text;
                mode_label_1 = true;

                label1.Text = " ";

                double result = Evaluate(label2.Text);
                label1.Text = result.ToString();
                label2.Text += "=";
                mode_label_2 = true;
            }

        }
        private double Evaluate(string expression)//将文本内的数学式子进行运算
        {
            DataTable dt = new DataTable();
            return Convert.ToDouble(dt.Compute(expression, ""));
        }
        private void Combining_characters(string expression)//用于将label1和label2拼合起来
        {
            mode_label_1 = true;
            label2.Text = label2.Text + expression;
        }
        private void label2_Click(object sender, EventArgs e) {}
        private void label1_Click(object sender, EventArgs e) {}
    }
}