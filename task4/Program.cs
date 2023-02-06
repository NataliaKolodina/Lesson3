// Дан текст. В тексте нужно все пробелы заменить черточками, маленькие буквы "к" заменить большими "К", а большие "С" заменить маленькими "с".

Console.Clear();
string text =
    "- Я думаю, - сказал князь, улыбаясь, - что, "
    + "ежели бы вас послаливместо нашего милого Винценгероде,"
    + "вы бы взяли приступом согласие прусского короля. "
    + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "jfpwkd"
//             012345
// s[3] // w

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length; // переменная length будет показывать скольо символов в строке
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue)
            result = result + $"{newValue}";
        else
            result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);

Console.WriteLine(); //отделение пустой строчкой

newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);

Console.WriteLine();

newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);
