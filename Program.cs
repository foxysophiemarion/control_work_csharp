void PrintArray(string[] array)
{
	for (int c = 0; c < array.Length; c++)
	{
		Console.Write(array[c]);
		Console.Write(", ");
	}
}

string[] Input()
{
	Console.WriteLine("Введите значения череp запятую в одну строку : ");
	string input = Console.ReadLine();
	string[] input_array = input.Split(",");
	return input_array;
}

string[] Len3_array()
{
	string[] array = Input();
	string new_string = string.Empty;
	for (int count = 0; count < array.Length; count++)
	{
		if (array[count].Length <= 3)
		{
			new_string = new_string + array[count] + ",";
		}
	}
	new_string = new_string.Remove(new_string.Length - 1);
	string[] new_array = new_string.Split(",");
	return new_array;
}
PrintArray(Len3_array());