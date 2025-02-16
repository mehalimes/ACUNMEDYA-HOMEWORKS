int[] nums = new int[3];

Console.Write("Enter the first number : ");
nums[0] = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the second number : ");
nums[1] = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the third number : ");
nums[2] = Convert.ToInt32(Console.ReadLine());

if (nums[0] > nums[1] && nums[0] > nums[2])
{
    Console.WriteLine("The first number is the greatest.");
}
else if (nums[1] > nums[0] && nums[1] > nums[2])
{
    Console.WriteLine("The second number is the greatest.");
}
else if (nums[2] > nums[0] && nums[2] > nums[1])
{
    Console.WriteLine("The third number is the greatest.");
}
else
{
    Console.WriteLine("All numbers are equal.");
}