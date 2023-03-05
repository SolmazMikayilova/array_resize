// See https://aka.ms/new-console-template for more information

bool flag = true;
int increment = 0;
Console.WriteLine("Please enter the size of the array");
int sizeArray = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[0];
do
{
    Console.WriteLine("Enter element ");
    int element = Convert.ToInt32(Console.ReadLine());
   Array.Resize(ref numbers, increment+1);
    numbers[increment] = element;
    increment++;
    Console.WriteLine("Do you want to continue? ");
    string answer = Console.ReadLine();
    if (!(answer == "y" || answer == "Y"))
    {
        flag = false;
        Console.WriteLine(".......exiting");
    }

} while (flag);
Console.WriteLine("elements:");

foreach (int elements in numbers)
{
    Console.WriteLine(elements);
}