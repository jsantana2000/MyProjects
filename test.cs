public static int Factorial(int num)
{
		int value = 0;
		for (int i = 1; i < num; i++)
		{
			if (i == 1)
			{
				value = num * (num - i);
			}
			else
			{
				value = value * (num - i);
			}
		}
		return value;
}
