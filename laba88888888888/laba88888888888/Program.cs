Console.Write("Введите число 1: ");
Fraction fraction1 = new Fraction(Console.ReadLine());
Console.Write("Введите число 2: ");
Fraction fraction2 = new Fraction(Console.ReadLine());
Console.WriteLine($"Число 1: {fraction1.ToString()}");
Console.WriteLine($"Число 2: {fraction2.ToString()}");
Fraction dummy = new();
dummy.Sum(fraction1, fraction2);
dummy.Vch(fraction1, fraction2);
dummy.Umn(fraction1, fraction2);
dummy.Srav(fraction1, fraction2);
interface IFraction
{
    void Sum(Fraction other, Fraction dos);
    void Vch(Fraction other, Fraction dos);
    void Umn(Fraction other, Fraction dos);
    void Srav(Fraction other, Fraction dos);
}
abstract class Fract : IFraction
{
    abstract public void Sum(Fraction other, Fraction dos);
    abstract public void Vch(Fraction other, Fraction dos);
    abstract public void Umn(Fraction other, Fraction dos);
    abstract public void Srav(Fraction other, Fraction dos);
}
class Fraction : Fract
{
    long Integer;
    ushort Fractional;
    string ZCount="";
    public Fraction(): 
        base() 
    {
        Integer = 0;
        Fractional = 0;
    }
    public Fraction(string input) :
        base()
    {
        if (!input.Contains(','))
        {
            Fractional = 0;
            Integer = Convert.ToInt64(input);
        }
        else
        {
            Integer = Convert.ToInt64(input.Substring(0, input.IndexOf(',')));
            double newFractional = double.Round(Convert.ToDouble(input)-Integer, 
                input.Substring(2).Length);
            string forzero = input.Substring(2);
            for (int i = 0; i < forzero.Length; i++)
            {
                if (forzero[i] == '0')
                {
                    ZCount += '0';
                }
                else break;
            }
            Fractional = Convert.ToUInt16(input.Substring(input.IndexOf(',')+1));
        }
    }
    public override string ToString()
    {
        return $"{Integer},{ZCount}{Fractional}";
    }
    public override void Sum(Fraction other, Fraction dos)
    {
        double s1 = Convert.ToDouble(other.ToString());
        double s2 = Convert.ToDouble(dos.ToString());
        double newSum = double.Round(s1 + s2, other.ToString().Length + dos.ToString().Length);
        Console.WriteLine($"Сумма: {newSum}");
        
    }
    public override void Vch(Fraction other, Fraction dos)
    {
        double s1 = Convert.ToDouble(other.ToString());
        double s2 = Convert.ToDouble(dos.ToString());
        double newSum = double.Round(s1 - s2, other.ToString().Length + dos.ToString().Length);
        Console.WriteLine($"Разность: {newSum}");
    }
    public override void Umn(Fraction other, Fraction dos)
    {
        double s1 = Convert.ToDouble(other.ToString());
        double s2 = Convert.ToDouble(dos.ToString());
        double newSum = double.Round(s1 * s2, other.ToString().Length + dos.ToString().Length);
        Console.WriteLine($"Произведение: {newSum}");
    }
    public override void Srav(Fraction other, Fraction dos)
    {
        double s1 = Convert.ToDouble(other.ToString());
        double s2 = Convert.ToDouble(dos.ToString());
        Fraction new1 = new Fraction(s1.ToString());
        Fraction new2 = new Fraction(s2.ToString());
        if (s1 > s2)
        {
            Console.WriteLine($"Число 1 больше. {new1.ToString()} > {new2.ToString()}");
        } else
        if (s1 < s2)
        {
            Console.WriteLine($"Число 2 больше. {new1.ToString()} < {new2.ToString()}");
        }
        else
        { 
            Console.WriteLine($"Числа равны. {new1.ToString()} = {new2.ToString()}"); 
        }
    }
}