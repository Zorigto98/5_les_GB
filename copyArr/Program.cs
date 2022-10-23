int N=5;

int[] array = new int [N];

Random rand = new Random();

Console.Write ("Исходный массив: ");

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(1, 10);
    Console.Write($"{array[i]}, ");
}

int[] copyArr = new int [N];

for (int i = 0; i < array.Length; i++)
{
    copyArr[i] = array[i];
}

Console.WriteLine();
Console.Write("Скопированный массив: ");

for (int i = 0; i < copyArr.Length; i++)
{
    Console.Write($"{copyArr[i]}, ");
}