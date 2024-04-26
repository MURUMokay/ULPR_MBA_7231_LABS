/*Описать классы «Шахматная фигура», «Легкая фигура», «Тяжелая фигура», «Пешка», 
 * «Король», «Слон», «Ладья». Выстроить правильную иерархию наследования этих классов, 
 * определить какие из классов должны быть абстрактными, какие
методы абстрактными или виртуальными. Описать конструкторы и деструкторы разработанных 
классов. Создать по одному объекту каждого класса, для которого это возможно, поместить 
их в один массив. Считать, что все элементы массива — это фигуры
на доске. Для объекта класса «Король» метод Сastling (возможность рокировки) и вывести 
на экран все свойства каждого из объектов.*/
/*«В программе продемонстрировать
функциональность разработанных классов и полиморфное поведение». 
Все данные для заполнения полей необходимо вводить с клавиатуры. 
Обязательно использование абстрактных классов, интерфейсов, 
конструкторов и деструкторов.*/

List <IFigures> ChessBoard= [];
Console.Write("Введите координаты короля: ");
string kingpos = Console.ReadLine();
King king = new(ushort.Parse(Convert.ToString(kingpos[0])), kingpos[1]);
Console.Write("Введите координаты слона: ");
string bishoppos = Console.ReadLine();
Bishop bishop = new(ushort.Parse(Convert.ToString(bishoppos[0])), bishoppos[1]);
Console.Write("Введите координаты пешки: ");
string pawnpos = Console.ReadLine();
Pawn pawn = new(ushort.Parse(Convert.ToString(pawnpos[0])), pawnpos[1]);
Console.Write("Введите координаты ладьи: ");
string rookpos = Console.ReadLine();
Rook rook = new(ushort.Parse(Convert.ToString(rookpos[0])), rookpos[1]);
ChessBoard.Add(king);
ChessBoard.Add(pawn);
ChessBoard.Add(rook);
ChessBoard.Add(bishop);

Console.WriteLine("\nДвижение короля");
king.CheckPos();
king.Move();
king.CheckPos();
Console.WriteLine("\nДвижение слона");
bishop.CheckPos();
bishop.Move();
bishop.CheckPos();
Console.WriteLine("\nРокировка короля и слона");
king.Castling(bishop);
king.CheckPos();
bishop.CheckPos();
Console.WriteLine("\nДвижение пешки");
pawn.CheckPos();
pawn.Move();
pawn.CheckPos();
Console.WriteLine("\nДвижение ладьи");
rook.CheckPos();
rook.Move();
rook.CheckPos();

interface IFigures
{
    void Move();
    void CheckPos();
}
abstract class ChessFigures: IFigures
{
    abstract public void Move();
    abstract public void CheckPos();
    public ushort GetPos() {  return Position; }
    public char GetLit() { return Liter; }  
    public ushort Position;
    public char Liter;
}
abstract class LightFigure : ChessFigures
{
    public override void CheckPos()
    {
        Console.WriteLine($"Лёгкая фигура находится на позиции: {Position}{Liter}");
    }
    public override void Move()
    {
        Position++;
    }
}
abstract class HeavyFigure : ChessFigures
{
    public override void CheckPos()
    {
        Console.WriteLine($"Тяжёлая фигура находится на позиции: {Position}{Liter}");
    }
}
class Pawn : LightFigure
{
    public Pawn():
        base()
    {
        Position = 2;
        Liter = 'A';
    }
    public Pawn(ushort pos, char lit): 
        base() 
    {
        Position = pos;
        Liter = lit;
    }
}
class King : LightFigure
{
    public King() :
    base()
    {
        Position = 1;
        Liter = 'E';
    }
    public King(ushort pos, char lit) : base()
    {
        Position = pos;
        Liter = lit;
    }
    public void Castling(Bishop other)
    {
        if (other.GetPos() == Position) 
        {
            if (other.GetLit() > Liter)
            {
                Liter = (char)((int)Liter + 2);
                other.Liter = (char)((int)Liter - 1);
            } 
            else if (Liter > other.GetLit())
            {
                Liter = (char)((int)Liter - 2);
                other.Liter = (char)((int)Liter + 1);
            }
        } else 
            { 
            Console.WriteLine("Фигуры находятся на разных линиях."); 
            }
    }
}
class Rook : HeavyFigure
{
    public Rook() :
    base()
    {
        Position = 1;
        Liter = 'C';
    }
    public Rook(ushort pos, char lit) : base()
    {
        Position = pos;
        Liter = lit;
    }
    public override void Move()
    {
        Position++;
        Liter++;
    }
}
class Bishop : HeavyFigure
{
    public Bishop() :
            base()
    {
        Position = 1;
        Liter = 'H';
    }
    public Bishop(ushort pos, char lit) : base()
    {
        Position = pos;
        Liter = lit;
    }
    public override void Move()
    {
        Position++;
    }
}