Console.WriteLine("Сколько элементов будет в вашем массиве?");
int size = int.Parse(Console.ReadLine());

string[] arr1 = new string[size];

for (int i = 0; i < size; i++)
{
    Console.Write($"Ведите {i + 1} элемент массива: ");
    string result = Console.ReadLine();
    arr1[i] = result;
}
Console.WriteLine();
Console.Write("Ваш массив: ");
Console.Write(string.Join(" ", arr1));

int count = 0;
int maxLength = 3;

for (int i = 0; i < arr1.Length; i++)
{
    if (arr1[i].Length <= maxLength)
    {
        count++;
    }
}
Console.WriteLine();
Console.Write("Обработанный массив: ");
string[] arr2 = new string[count];
int j = 0;
for (int i = 0; i < arr1.Length; i++)
{
    if (arr1[i].Length <= maxLength)
    {
        arr2[j] = arr1[i];
        Console.Write(arr2[j] + " ");
        j++;
    }
}
