//В некотором машинном алфавите имеются 4 буквы "а", "и", "С", "В". Покажите все слова, состоящие из Т букв, которые 
// можно построить из букв этого алфавита.
// char[] s = { 'а', 'и', 'с', 'в' };
// int count = s.Length;
// int n = 1;
// for (int i = 0; i < count; i++)
// {
//     for (int j = 0; j < count; j++)
//     {
//         for (int k = 0; k < count; k++)
//         {
//             Console.WriteLine($" {n++,-20}{s[i]} {s[j]} {s[k]} ");
//         }
//     }
// }

//Общее решение через рекурсию.

int n = 1;
void FindWords(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)} ");
        return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length +1);
    }
}
FindWords("аисв", new char [2]);