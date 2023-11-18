

//int[] ages = new int[] { 1, 3, 5 };

//for (int i = 0; i <= ages.Length; i++)
//{
//	try
//	{
//        Console.WriteLine(ages[i]);
//    }
//	catch (Exception ex)
//	{
//        Console.WriteLine("We had an error.");
//        Console.WriteLine(ex.Message);
//        throw;
//    }
//}

//Console.ReadLine();

int[] ages = new int[] { 0, 1, 2, 3, 4 };

for (int i = 0; i <= ages.Length; i++)
{
	try
	{
		Console.WriteLine(ages[i]);
    }
	catch (Exception ex)
	{
        Console.WriteLine("We had an error.");
		Console.WriteLine(ex.Message);
	}
}
