Console.Write("Enter your password : ");

string password = Console.ReadLine();

char[] specialCharacters = new char[] { '!', '@', '#', '$', '%', '^', '&', '*' };

bool doesPasswordContainSpecialCharacter = password.Any(ch => specialCharacters.Contains(ch));

bool doesPasswordContainUpperCaseLetter = password.Any(ch => char.IsUpper(ch));

if (password.Length < 8)
{
    Console.WriteLine("Password must be at least 8 characters long.");
}
else if (!doesPasswordContainSpecialCharacter)
{
    Console.WriteLine("Password must contain at least one special character.");
}
else if (!doesPasswordContainUpperCaseLetter)
{
    Console.WriteLine("Password must contain at least one uppercase letter.");
}
else
{
    Console.WriteLine("Password is valid.");
}