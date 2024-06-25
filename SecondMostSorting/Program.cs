
int[] numbers = { 7, 4, 10, 20, 5, 23, 44, 66, 22, 11 };
int temp = numbers[0];
for (int j = 0; j < numbers.Length; j++)
{
	for (int i = 0; i < numbers.Length - 1; i++)
	{
		if (numbers[i] > numbers[i + 1])
		{
			temp = numbers[i + 1];
			numbers[i + 1] = numbers[i];
			numbers[i] = temp;
		}
	}
}
Console.WriteLine(numbers[numbers.Length - 2]);