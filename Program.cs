var random_numbers = new int[75_000];
var randomObj = new Random(4711);

for (int i = 0; i < 75_000; i++)
{
    random_numbers[i] = randomObj.Next(1, 1_000_000_000);
}
 
Sort(random_numbers);
var result = CalculateDistance(random_numbers);
Console.WriteLine($"The average distance between the numbers is: {result :F4}");

int[] Sort(int[] unsorted_numbers)
{
    for (int i = 0; i < unsorted_numbers.Length; i++)
    
    {
        for (int j = i + 1; j < unsorted_numbers.Length; j++)
        {
            if (unsorted_numbers[i] > unsorted_numbers[j])
            {
                int temp = unsorted_numbers[i];
                unsorted_numbers[i] = unsorted_numbers[j];
                unsorted_numbers[j] = temp;
            }
        }
    }
    return unsorted_numbers;
}


double CalculateDistance(int[] random_numbers)
{
    double distance = 0, sum_of_distance = 0;
    for (int i = 0; i < random_numbers.Length -1; i++)
    {
        int averrage_distance = Math.Abs((random_numbers[i] - random_numbers[i + 1]));
        distance += averrage_distance;
        sum_of_distance++;
    }
    distance = distance / sum_of_distance;
    return distance;
}

