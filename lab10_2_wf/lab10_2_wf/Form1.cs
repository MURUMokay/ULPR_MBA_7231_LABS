/*Написать программу, которая находит максимум, либо минимум для
двух задаваемых чисел*/

namespace lab10_2_wf
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
        private void ChangeMode_Click(object sender, EventArgs e)
        {
            if (CalcMode == true)
            {
                CalcMode = false;
            }
            else
            { CalcMode = true; }
            if (CalcMode == true)
            {
                CalculateMod.Text = "МАКС";
            }
            else
            { CalculateMod.Text = "МИН"; }
        }
        public bool CalcMode = true;
        private void CalcResult_Click(object sender, EventArgs e)
        {
            if (CalcMode == true)
            {
                Result.Text = Convert.ToString(Math.Max(Num1, Num2));
            } else { Result.Text = Convert.ToString(Math.Min(Num1, Num2)); }
        }

        private void Result_TextChanged(object sender, EventArgs e)
        {

        }
        private void NumeroUno_TextChanged(object sender, EventArgs e)
        {
            Num1 = Convert.ToDouble(NumeroUno.Text);
        }
        private void NumeroDos_TextChanged(object sender, EventArgs e)
        {
            Num2 = Convert.ToDouble(NumeroDos.Text);
        }
        public double Num1;
        public double Num2;
    }
}

