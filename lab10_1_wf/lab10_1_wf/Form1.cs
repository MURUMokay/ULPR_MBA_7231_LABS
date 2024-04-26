/*1.3. Написать программу, которая вычисляет силу тока в электрической
цепи. Цепь состоит из двух последовательно соединенных сопротивлений.*/

namespace lab10_1_wf
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
        public void ComputeResult_Click(object sender, EventArgs e)
        {
            result = voltage / (RES1 + RES2);
            Result.Text = result.ToString() + " A";
        }
        public void VOLTS_TEXT(object sender, EventArgs e)
        {
            voltage = Convert.ToDouble(Volts.Text);
        }

        public void POWER1_TEXT(object sender, EventArgs e)
        {
            RES1 = Convert.ToDouble(POWER1.Text);
        }
        public void POWER2_TEXT(object sender, EventArgs e)
        {
            RES2 = Convert.ToDouble(POWER2.Text);
        }
        double voltage = 0;
        double RES1 = 0;
        double RES2 = 0;
        double result = 0;
    }
}
