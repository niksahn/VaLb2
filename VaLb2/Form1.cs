namespace VaLb2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private double ex(double x, double e)
        {
            double rez = 0;
            double u = 1;
            double k = 1;
            while (Math.Abs(u) >= e)
            {
                rez += u;
                u = (x / k) * u;
                k++;
            }
            return rez;
        }
        private double ln(double x, double e)
        {
            double u0 = (1 - x) / (1 + x);
            double rez = u0;
            double u = u0;
            double k = 1;
            while (Math.Abs(u) >= e)
            {

                u = (1.0 / (2.0 * k + 1.0)) * Math.Pow(u0, (2.0 * k + 1.0));
                k++;
                rez += u;
            }
            return -2 * rez;
        }

        private double sin(double xPer, double e)
        {
            double x = xPer % (2.0 * Math.PI);
            double u = x;
            double rez = x;
            double k = 1;
            while (Math.Abs(u) >= e)
            {

                u = -(x * x) * u / (2.0 * k * (2.0 * k + 1.0));
                k++;
                rez += u;
            }
            return rez;
        }

        private double cos(double xPer, double e)
        {
            double x = xPer % (2.0 * Math.PI);
            double u = x;
            double rez = x;
            double k = 1;
            while (Math.Abs(u) >= e)
            {
                u = -(x * x) * u / (2.0 * k * (2.0 * k - 1.0));
                k++;
                rez += u;
            }
            return rez;
        }

        private double sqrt(double x, double e)
        {
            double uPred = x / 2.0;
            double uNext = (1.0 / 2.0) * (uPred + x / uPred);
            while (Math.Abs(uNext - uPred) >= e)
            {
                uPred = uNext;
                uNext = 1.0 / 2.0 * (uPred + x / uPred);
            }
            return uPred;
        }

        private void button7_Click(object sender, EventArgs ev)
        {
            rezult.Text = ex((double)x.Value, (double)e.Value).ToString();
        }

        private void button5_Click(object sender, EventArgs ev)
        {

            if ((double)x.Value > 0)
            {
                var rez = ln((double)x.Value, (double)e.Value);
                if (rez == -0) rez = 0;
                rezult.Text = rez.ToString();
            }
            else
            {
                MessageBox.Show("X должен быть больше 0");
            }
        }

        private void button3_Click(object sender, EventArgs ev)
        {
            rezult.Text = sin((double)x.Value, (double)e.Value).ToString();
        }

        private void button6_Click(object sender, EventArgs ev)
        {
            rezult.Text = cos((double)x.Value, (double)e.Value).ToString();
        }

        private void button4_Click(object sender, EventArgs ev)
        {
            rezult.Text = (sin((double)x.Value, (double)e.Value) / cos((double)x.Value, (double)e.Value)).ToString();
        }

        private void button2_Click(object sender, EventArgs ev)
        {
            rezult.Text = (cos((double)x.Value, (double)e.Value) / sin((double)x.Value, (double)e.Value)).ToString();
        }

        private void button1_Click(object sender, EventArgs ev)
        {
            if ((double)x.Value >= 0)
            {
                rezult.Text = sqrt((double)x.Value, (double)e.Value).ToString();
            }
            else
            {
                MessageBox.Show("X должен быть больше или равен 0");
            }
        }
    }
}