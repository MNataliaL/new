//Задание 3. Считать строку с консоли, содержащую латинские буквы. Вывести на экран согласные буквы этой строки.
// Указание
// Использовать рекурсию. Не использовать цикл.
// Пример
// “hello” => h l l
// “World” => W r l d
// “Hello world!” => H l l w r l d

void CheckConsonants (string txt, int index)
{
string vowels = "aeiouy";
    if (char.IsAsciiLetter(txt[index]) && !vowels.Contains(txt[index]))
    {
        Console.Write($"{txt[index]} ");
    }
}

void PrintConsonants(string txt, int index = 0)
{
    if (index == txt.Length) return;
    CheckConsonants (txt, index);
    PrintConsonants(txt, index + 1);
}

Console.WriteLine("Введите строку, содержащую латинские буквы:");
string text = Console.ReadLine();
PrintConsonants(text);