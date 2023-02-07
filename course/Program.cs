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
            //Console.WriteLine(NameProta +  " le gusta a " );
            //Console.WriteLine("");
            //Console.WriteLine("");
            //Console.ReadLine();


            //-----------------------------------------------
            //DataTypes

            //for words
            string Word = "Hello";
            //for one letter
            char grade = 'A';
            //for integrals numbers
            int Number = 10;
            //for decimal numbers
            double DecimalNumber = 5.5;
            //true or false
            bool isTrue = false;


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

            bool isMale = false;
            bool isTall = true;

            if (isMale && isTall)
            {
                Console.WriteLine("you are male and tall");
            }else if (isMale && !isTall){
                Console.WriteLine("you are a short male");
            }
            else if (!isMale && isTall)
            {
                Console.WriteLine("you are a tall someting");
            }
            else
            {
                Console.WriteLine("you are not male");
            }

            Console.ReadLine();

        }




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
 