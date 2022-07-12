
using xUnitCalculator2;

Console.WriteLine("Calculator!");
//we will have a case and break  for user to choose 

Operations op = new Operations();
Meny();






void Substraction(int value1, int value2)

{

    Console.WriteLine($" The sum of result is {value1 - value2}");
}



void Multiplication(int value1, int value2)

{

    Console.WriteLine($" The result is {value1 * value2}");
}



void Division(int value1, int value2)

{
    if (value1 == 0 || value2 == 0)
    {
        Console.WriteLine("you cannot devide by zero");

    }
    else
    {
        Console.WriteLine($" The result is {value1 / value2}");
    }

}

void Modulus(int value1, int value2)

{

    Console.WriteLine($" The result is {value1 % value2}");
}





// i dont need to call the methods here no more i will call them in the Switch statements
//Adition(value1, value2);
//Multiplication(value1, value2);
//Division(value1, value2);
//Modulus(value1, value2);

void Meny()
{
    bool menu = true;
    while (menu)
    {
        Console.WriteLine("Enter 0 to End the programme");

        Console.WriteLine("Enter 1 for Addition");

        Console.WriteLine("Enter 2 for Substraction");

        Console.WriteLine("Enter 3 for Multiplication");

        Console.WriteLine("Enter 4 for Division");

        Console.WriteLine("Enter 5 for Modulus");

        Console.WriteLine("Enter 6 for Addition with multiple numbers");

        Console.WriteLine("Enter 7 for Substraction with multiple numbers");

        string inputchoice = Console.ReadLine();



        switch (inputchoice)
        {
            case "0":
                menu = false;
                break;


            case "1":

                Console.WriteLine("Enter number 1");
                int additionvalue1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter number 2");
                int additionvalue2 = Convert.ToInt32(Console.ReadLine());
                op.Adition(additionvalue1, additionvalue2);

                break;


            case "2":
                Console.WriteLine("Enter number 1");
                int substractionvalue1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter number 2");
                int substractionvalue2 = Convert.ToInt32(Console.ReadLine());
                Substraction(substractionvalue1, substractionvalue2);
                break;


            case "3":

                Console.WriteLine("Enter number 1");
                int multiplicationvalue1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter number 2");
                int multiplicationvalue2 = Convert.ToInt32(Console.ReadLine());
                Multiplication(multiplicationvalue1, multiplicationvalue2);
                break;



            case "4":

                Console.WriteLine("Enter number 1");
                int divisionvalue1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter number 2");
                int divisionvalue2 = Convert.ToInt32(Console.ReadLine());
                Division(divisionvalue1, divisionvalue2);
                break;


            case "5":
                Console.WriteLine("Enter number 1");
                int modulusvalue1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter number 2");
                int modulusvalue2 = Convert.ToInt32(Console.ReadLine());
                Modulus(modulusvalue1, modulusvalue2);
                break;

            case "6":

                Console.WriteLine("Enter multiple numbers separated by blank space");
                string strValues = Console.ReadLine();
                string[] values = strValues.Split(' ');
                int[] intValues = new int[values.Length];
                for (int i = 0; i < values.Length; i++)
                {
                    intValues[i] = Convert.ToInt32(values[i]); 
                }
                op.Adition(intValues);

                break;

            case "7":

                Console.WriteLine("Enter multiple numbers separated by blank space");
                string str2Values = Console.ReadLine();
                string[] values2 = str2Values.Split(' ');
                int [] int2Values = new int[values2.Length]; 
                
                for (int i = 0; i < values2.Length; i++)
                {
                    int2Values[i] = Convert.ToInt32(values2[i]);
                }
                op.Substraction(int2Values);

                break;


            default:
                Console.WriteLine("invalid calculation");
                break;
        }


    }



}
