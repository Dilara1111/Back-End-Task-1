// See https://aka.ms/new-console-template for more information
using System.Reflection;

////Task 1;
///
//int a, b;
//a=5; b=10;
//int sum = 0;
//    for(int i = a; i<b; i++)
//    {
//        sum += i;
//    }
//console.writeline(sum);

// Task 2
//Console.WriteLine("TASK #2");
//Console.Write("Enter begin of the range:");
//int i = int.Parse(Console.ReadLine());
//Console.Write("Enter end of the range:");
//int a = int.Parse(Console.ReadLine());
//int result = 0;
//for (;i < a; i++)
//{
//    if (i % 15 == 0)
//    {
//        Console.WriteLine(i);
//        result++;
//    }
    
//}
//Console.WriteLine(result);

////////////////   HOMEWORK   /////////////////////////
///////// task 1 ///////////////
/// 1-dən m-ədək ədədlər içərisində 21-ə bölünən ədədlərin ədədi ortasını tapan alqoritm
/// 
//console.writeline("task_1");
//console.write("enter end of the range:");
//int num_2 = int.parse(console.readline());
//int average = 0;
//int sum = 0;
//for (int i = 1;i <= num_2; i++)
//{
//    if ((i % 21) == 0)
//    {
//        average++;
//        sum += i;
//    }
//}
//console.writeline($"{sum}x{average}={sum/average}");

////////////// task 2 ////////////////
/// 2 ədəd verilmişdir. daxil edilən ədədlər də daxil olmaqla bu ədədlərin aralığında olan ədədlərin cəmin tapan alqoritm qurun.
//console.writeline("task_2");
//console.write("enter begin of the range:");
//int num_3 = int.parse(console.readline());
//console.write("enter begin of the range:");
//int num_4 = int.parse(console.readline());
//int sum_1 = 0;
//for  (int i = num_3;i <= num_4; i++)
//{
//    sum_1 += i;
//}
//console.writeline(sum_1);

//////////////////// Task_3 ///////////////
/// Verilmiş M-dən N-ədək ədədlər içərisində neçə ədədin rəqəmləri cəminin cüt olduğunu tapan alqoritm qurun.
Console.WriteLine("Task_3");
Console.Write("Enter begin of the range:");
int m = int.Parse(Console.ReadLine());
Console.Write("Enter end of the range:");
int n = int.Parse(Console.ReadLine());
int sum_2 = 0;
int res = 0;
int res_1 = 0;
for (int i = m; i <= n; i++)
{
    int digit = 0;
    int a = i;
    
    while (a != 0)
    {
        digit = a % 10;
        sum_2 += digit;
        a/=10;
    }  
    if (sum_2 % 2 == 0)
    {
        res_1++;        
    }
    
}
Console.WriteLine(res_1);

