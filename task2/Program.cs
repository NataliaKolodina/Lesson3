// Цикл FOR

string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++) // for (инициализация счетчика; проверка условия; увеличение счетчика)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "b");
Console.WriteLine(res);
