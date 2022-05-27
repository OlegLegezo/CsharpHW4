// Напишите функцию, которая принимает слово и возвращает true, если в этом слове есть две одинаковые, стоящие рядом буквы.
// "ссора" -> true
// "клюющий" -> true
// "кодер" -> false
// "цыпленок"-> false

Console.WriteLine("введите слово");
var word = Console.ReadLine();

bool DoubleWord = false;
for (int i = 0; i < word.Length; i++)//word.Lenght - длина строки
{
    int previus = i - 1;
    if (i > 0 && word[i] == word[previus])
    {
        DoubleWord = true;
    }
}

Console.WriteLine(DoubleWord);


