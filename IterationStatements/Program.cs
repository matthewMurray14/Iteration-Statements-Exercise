using System.ComponentModel.Design;
using System.Globalization;


namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000

        static void UpToDown()
        {
            List<int> numbers = new List<int>();

            for (int numA = 0; numA <= 1000; numA++)
            {
                numbers.Add(numA);
            }
            Console.WriteLine("Going up!");

            foreach (int number in numbers)
            {
                Console.WriteLine(number + " ");
            }
            Console.WriteLine("Going down!");

            for (int numA = numbers.Count - 1; numA >= 0; numA--)
            {
                Console.WriteLine(numbers[numA] + " ");
            }
        }

    static void ByThree()
    {

            for (int index = 3; index < 999; index += 3)
                
        {
                
            Console.WriteLine(index);

        }

    }
        static void AreEqual(int uNum1, int uNum2)
        {
            if (uNum1 == uNum2)
            {
                Console.WriteLine("Yup these are equal!");
            }
            else
            {
                Console.WriteLine("These numbers are NOT equal!");
            }

        }
        static void AreEven(int uInt1)
        {
            if (uInt1 % 2 == 0)
            {
                Console.WriteLine($"{uInt1} Is even!");
            }
           else
            {
                Console.WriteLine($"{uInt1} is NOT even.");
            }
        }

        static void PositiveNegative(int uPorE)
        {
            if (uPorE < 0)
            {
                Console.WriteLine($"{uPorE}, is negative.");
            }
            else
            {
                Console.WriteLine($"{uPorE}, is positive.");
            }
        }

        static void CanVote(int uAge)
        {
            if (uAge >= 18)
            {
                Console.WriteLine("Great!, you are old enough to vote!");
            }
            else
            {
                Console.WriteLine("Sorry! Your are not old enough to vote.");
            }
        } 
        static void CanVoteAgain(int age)
            {

                if (age >= 18)
                {
                    Console.WriteLine("You are old enough but, is it really worth it? I mean.......");
                }
                else
                {
                    Console.WriteLine("You are not old enough and by the time you are, you'll see.");
                }
            

          }
        static void PorNcheck(int uEntForIn) //name was not intended to say that but....
        {
            if (uEntForIn >= -10 && uEntForIn <= 10)
            {
                Console.WriteLine($"{uEntForIn}, falls within the range of, -10 and 10. Congratulations! ");
            }
            
            else
            {
                Console.WriteLine($"{uEntForIn}, does not fall in the correct range.");
            }
            
             

        }
        static void ProductGetter(int uProduct)
        { 
          for(int i = 1; i <= 12; i++)
            {
                int result = uProduct * i;
                Console.WriteLine(uProduct + "x" + i + "=" + result);
            }
            
        }

        
            


        //Write a method that will print to the console numbers 3 through 999 by 3 each time -done

        //Write a method to accept two integers as parameterss and check whether they are equal or not -done

        //Write a method to check whether a given number is even or odd-done

        //Write a method to check whether a given number is positive or negative-done

        //Write a method to read the age of a candidate and determine whether they can vote. - half Done
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10

        //Write a method to display the multiplication table(from 1 to 12) of a given integer


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            int uNum1, age;
            int uNum2;
            int uInt1;
            int uPorE;
            int uAge;
            bool uAge2, isTrue;
            int uEntForN;
            int uProduct;
            var response = Console.ReadLine();





            //display numbers to 1000
            UpToDown();
            //Count by 3's
            Console.WriteLine("This is to count by 3's");
            ByThree();

            //equal or not
            Console.WriteLine("Enter your numbers to check if the are equal. Enter first number");
            uNum1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the next number.");
            uNum2 = int.Parse(Console.ReadLine());
            AreEqual(uNum1, uNum2);
            //Even or odd
            Console.WriteLine("Now, lets check to see if  a number is evan or odd.");
            uInt1 = int.Parse(Console.ReadLine());
            AreEven(uInt1);
            //Positive or Negative
            Console.WriteLine("Ok, now is a number posative or negative. Enter a number.");
            uPorE = int.Parse(Console.ReadLine()); 
            PositiveNegative(uPorE);
            //vote
            Console.WriteLine("Hey bro! Can you even vote? How old are you?");
            uAge = int.Parse(Console.ReadLine());
            CanVote(uAge);

            //range finder
            Console.WriteLine("So, next, enter a number in the range of -10 to 10 and I'll verify if it is.");
            Console.WriteLine("Enter a number.");
            uEntForN = int.Parse(Console.ReadLine());
            PorNcheck(uPorE);

            //canvote 2 using tryParse but honestly could not implement into a method

            Console.WriteLine("This is here to see if you are able to vote using TryParse");
            do
            {
                Console.WriteLine("How old are you?");
                response = Console.ReadLine();
                isTrue = int.TryParse(response, out age);
            }
            while (isTrue == false);

            CanVoteAgain(age);


            //multiplication table
           Console.WriteLine("ALright, looks to be the last one");
            Console.WriteLine("I'll display all products of any number of your choosing between 1 and 12");
            Console.WriteLine("Enter a number");
            uProduct = int.Parse(Console.ReadLine());
            Console.WriteLine("Here is the table:");
            Console.WriteLine("------------------------------------");
            ProductGetter(uProduct);
            
              
           






        }
    }
}
