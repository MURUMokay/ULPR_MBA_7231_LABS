Fruction a = new Fruction("25", "903");
Fruction b = new Fruction("10", "107");
Console.WriteLine($"a = {a.ToString()}\nb = {b.ToString()}");
Console.WriteLine($"a + b = {a.Add(b)}");
Console.WriteLine($"a - b = {a.Sub(b)}");
Console.WriteLine($"a * b = {a.Mul(b)}");
Console.WriteLine($"a || b = {a.Comp(b)}");
class Fruction
{

    private string _a;
    private string _b;
    public string A
    {
        get { return _a; }
        set { _a = value; }
    }
    public string B
    {
        get { return _b; }
        set { _b = value; }
    }
    public Fruction(string a, string b)
    {
        _a = a;
        _b = b;
    }
    public Fruction Add(Fruction secondnumber)
    {
        string result_a = ""; // строка вывода
        string result_b = ""; // вспомогательная строка вывода
        string sa = _a; //переведенная в строку целая часть первого числа
        string sb = secondnumber._a; //переведенная в строку дробная часть первого числа
        string sc = _b; //переведенная в строку целая часть второго числа
        string sd = secondnumber._b; //переведенная в строку дробная часть пвторого числа
        int se = 0; //вспомогательная строка для преобразования
        string sf = ""; //вспомогательная строка для преобразования
        double sg = 0; //вспомогательная строка для подсчёта
        int sh = 0; //вспомогательная строка для подсчёта
        double si = 0; //вспомогательная строга для подстчёта
        double sj = 0; //вспомогательная строка для подсчёта
        string sk = ""; //вспомогательная строка для подсчёта
                        // Всё это аналогично и для других аналогично названных переменных иных классов!!!
        if (sa.Length < sb.Length)
        {
            while (!(sa.Length == sb.Length))
            {
                sa = '0' + sa;
            }
        }
        else if (sa.Length > sb.Length)
        {
            while (!(sa.Length == sb.Length))
            {
                sb = '0' + sb;
            }
        }
        else
        {
            sa = sa;
            sc = sc;
        }

        if (sc.Length < sd.Length)
        {
            while (!(sc.Length == sd.Length))
            {
                sc = sc + '0';
            }
        }
        else if (sc.Length > sd.Length)
        {
            while (!(sc.Length == sd.Length))
            {
                sd = sd + '0';
            }
        }
        else
        {
            sc = sc;
            sd = sd;
        }
        se += Convert.ToInt32(sa);
        sf += "0," + sc;
        sg = Convert.ToDouble(sf);
        sh = Convert.ToInt32(sb);
        sd = "0," + sd;
        si = Convert.ToDouble(sd);
        sj = se + sh;
        sj = sj + sg + si;
        sk = Convert.ToString(sj);
        int i = 0;
        while (sk[i] != ',')
        {
            result_a += sk[i];
            i++;
        }
        while (i + 1 != sk.Length)
        {
            result_b += sk[i + 1];
            i++;
        }
        return new Fruction(result_a, result_b);
    }
    public Fruction Sub(Fruction secondnumber)
    {
        string result_a = ""; // строка вывода
        string result_b = ""; // вспомогательная строка вывода
        string sa = _a; //переведенная в строку целая часть первого числа
        string sb = secondnumber._a; //переведенная в строку дробная часть первого числа
        string sc = _b; //переведенная в строку целая часть второго числа
        string sd = secondnumber._b; //переведенная в строку дробная часть пвторого числа
        int se = 0; //вспомогательная строка для преобразования
        string sf = ""; //вспомогательная строка для преобразования
        double sg = 0; //вспомогательная строка для подсчёта
        int sh = 0; //вспомогательная строка для подсчёта
        double si = 0; //вспомогательная строга для подстчёта
        double sj = 0; //вспомогательная строка для подсчёта
        string sk = ""; //вспомогательная строка для подсчёта
                        // Всё это аналогично и для других аналогично названных переменных иных классов!!!
        if (sa.Length < sb.Length)
        {
            while (!(sa.Length == sb.Length))
            {
                sa = '0' + sa;
            }
        }
        else if (sa.Length > sb.Length)
        {
            while (!(sa.Length == sb.Length))
            {
                sb = '0' + sb;
            }
        }
        else
        {
            sa = sa;
            sc = sc;
        }

        if (sc.Length < sd.Length)
        {
            while (!(sc.Length == sd.Length))
            {
                sc = sc + '0';
            }
        }
        else if (sc.Length > sd.Length)
        {
            while (!(sc.Length == sd.Length))
            {
                sd = sd + '0';
            }
        }
        else
        {
            sc = sc;
            sd = sd;
        }
        se += Convert.ToInt32(sa);
        sf += "0," + sc;
        sg = Convert.ToDouble(sf);
        sh = Convert.ToInt32(sb);
        sd = "0," + sd;
        si = Convert.ToDouble(sd);
        sj = se - sh;
        sj = sj + (sg - si);
        sk = Convert.ToString(sj);
        int i = 0;
        while (sk[i] != ',')
        {
            result_a += sk[i];
            i++;
        }
        while (i + 1 != sk.Length)
        {
            result_b += sk[i + 1];
            i++;
        }
        return new Fruction(result_a, result_b);
    }
    public Fruction Mul(Fruction secondnumber)
    {
        string result_a = ""; // строка вывода
        string result_b = ""; // вспомогательная строка вывода
        string sa = _a; //переведенная в строку целая часть первого числа
        string sb = secondnumber._a; //переведенная в строку дробная часть первого числа
        string sc = _b; //переведенная в строку целая часть второго числа
        string sd = secondnumber._b; //переведенная в строку дробная часть пвторого числа
        int se = 0; //вспомогательная строка для преобразования
        string sf = ""; //вспомогательная строка для преобразования
        double sg = 0; //вспомогательная строка для подсчёта
        int sh = 0; //вспомогательная строка для подсчёта
        double si = 0; //вспомогательная строга для подстчёта
        double sj = 0; //вспомогательная строка для подсчёта
        string sk = ""; //вспомогательная строка для подсчёта
                        // Всё это аналогично и для других аналогично названных переменных иных классов!!!
        if (sa.Length < sb.Length)
        {
            while (!(sa.Length == sb.Length))
            {
                sa = '0' + sa;
            }
        }
        else if (sa.Length > sb.Length)
        {
            while (!(sa.Length == sb.Length))
            {
                sb = '0' + sb;
            }
        }
        else
        {
            sa = sa;
            sc = sc;
        }

        if (sc.Length < sd.Length)
        {
            while (!(sc.Length == sd.Length))
            {
                sc = sc + '0';
            }
        }
        else if (sc.Length > sd.Length)
        {
            while (!(sc.Length == sd.Length))
            {
                sd = sd + '0';
            }
        }
        else
        {
            sc = sc;
            sd = sd;
        }
        se += Convert.ToInt32(sa);
        sf += "0," + sc;
        sg = Convert.ToDouble(sf);
        sh = Convert.ToInt32(sb);
        sd = "0," + sd;
        si = Convert.ToDouble(sd);
        sj = (se + sg) * (sh + si);
        sk = Convert.ToString(sj);
        int i = 0;
        while (sk[i] != ',')
        {
            result_a += sk[i];
            i++;
        }
        while (i + 1 != sk.Length)
        {
            result_b += sk[i + 1];
            i++;
        }
        result_b = result_b.Substring(0, _b.Length*2);
        return new Fruction(result_a, result_b);
    }
    public Fruction Comp(Fruction secondnumber)
    {
        string result_a = ""; // строка вывода
        string result_b = ""; // вспомогательная строка вывода
        string sa = _a; //переведенная в строку целая часть первого числа
        string sb = secondnumber._a; //переведенная в строку дробная часть первого числа
        string sc = _b; //переведенная в строку целая часть второго числа
        string sd = secondnumber._b; //переведенная в строку дробная часть пвторого числа
        int se = 0; //вспомогательная строка для преобразования
        string sf = ""; //вспомогательная строка для преобразования
        double sg = 0; //вспомогательная строка для подсчёта
        int sh = 0; //вспомогательная строка для подсчёта
        double si = 0; //вспомогательная строга для подстчёта
        double sj = 0; //вспомогательная строка для подсчёта
        double sl = 0; //вспомогательная переменная
        string sk = ""; //вспомогательная строка для подсчёта
                        // Всё это аналогично и для других аналогично названных переменных иных классов!!!
        if (sa.Length < sb.Length)
        {
            while (!(sa.Length == sb.Length))
            {
                sa = '0' + sa;
            }
        }
        else if (sa.Length > sb.Length)
        {
            while (!(sa.Length == sb.Length))
            {
                sb = '0' + sb;
            }
        }
        else
        {
            sa = sa;
            sc = sc;
        }

        if (sc.Length < sd.Length)
        {
            while (!(sc.Length == sd.Length))
            {
                sc = sc + '0';
            }
        }
        else if (sc.Length > sd.Length)
        {
            while (!(sc.Length == sd.Length))
            {
                sd = sd + '0';
            }
        }
        else
        {
            sc = sc;
            sd = sd;
        }
        se += Convert.ToInt32(sa);
        sf += "0," + sc;
        sg = Convert.ToDouble(sf);
        sh = Convert.ToInt32(sb);
        sd = "0," + sd;
        si = Convert.ToDouble(sd);
        sj = se + sg;
        sl = sh + si;
        if (sj > sl)
        {
            sk = Convert.ToString(sj);
            int i = 0;
            while (sk[i] != ',')
            {
                result_a += sk[i];
                i++;
            }
            i += 1;
            while (i != sk.Length)
            {
                result_b += sk[i];
                i++;
            }
            return new Fruction(result_a, result_b);
        }
        else
        {
            sk = Convert.ToString(sl);
            int i = 0;
            while (sk[i] != ',')
            {
                result_a += sk[i];
                i++;
            }
            while (i + 1 != sk.Length)
            {
                result_b += sk[i + 1];
                i++;
            }
            return new Fruction(result_a, result_b);
        }
    }

    public override string ToString()
    {
        return $"{A},{B}";
    }
}