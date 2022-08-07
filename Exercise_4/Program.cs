Console.Write("Введите число N, ");
int N = Convert.ToInt32(Console.ReadLine());    // позволяет ввести нам с клавиатуры значение {N}

int count = 1;           // переменная {count} является целочисленным типом данных

while (count <= N)         // система работает до тех пор, пока значение {count} станет = {N}
{
    if (count % 2 == 0)
        Console.Write("{0} ", count);       // выводит значения {count} подходящие по условию через пробел
    count++;                // значение {count + 1}
}