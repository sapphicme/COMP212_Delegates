using System;

// Name: Arielle Mueller
// Student Number: 301037045
// Date: January 9th, 2020
// Class: Programming 3
// Assignment: Lab 1 - Delegates and Multicasting


namespace Lab1a_ArielleMueller
{
    //declaration of delegate
    delegate void MathDelegate(double firstNum, double secondNum);

    class Program
    {
        public static void Add(double firstNum, double secondNum)
        {
            double addNum = firstNum + secondNum;
            Console.WriteLine("Addition is: {0}", addNum);

           
        }

        public static void Subtract(double firstNum, double secondNum)
        {
            double subNum = firstNum - secondNum;
            Console.WriteLine("Subtraction is: {0}", subNum);
        }

        public static void Multiplication(double firstNum, double secondNum)
        {
            double multiNum = firstNum * secondNum;
            Console.WriteLine("Multiplication is: {0}", multiNum);
        }

        public static void Division(double firstNum, double secondNum)
        {
            double diviNum = firstNum / secondNum;
            Console.WriteLine("Division is: {0}", diviNum);
        }

       

        static void Main()
        {
            //Instatiation of delgate objects

            MathDelegate addDel, subDel, multiDel, divideDel;

            //Creation of Delegates
            addDel = new MathDelegate(Add);
            subDel = new MathDelegate(Subtract);
            multiDel = new MathDelegate(Multiplication);
            divideDel = new MathDelegate(Division);

            Console.WriteLine("----Gathering Numbers----");
            Console.WriteLine("Enter a number above 0 or enter -1 to close the application... ");
            Console.WriteLine("Please enter the first number: ");
            double firstNum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the second number: ");
            double secondNum = Convert.ToDouble(Console.ReadLine());

            //To exit application
            if (firstNum == -1)
            {
                Environment.Exit(-1);
            }

            //addDel(firstNum, secondNum);
            //subDel(firstNum, secondNum);
            //multiDel(firstNum, secondNum);
            // divideDel(firstNum, secondNum);
            // Console.ReadKey();
            
            //multicasting delegates
            Console.WriteLine("----This is the multicasted delegate----");
            multiCastDel(addDel, firstNum, secondNum);
            multiCastDel(subDel, firstNum, secondNum);
            multiCastDel(multiDel, firstNum, secondNum);
            multiCastDel(divideDel, firstNum, secondNum);

        }

        public static void multiCastDel(MathDelegate md, double numOne, double numTwo)
        {
            md(numOne, numTwo);
        }
        
    }
}
