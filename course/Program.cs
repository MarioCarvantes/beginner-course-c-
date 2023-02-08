using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console and variables

            //String NameProta = "Axel";
            //int ProtaAge;
            //ProtaAge= 20;

            //Console.WriteLine("Hola mi nombre es " + NameProta);
            //Console.WriteLine("Tengo " + ProtaAge + " años");
            //NameProta= "Mario";
            //Console.WriteLine(NameProta +  " es joven " );
            //Console.WriteLine("");
            //Console.WriteLine("");
            //Console.ReadLine();


            //-----------------------------------------------
            //DataTypes

            //for words
            //string Word = "Hello";
            ////for one letter
            //char grade = 'A';
            ////for integrals numbers
            //int Number = 10;
            ////for decimal numbers
            //double DecimalNumber = 5.5;
            ////true or false
            //bool isTrue = false;


            //-----------------------------------------------
            //Strings


            //String NameProta = "Axelicus Belicus";
            //Console.WriteLine(NameProta);
            //Console.ReadLine();

            //-----------------------------------------------
            //Numbers

            //int num = 10;
            //num++;
            //Console.WriteLine(num);
            //Console.ReadLine();


            //-----------------------------------------------
            //User input


            //Console.Write("como te llamas: ");
            //string name = Console.ReadLine();
            //Console.Write("cuantos años tienes: ");
            //string age = Console.ReadLine();
            //Console.WriteLine(" tu nombre es " + name + " y tienes " + age + " años");

            //Console.ReadLine();


            //-----------------------------------------------
            //Calculator

            //Console.Write("ingrese un numero: ");
            //double FirtsNumber = Convert.ToDouble(Console.ReadLine());
            //Console.Write("ingrese el segundo numero: ");
            //double SecondNumber = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("su resultado es: " + (FirtsNumber + SecondNumber));

            //Console.ReadLine();

            //-----------------------------------------------
            //Mad libs Game

            //string color, Noun, celebrity;

            //Console.Write("escribe un color ");
            //color= Console.ReadLine();

            //Console.Write("escribe un Noun ");
            //Noun = Console.ReadLine();

            //Console.Write("escribe un Celebrity ");
            //celebrity = Console.ReadLine();

            //Console.WriteLine("Roses are " + color);
            //Console.WriteLine(Noun + " are blue");
            //Console.WriteLine("I love " + celebrity);

            //Console.ReadLine();




            //-----------------------------------------------
            //Arrays

            //double[] numerosRandoms = {1,2,3,4,5,6,7,8};

            //Console.WriteLine(numerosRandoms[6]);
            //Console.ReadLine();



            //-----------------------------------------------
            //Methods

            //Names("mario");
            //Console.ReadLine();




            //-----------------------------------------------
            //Return statement

            //Console.WriteLine(cube(5));
            //Console.ReadLine();


            //-----------------------------------------------
            //If statement

            //bool isMale = false;
            //bool isTall = false;

            //if (isMale && isTall)
            //{
            //    Console.WriteLine("you are male and tall");
            //}
            //else if (isMale && !isTall)
            //{
            //    Console.WriteLine("you are a short male");
            //}
            //else if (!isMale && isTall)
            //{
            //    Console.WriteLine("you are a tall someting");
            //}
            //else
            //{
            //    Console.WriteLine("you are not male");
            //}

            //-----------------------------------------------
            //If statement part 2, comparisons

            //Console.WriteLine(maxNumber(100,70, 60));

            //-----------------------------------------------
            //Calculator part 2, better calculator

            //Console.Write("insert a number: ");
            //double num = Convert.ToDouble(Console.ReadLine());

            //Console.Write("insert a operator: ");
            //string ope = Console.ReadLine();

            //Console.Write("insert a second number: ");
            //double num3 = Convert.ToDouble(Console.ReadLine());

            //if (ope == "+")
            //{
            //    Console.WriteLine(num + num3);
            //}
            //else if (ope == "-")
            //{
            //    Console.WriteLine(num - num3);
            //}
            //else if (ope == "*")
            //{
            //    Console.WriteLine(num * num3);
            //}
            //else if (ope == "/")
            //{
            //    Console.WriteLine(num / num3);
            //}
            //else
            //{
            //    Console.WriteLine("OPERATOR ERROR, pls introduce one of next operators: +, -, /, *");
            //}


            //-----------------------------------------------
            //switch statements

            //Console.WriteLine(getDay(2));


            //-----------------------------------------------
            //while loop, ciclos

            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //-----------------------------------------------
            //activiti, guessing game duda


            //string sWord = "quack";
            //string guess = null;
            //int numGuess = 1;

            //while (guess != sWord && numGuess <= 4)
            //{
            //    Console.Write("what sound does the duck make: ");
            //    guess = Console.ReadLine();
            //    numGuess++;
            //}
            //if (guess == sWord)
            //{
            //    Console.WriteLine("you win");
            //}
            //else
            //{
            //    Console.WriteLine("you lose");

            //}


            //-----------------------------------------------
            //for loop

            //for(int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //-----------------------------------------------
            //Exponent Methods



            //-----------------------------------------------
            //Arrays the secuel or multidimensial arrays







            Console.ReadLine();
            

        }
        
        //-----------------------------------------------
        //Exponent Methods
        static int Exponent(int num, int exnum)
        {
            int result = 1;

            for(int i = 0; i < exnum; i++)
            {
                result = result * num;
            }

            return result;
        }

        //-----------------------------------------------
        //switch statements
        //static string getDay(int dayNum)
        //{       
        //    string dayName = null;

        //    switch (dayNum)
        //    {
        //        case 1:
        //            dayName= "sunday";
        //            break;
        //        case 2:
        //            dayName = "Monday";
        //            break;
        //        case 3:
        //            dayName = "tuesday";
        //            break;
        //        case 4:
        //            dayName = "wednesday";
        //            break;
        //        case 5:
        //            dayName = "thursday";
        //            break;
        //        case 6:
        //            dayName = "friday";
        //            break;
        //        case 7:
        //            dayName = "saturday";
        //            break;
        //        default:
        //            dayName = "that character is not valid";
        //            break;
        //    }

        //    return dayName;
        //}




        //-----------------------------------------------
        //If statement part 2, comparisons

        //static int maxNumber(int num, int num2, int num3)
        //{
        //    int result;
        //    if (num >= num2 && num >= num3)
        //    {
        //        result = num;
        //    }
        //    else if (num2 >= num && num2 >= num3)
        //    {
        //        result = num2;
        //    }
        //    else
        //    {
        //        result = num3;
        //    }

        //    return result;
        //}


        //-----------------------------------------------
        //Methods

        //public static void Names(string names)
        //{
        //    Console.WriteLine("Hola: " + names);
        //}



        //-----------------------------------------------
        //Return statement
        //static double cube(int num)
        //{
        //    int result = num * num * num;
        //    return result;
        //}





    }
}
 