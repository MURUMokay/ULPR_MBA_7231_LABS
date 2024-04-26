/*
 Дана запись с именем STUDENT, содержащая следующие поля:
- Фамилия и инициалы;
- Номер группы;
- Успеваемость (массив из пяти элементов).
Написать программу, которая выполняет следующие действия: Генерация из 10
записей типа STUDENT, и занесение их в файл данных:
- Чтение данных из файла и вывод их на экран;
- Вывод на экран фамилий и номеров групп для всех студентов, имеющих
хотя бы одну оценку 2 (если таких нет - вывести об этом сообщение).
- Список студентов должен быть упорядочен по алфавиту фамилий.
*/

using System.Diagnostics;

namespace lab11_2_wf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Text = "Student";
        }
        public class Student
        {
            string[] LNames = { "Смит", "Зайчик", "Швак", "Медуза", "Дождь", "Нош", "Кан", "Ким", "Ломма", "Широн", "Додж" };
            string[] FNames = { "Сенко", "Броня", "Аи", "Юки", "Мэй", "Рин", "Зов", "Мэй", "Мию", "Юто", "Рэн", "Дилан" };
            public string FirstName;
            public string LastName;
            public string GroupNumber;
            public char[] Marks = new char[5];
            Random rand = new Random();
            public Student(string stud):
                base()
            {
                FirstName = stud.Substring(0, stud.IndexOf(" "));
                stud = stud.Remove(0, FirstName.Length+1);
                LastName = stud.Substring(0, stud.IndexOf("."));
                stud = stud.Remove(0, LastName.Length+2);
                GroupNumber = stud.Substring(0, stud.IndexOf("."));
                stud = stud.Remove(0, GroupNumber.Length+1);
                stud = stud.Replace(" ", "");
                Marks = stud.ToCharArray();

            }
            public Student() :
                base()
            {
                FirstName = FNames[rand.Next(0, FNames.Length)];
                LastName = LNames[rand.Next(0, LNames.Length)];
                GroupNumber = rand.Next(100, 999).ToString() + '-' + rand.Next(1, 4).ToString();
                for (int i = 0; i < 5; i++) 
                {
                    Marks[i] = (char)rand.Next('2', '5'+1);
                }
            }
            public override string ToString()
            {
                return $"{FirstName} {LastName}. {GroupNumber}. {string.Join(" ", Marks)}" ;
            }
            public char[] GetMarks()
            {
                return Marks ;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void AddRandom_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo("original.txt");
            using (FileStream fs1 = file.Open(FileMode.Create)) { }
            using (StreamWriter potok = File.AppendText("original.txt"))
            {
                for (int i = 0; i < 10; i++)
                {
                    Student uno = new Student();
                    potok.WriteLine(uno.ToString());
                }
            }
            int count = 0;
            string line;
            OriginalList.Items.Clear();
            TextReader reader = new StreamReader("original.txt");
            while ((line = reader.ReadLine()) != null)
            {
                OriginalList.Items.Add(line);
                count++;
            }
            reader.Close();
        }
        private void ClearListOne_Click(object sender, EventArgs e)
        {
            OriginalList.Items.Clear();
            SortedList.Items.Clear();
            FileInfo file = new FileInfo("original.txt");
            using (FileStream fs1 = file.Open(FileMode.Create)) { }
        }
        private void DoSort_Click(object sender, EventArgs e)
        {
            List<Student> ForSort = new();
            for (int i = 0; i < OriginalList.Items.Count;i++)
            {
                ForSort.Add(new Student(OriginalList.Items[i].ToString()));
            }
            var ListSorted = ForSort.OrderBy(Z => Z.LastName);
            FileInfo file = new FileInfo("original.txt");
            using (FileStream fs1 = file.Open(FileMode.Create)) { }
            using (StreamWriter potok = File.AppendText("original.txt"))
            {
                foreach (Student item in ListSorted)
                {
                    potok.WriteLine(item.ToString());
                }
            }
            int count = 0;
            string line;
            OriginalList.Items.Clear();
            TextReader reader = new StreamReader("original.txt");
            while ((line = reader.ReadLine()) != null)
            {
                OriginalList.Items.Add(line);
                count++;
            }
            reader.Close();
        }

        private void FilterMov_Click(object sender, EventArgs e)
        {
            SortedList.Items.Clear();
            int count = 0;
            for (int i = 0; i < OriginalList.Items.Count; i++)
            {
                Student uno = new Student(OriginalList.Items[i].ToString());
                if (uno.GetMarks().Contains('2'))
                {
                    SortedList.Items.Add(OriginalList.Items[i]);
                    count++;
                }
            }
            if (count == 0)
            {
                SortedList.Items.Add("Не найдено.");
            }
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", "original.txt");
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            FileInfo sorted = new FileInfo("sorted.txt");
            using (FileStream fs2 = sorted.Open(FileMode.Create)) { }
            using (StreamWriter potok = File.AppendText("sorted.txt"))
            {
                if (SortedList.Items.Count > 0)
                {
                    for (int i = 0; i < SortedList.Items.Count; i++)
                    {
                        potok.WriteLine(SortedList.Items[i].ToString());
                    }
                }
                else
                { potok.WriteLine("Не найдено."); }
            }
            Process.Start("explorer.exe", "sorted.txt");
        }
    }
}
