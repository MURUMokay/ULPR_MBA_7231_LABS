/*В приводимых ниже заданиях организовать вычисление с помощью полосы
прокрутки для различных n. Причем, предусмотреть вычисление как в цикле, так и по
формуле, приведенной в правой части выражения:
1 + 3 + 5 + ⋯ + (2𝑛 − 1) = 𝑛^2
*/

using System;

namespace lab11_1_wf
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

        private void n_TextChanged(object sender, EventArgs e)
        {
            Num = Convert.ToInt64(n.Text);
            ScrollBar.Value = (int)Num;
            //RBOX OK
            RightBox.Text = Math.Pow(Num, 2).ToString();

            //LBOXF OK
            Int64 LeftSumF = ((1 + (2 * Num) - 1) * Num) / 2;
            LeftBoxF.Text = LeftSumF.ToString();

            //LBOX OK
            Int64 LeftSum = 0;
            for (int i = 1; i <= Num; i++)
            {
                LeftSum += (2 * i) - 1;
            }
            LeftBox.Text = LeftSum.ToString();

            //COMPARE
            if ((LeftBox.Text == LeftBoxF.Text) & (LeftBoxF.Text == RightBox.Text))
            { IsEqual.Text = "РАВНО"; }
            else
            { IsEqual.Text = "НЕ РАВНО"; }
        }

        private void ScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            n.Text = Convert.ToString(ScrollBar.Value);
            //RBOX OK
            RightBox.Text = Math.Pow(Num, 2).ToString();

            //LBOXF OK
            Int64 LeftSumF = ((1+(2*Num)-1)*Num)/2;
            LeftBoxF.Text = LeftSumF.ToString();

            //LBOX OK
            Int64 LeftSum = 0;
            for (int i = 1; i <= Num; i++)
            {
                LeftSum += (2 * i) - 1;
            }
            LeftBox.Text = LeftSum.ToString();

            //COMPARE
            if ((LeftBox.Text == LeftBoxF.Text) & (LeftBoxF.Text == RightBox.Text))
            { IsEqual.Text = "РАВНО"; }
            else
            { IsEqual.Text = "НЕ РАВНО"; }
        }
        Int64 Num = 1;
    }
}
