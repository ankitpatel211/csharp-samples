int[] numbers = { 42, 30, 12, 56, 89, 45, 37 };
for (int row = 0; row < numbers.Length - 1; row++) {
	for (int col = 0; col < numbers.Length - 1; col++) {
		if (numbers[col] > numbers[col + 1]) {
          (numbers[col], numbers[col + 1]) = (numbers[col + 1], numbers[col]);
        }
    }
}
foreach (int num in numbers) {
 	Console.Write(num + " ");
}