int i, j, temp = 0;
int[] numbers = { 1, 3, 3, 5, 5, 5, 2, 4, 5, 6, 1, 1, 1, 
    1, 7, 3, 5, 6, 6, 10, 10, 15, 15 };
List<int> duplicateNumbers = new();
for (i = 0; i < numbers.Length - 1; i++)
{
    firstLoop:
    if (temp == numbers[i])
        continue;
    else
    {
        int count = 0;
        for (j = i + 1; j < numbers.Length; j++)
        {
            if (count == 1)
                continue;
            else if (numbers[i] == numbers[j])
            {
                count += 1;
                temp = numbers[i];
                if (duplicateNumbers.Count > 0)
                {
                    foreach (int n in duplicateNumbers)
                    {
                        if (numbers[i] == n)
                            goto firstLoop;
                    }
                }
                duplicateNumbers.Add(numbers[i]);
            }
        }
    }
}
foreach (int duplicateN in duplicateNumbers)
    Console.WriteLine(duplicateN.ToString());