int[] array = { 1, 3, 5, 8, 9, 12, 45, 8 };
int n = array.Length;
int find = 8;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}