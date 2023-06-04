// Задача 2: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
CreatedArrayRandomNumbers(numbers);
Console.WriteLine("В массиве следующие числа: ");
PrintArray(numbers);
int sum = 0;

for (int j = 0; j < numbers.Length; j+=2)
    sum = sum + numbers[j];

    Console.WriteLine($"Всего {numbers.Length} чисел");
    Console.WriteLine($"Сумма чисел на нечётных позициях = {sum}");
void CreatedArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(1,10000);
        }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}