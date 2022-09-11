//Задача 66: Задайте значения M и N. Напишите программу, которая
//найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int CountSum(int M, int N) {
    int sum = 0;
    for (int i = M; i < N+1; i++) {
        sum += i;
    }
    return sum;
}

Console.Write("Введите М: ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine());

int sum = CountSum(M, N);
Console.WriteLine($"Сумма чисел в промежутке от М до N = {sum}");