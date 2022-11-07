using shirlitc;
internal class Program
{
    static void Main()
    {
        List<Заметки> notes = new List<Заметки>();

        Заметки note1 = new Заметки();

        DateTime dateTime = DateTime.Today;

        note1.title = "прятки";
        note1.content = "В 8.00";
        note1.date = dateTime;
        notes.Add(note1);

        Заметки note2 = new Заметки();

        note2.title = "Пойти сабаку";
        note2.content = "пред обедом";
        note2.date = dateTime.AddDays(+1);
        notes.Add(note2);

        Заметки note3 = new Заметки();

        note3.title = "Зайти к михаилу";
        note3.content = "перед парами";
        note3.date = dateTime.AddDays(+1);
        notes.Add(note3);

        Заметки note4 = new Заметки();

        note4.title = "поцибарить";
        note4.content = "на ахен";
        note4.date = dateTime.AddDays(+3);
        notes.Add(note4);

        Заметки note5 = new Заметки();

        note5.title = "Штирлиц в 1996";
        note5.content = "в 18:00";
        note5.date = dateTime.AddDays(+3);
        notes.Add(note5);

        Заметки note6 = new Заметки();

        note6.title = "За гаражами все дела";
        note6.content = " На рыбалке";
        note6.date = dateTime.AddDays(-3);
        notes.Add(note6);

        DateTime date = DateTime.Now;
        int position = 1;
        while (true)
        {
            int noteCount = 0;
            Console.Clear();
            List<Заметки> todayNotes = new List<Заметки>();
            Console.WriteLine($"Заметки на {date.ToShortDateString()}");
            foreach (Заметки zam in notes)
            {
                if (zam.date.Date == date.Date)
                {
                    Console.WriteLine(" " + zam.title);
                    todayNotes.Add(zam);
                    noteCount += 1;
                }
            }
            if (todayNotes.Count != 0)
            {
                Console.SetCursorPosition(0, position);
                Console.Write("->");
            }
            ConsoleKeyInfo Key = Console.ReadKey();
            switch (Key.Key)
            {
                case (ConsoleKey.RightArrow):
                    date = date.AddDays(1);
                    position = 1;
                    break;
                case (ConsoleKey.LeftArrow):
                    date = date.AddDays(-1);
                    position = 1;
                    break;
                case ConsoleKey.DownArrow:
                    if (noteCount != position)
                        position++;
                    break;
                case ConsoleKey.UpArrow:
                    if (position != 1)
                        position--;
                    break;
                case ConsoleKey.Enter:
                    if (noteCount != 0)
                    {
                        Console.Clear();
                        Заметки note = todayNotes[position - 1];
                        Console.WriteLine($"Заметка {note.title}\n" +
                        $"{note.content}"
                        );
                        Console.Write("Press any button");
                        Console.ReadKey();
                    }
                    break;
            }
        }
    }
}