// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = new int[4];
Random rand = new Random();
int sumN = 0;//сумма элементов стоящих на нечетных позициях

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-10, 99);
}
for (int i = 1; i < array.Length; i+=2)
{
    sumN =  sumN +array[i]; 
}
Console.WriteLine(string.Join(" , ", array));
Console.WriteLine($"Сумма элементов стоящих на нечетных позициях = {sumN}");

