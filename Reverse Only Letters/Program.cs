using System;
using System.Text.RegularExpressions;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(ReverseOnlyLetters("7_28]"));          // Output: "dc-ba"
        Console.WriteLine(ReverseOnlyLetters("a-bC-dEf-ghIj"));  // Output: "j-Ih-gfE-dCba"
        Console.WriteLine(ReverseOnlyLetters("Test1ng-Leet=code-Q!")); // Output: "Qedo1ct-eeLg=ntse-T!"
    }

    public static string ReverseOnlyLetters(string s)
    {
        char[] arr = s.ToCharArray();
        int left = 0, right = s.Length - 1;

        while (left < right)
        {
            if (!IsLetter(arr[left]))
            {
                left++;
            }
            else if (!IsLetter(arr[right]))
            {
                right--;
            }
            else
            {
                // Swap letters
                char temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;

                left++;
                right--;
            }
        }

        return new string(arr);
    }

    private static bool IsLetter(char ch)
    {
        return char.IsLetter(ch); // Simpler than regex
    }
}
