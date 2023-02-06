// Виды методов:

// Вид 1
// - не принимает
// - не возвращает
void Method1()
{
    Console.WriteLine("Автор: ....");
}

// Вызвать метод:
Method1();

// Вид2
// + принимает
// - не возвращает
void Method2(string msg)
{
    Console.WriteLine(msg);
}

// Вызвать метод:
Method2("Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

// // Вызвать метод:
Method21("Текст", 4);

// // или
// Method21(msg: "Текст", count: 4);
// //или
// Method(count: 4, msg: "Текст");

// Вид 3
// - не принимает
// + возвращает

int Method3()
{
    return DateTime.Now.Year;
}

// Вызвать метод:
int year = Method3();
Console.WriteLine(year);

// Вид 4
// + принимает
// + возвращает
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

//Вызвать метод:
string res = Method4(10, "b");
Console.WriteLine(res);
