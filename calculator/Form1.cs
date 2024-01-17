namespace calculator
{
    public partial class Form1 : Form
    {
        string symb;
        string num;
        bool flag;
        public Form1()
        {
            InitializeComponent();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (flag)
            {
                flag = false;
                textBox.Text = "0";
            }
            if (textBox.Text == "0" && !textBox.Text.Contains(",")) textBox.Text = btn.Text;
            else textBox.Text = textBox.Text + btn.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            symb = btn.Text;
            num = textBox.Text;
            flag = true;
            ResLabel.Text = $"{num} {symb} ";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            double n1, n2, res = 0;
            n1 = Convert.ToDouble(num);
            n2 = Convert.ToDouble(textBox.Text);
            if(symb == "+") res = n1 + n2;
            if(symb == "-") res = n1 - n2;
            if(symb == "X") res = n1 * n2;
            if(symb == "%") res = n1 * n2 / 100;
            try
            {
                if(symb == "/") res = n1 / n2;
            }
            catch (DivideByZeroException)
            {
                ResLabel.Text = "ERROR";
            }
            textBox.Text = res.ToString();
            ResLabel.Text = res.ToString();
            flag = true;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
            ResLabel.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            double n1, res;
            n1 = Convert.ToDouble(textBox.Text);
            res = Math.Sqrt(n1);
            textBox.Text = res.ToString();
            ResLabel.Text = res.ToString();
            flag = true;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            double n1, res;
            n1 = Convert.ToDouble(textBox.Text);
            res = n1 * n1; ;
            textBox.Text = res.ToString();
            ResLabel.Text = res.ToString();
            flag = true;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            double n1, res;
            n1 = Convert.ToDouble(textBox.Text);
            res = n1 / 2;
            textBox.Text = res.ToString();
            ResLabel.Text = res.ToString();
            flag = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            double n1, res;
            n1 = Convert.ToDouble(textBox.Text);
            res = -n1;
            textBox.Text = res.ToString();
            ResLabel.Text = res.ToString();
            flag = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (!textBox.Text.Contains(",")) textBox.Text = textBox.Text + ",";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text.Substring(0,textBox.Text.Length - 1);
            if (textBox.Text == "") textBox.Text = "0";
        }
    }
}