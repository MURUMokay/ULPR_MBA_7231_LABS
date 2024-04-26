/*Создать класс EngMoney для работы с устаревшей денежной системой Великобритании. 
 * В ней использовались фунты, шиллинги и пенсы. При этом: 1 фунт = 20
шиллингов, 1 шиллинг = 12 пенсов. Денежные суммы будут задаваться в фунтах, 
шиллингах и пенсах и результат выдаваться также в этих величинах. 
Должны быть реализованы: сложение и вычитание, умножение и деление, сравнение сумм.
Все данные для заполнения полей необходимо вводить с клавиатуры. 
Обязательно использование абстрактных классов, интерфейсов, конструкторов и деструкторов.*/

Console.Write($"Введите сумму #1: ");
int m1 = Convert.ToInt32(Console.ReadLine());
IMoney moneyBag1 = new EngMoney(funt: 0, shilling: 0, pens: m1);
Console.Write($"Введите сумму #2: ");
int m2 = Convert.ToInt32(Console.ReadLine());
IMoney moneyBag2 = new EngMoney(funt: 0, shilling: 0, pens: m2);
Console.Write("Введите число для операций: ");
int k = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\nСложение.");
moneyBag1.plus(moneyBag2);
Console.WriteLine("\nВычитание.");
moneyBag1.minus(moneyBag2);
Console.WriteLine("\nУмножение первой суммы на число.");
moneyBag1.times(k);
Console.WriteLine("\nУмножение второй суммы на число.");
moneyBag2.times(k);
Console.WriteLine("\nДеление первой суммы на число.");
moneyBag1.divide(k);
Console.WriteLine("\nДеление второй суммы на число.");
moneyBag2.divide(k);
Console.WriteLine("\nСравнение сумм.");
moneyBag1.compare(moneyBag2);

interface IMoney
{
    void getTotal();
    double total();
    void merge();
    void plus(IMoney bag);
    void minus(IMoney bag);
    void times(int n);
    void divide(int n);
    void compare(IMoney bag);
}
abstract class Money : IMoney
{
    public Money()
    {
        totalvalue = 0;
    }
    public double totalvalue;
    public abstract void getTotal();
    public abstract double total();
    public abstract void merge();
    public abstract void plus(IMoney bag);
    public abstract void minus(IMoney bag);
    public abstract void times(int n);
    public abstract void divide(int n);
    public abstract void compare(IMoney bag);
}
class EngMoney : Money
{
    private double funt;
    private double shilling;
    private double pens;
    public EngMoney() :
        base()
    {
        funt = 0;
        shilling = 0;
        pens = 0;
    }
    public EngMoney(double funt, double shilling, double pens) :
        base()
    {
        this.funt = funt;
        this.shilling = shilling;
        this.pens = pens;
    }
    public override void getTotal()
    {
        merge();
        string output = "";
        if (funt != 0)
        {
            output += $"{funt} фунтов ";
        }
        if (shilling != 0)
        {
            output += $"{shilling} шиллингов ";
        }
        if (pens != 0)
        {
            output += $"{pens} пенсов ";
        }
        Console.WriteLine($"Всего содержится {total()} пенсов. {output}");
    }
    public override double total()
    {
        return funt * 20 * 12 + shilling * 12 + pens;
    }
    public override void merge()
    {
        while (pens >= 12)
        {
            pens -= 12;
            shilling++;
        }
        while (shilling >= 20)
        {
            shilling -= 20;
            funt++;
        }
    }
    public override void plus(IMoney bag)
    {
        double totalvalue1 = funt * 20 * 12 + shilling * 12 + pens;
        double totalvalue2 = bag.total();
        EngMoney bagSum = new(0, 0, totalvalue1 + totalvalue2);
        bagSum.merge();
        bagSum.getTotal();
    }
    public override void minus(IMoney bag)
    {
        double totalvalue1 = funt * 20 * 12 + shilling * 12 + pens;
        double totalvalue2 = bag.total();
        EngMoney bagSum = new(0, 0, Math.Abs(totalvalue1 - totalvalue2));
        bagSum.merge();
        bagSum.getTotal();
    }
    public override void times(int n)
    {
        int newtotal = Convert.ToInt32(total()) * n;
        EngMoney BAG = new EngMoney(0, 0, newtotal);
        BAG.getTotal();
    }
    public override void divide(int n)
    {
        int newtotal = Convert.ToInt32(total()) / n;
        EngMoney BAG = new EngMoney(0, 0, newtotal);
        BAG.getTotal();
    }
    public override void compare(IMoney bag)
    {
        if (total() > bag.total())
        {
            Console.WriteLine("Сумма 1 содержит больше денег.");
        }
        if (total() < bag.total())
        {
            Console.WriteLine("Сумма 2 содержит больше денег.");
        }
        if (total() == bag.total())
        {
            Console.WriteLine("Суммы содержат одинаковое количество денег.");
        }
    }
}