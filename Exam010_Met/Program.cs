int [] array = {1,23,345,75,79,7890,9};
int n = array.Length;
int find = 75;
int index = 0;

while (index < n)
{
    if (array [index] == find)
    {
        Console.WriteLine (index);
        break;
    }
    index++;
}