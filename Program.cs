using System;

namespace task2812
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(sum(20,5,'/'));
            Console.WriteLine(lastdigit(123));
            Console.WriteLine(multiplication(2,4));
            string word = "thanks!!!";
            Console.WriteLine(sumsimv(word, '!'));

            int[] numbers = { 1, -2, 3, -4 };
            int[] positiveNumbers = postivarray(numbers);
            for (int i = 0; i < positiveNumbers.Length; i++)
            {
                Console.Write(positiveNumbers[i]+" ");
            }
        }


        static double sum(int num1,int num2,char oper)
        {  //TASK1
            //Verilmiş iki ədəd üzərində verilmiş operator simvoluna əsasən
            //riyazi əməliyyat aparıb nəticəsini console - da göstərən metod.


           double result = 0;
           switch (oper)
                {
                    case '+':
                        result = num1 + num2;
                    break;
                    case '-':
                        result = num1 - num2;
                    break;
                case '*':
                        result = num1 * num2;
                    break;
                case '/':
                    if (num2 == 0)

                    { Console.WriteLine("0 bolme yoxdur"); }
                    
                        result =(double) num1 / num2;
                    break;
                    default:
                        Console.WriteLine("basqa simvol daxil edin");
                    
                    break;
                 } return result;
            
        }
        static int lastdigit(int num)
        {   //Task 4
            //Verilmişdədin rəqəmləri cəmini qaytaran metod
            int sum = 0;
            while(num>0)
            {
               int num2 = num % 10;
                sum += num2;
                num = (num - num2) / 10;
            }
            return sum;

        }
        static int multiplication(int num,int power)
        {  //TASK 5
            //Verilmiş ədədi verilmiş qüvvətə yüksəldib nəticəsini qaytaran metod
            int result = 1;
            for(int i=0;i<power;i++)
            {
                result *= num;
            }
            return result;
            
        }
        static int sumsimv(string text,char wantedChar)
        {    //TASK2
            //Verilmiş yazıdaki verilmiş simvolların sayını qaytaran metod
             {
                int count = 0;
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == wantedChar)
                    {
                        count++;
                    }
                }
                return count;
            }

           
        }
        static int[] postivarray(int[] arr)
        {
            //Verilmiş ədədlər siyahısının bütün elementlərini müsbət şəkildə qaytaran metod.
            //Misalçün metoda { 1,-4,9,-8} dəyərləri olan array göndərilsə metod
            //bizə { 1,4,9,8} dəyərləri olan array qaytarmalıdır.
            int[] positiveArr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    positiveArr[i] = -arr[i];
                }
                else
                {
                    positiveArr[i] = arr[i];
                }
            }
            return positiveArr;
        }


        }
    }


