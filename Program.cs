/*
You are given a large integer represented as an integer array digits, where each digits[i] is the ith digit of the integer. 
The digits are ordered from most significant to least significant in left-to-right order. The large integer does not 
contain any leading 0's.
Increment the large integer by one and return the resulting array of digits.
*/
using static System.Console;
using static System.Convert;

Write("Enter the lenght of the array: ");

string? input = ReadLine();


int dimention = ToInt32(input);

int []array = new int[dimention];
    
    
for(int i = 0;i<array.Length;i++)
{
    array[i] = Random.Shared.Next(0,10);
}

for(int i = 0;i<array.Length;i++)
{
    Write($"[{array[i]}],");
}

WriteLine();


int plusone = array[array.Length - 1];
plusone += 1;
array[array.Length - 1] = plusone;

for(int i = 0;i<array.Length;i++)
{
    Write($"[{array[i]}],");
}
