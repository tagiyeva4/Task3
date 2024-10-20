// See https://aka.ms/new-console-template for more information
#region 1
//Verilmiş n ve m (n<m) ədədləri arasındakı tək ədədlərin sayını tapın.
//int n = Int32.Parse(Console.ReadLine());
//int m = Int32.Parse(Console.ReadLine());
//int num = 0;
//for (int i = n; i <= m; i++)
//{
//    if (i % 2 == 1)
//    {
//        num += 1;
//    }
//}
//Console.WriteLine(num);
#endregion
#region 2
//Verilmiş n ve m (n<m) ededleri arasindaki tek ədədlərin cəmini tapin.
//int n1 = Int32.Parse(Console.ReadLine());
//int m1 = Int32.Parse(Console.ReadLine());
//int sum = 0;
//for (int i = n1; i <= m1; i++)
//{
//    if (i % 2 == 1)
//    {
//        sum = sum + i;
//    }
//}
//Console.WriteLine(sum);
#endregion
#region 3
////m -ədədi verilir. 1-dən m-ədədinə kimi olan cüt ədədlərin hasilini tapin.
//int m2 = Int32.Parse(Console.ReadLine());
//int result = 1;
//for (int i = 1; i <= m2; i++)
//{
//    if ((i % 2) == 0)
//    {
//        result *= i;
//    }

//}
//Console.WriteLine(result);
#endregion
#region 4
/*a - ədədi 3-ə bölünən cüt ədəddirsə "3-e bolunur cutdur" ,3-ə bölünən tək ədəddirsə " ,
 3-e bolunur tekdir" əks halda "3-e bolunmur" sözünü ekranda çap edin */
//int a = Int32.Parse(Console.ReadLine());
//if (a % 3 == 0)
//{
//    if (a % 2 == 0)
//    {
//        Console.WriteLine("3-e bolunur cutdur");
//    }
//    else if (a % 2 == 1)
//    {
//        Console.WriteLine("3-e bolunur tekdir");

//    }
//}
//else
//{
//    Console.WriteLine("3-e bolunmur");
//}

#endregion
#region 5
//Verilmiş n tam ədədinin sadə və ya mürəkkəb ədəd olduğunu tapın.
int n2 = Int32.Parse(Console.ReadLine());
int num1 = 0;
for (int i = 1; i <= n2; i++)
{


    if (n2 % i == 0)
    {
        num1 += 1;
    }

}
if (n2 == 1)
{
    Console.WriteLine("nə sadə ,nə mürəkkəb");
}
if (num1 > 2)
{
    Console.WriteLine("mürəkkəb ədəddir");
}
else if (num1 ==2)
{ Console.WriteLine("sadə ədəddir"); }
#endregion
