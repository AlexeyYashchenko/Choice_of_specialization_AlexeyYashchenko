//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив
//        из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив 
//        можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

string[] text = new string[5];
text[0] = "стул";
text[1] = "кон";
text[2] = "да";
text[3] = "место";
text[4] = "нет";

int ThreeLetter(string[] array)    //Подсчет слов с кол-вом букв меньше или = 3
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (text[i].Length <= 3) count++;
    }
    return count;
}

int result = ThreeLetter(text);

string[] newText = new string[result];
int j = 0;
for (int i = 0; i < 5; i++)
{
    if (text[i].Length <= 3)
    {
        newText[j] = text[i];
        j++;
    }
}

Console.WriteLine($"[{String.Join(", ", text)}] -> [{String.Join(", ", newText)}]");