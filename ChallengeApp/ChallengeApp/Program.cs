int number = 4566;
string numberInString = number.ToString();
char[] letters = numberInString.ToCharArray();
int[] digits = new int[10]; 

foreach (char c in letters)
{
    string digitString = c + "";
    int index = int.Parse(digitString);
    digits[index] = digits[index] + 1;
}

for (int i = 0; i < digits.Length; i++)
{
    Console.WriteLine(i + " => " + digits[i]);
}