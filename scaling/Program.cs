Console.WriteLine("Введите количество вершин фигуры");
int Vertex = Convert.ToInt32(Console.ReadLine());

int[,] array = new int [Vertex, 2];
for (int i = 0; i < Vertex; i++)
{
    Console.Write($"Введите координаты x{i} ");
    array[i,0] = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Введите координаты y{i} ");
    array[i,1] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"Исходный массив с координатами");

for (int i = 0; i < Vertex; i++)
{
    Console.Write($"({array[i,0]},{array[i,1]})");
}

Console.WriteLine();
Console.Write($"Введите кооэффицент масштабирования k=");
int k = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Масштабированная фигура имеет координаты:");
for (int i = 0; i < Vertex; i++)
{
    Console.Write($"({array[i,0] * k},{array[i,1] * k})");
}