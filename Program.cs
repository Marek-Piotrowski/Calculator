
int user;
bool goodIndex = true;





Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Welcome!\nThis is a simple calculator.\n");
Console.WriteLine("===========================================================\n\n");
Console.ResetColor();

do
{
    Console.WriteLine("MENU:");
    Console.WriteLine("1 -  Addition");
    Console.WriteLine("2 -  Subtraction");
    Console.WriteLine("3 -  Division");
    Console.WriteLine("4 -  Multiplication");
    Console.WriteLine("0 -  Exit ");
    Console.WriteLine("\n\nPlease enter a number between 1 - 4 to choose a function or press 0 to exit ");


    try
    {

        user = int.Parse(Console.ReadLine());


        switch (user)
        {
            case 0:
                Console.WriteLine("Goodbye.");
                goodIndex = false;
                break;
            case 1:
                Addition();
                break;
            case 2:
                Subtraction();
                break;
            case 3:
                Division();
                break;
            case 4:
                Multiplication();
                break;
            default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter a number between 1 - 4 to choose a function or press 0 to exit\n\n");
                Console.WriteLine("===========================================================\n\n");
                Console.ResetColor();
                break;
        }
    }
    catch (Exception ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Only numbers allowed. \nPlease enter a number between 1 - 4 or press 0 to exit\n\n");
        Console.WriteLine("===========================================================\n\n");
        Console.ResetColor();
    };

}
while (goodIndex);
Console.WriteLine("Program closed");

// ===============================    Functions   =============================

// Add up 2 numbers

static void Addition()
{
    double sum;
    string num1;
    string num2;

    try
    {
        double userNumber1;
        double userNumber2;

        Console.WriteLine("Please enter 2 numbers to get them sum up.\nFor decimal numbers use period as a separator.");
        Console.WriteLine("First number: ");
        num1 = Console.ReadLine();
        if (num1.Contains(','))
        {
            string newNum1 = num1.Replace(',', '.');
            userNumber1 = double.Parse(newNum1);

        }
        else
        {
            userNumber1 = double.Parse(num1);
        }

      
        Console.WriteLine("\nPlus \n");
        Console.WriteLine("Second number: ");
        num2 = Console.ReadLine();
        // comma checking
        if (num2.Contains(','))
        {
            string newNum2 = num2.Replace(',', '.');
            userNumber2 = double.Parse(newNum2);

        }
        else
        {
            userNumber2 = double.Parse(num2);
        }
        // display result
        sum = userNumber1 + userNumber2;
        
        

        Console.WriteLine("\nEquals: " + sum);
        Console.WriteLine("\n===========================================================\n");


    }
    catch (Exception ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Only numbers allowed. Use period sign for decimal numbers.");
        Console.WriteLine("===========================================================\n\n");
        Console.ResetColor();
    };

}
// Subtract 2 numbers
static void Subtraction()
{
    double sum;
    string num1;
    string num2;

    try
    {
        double userNumber1;
        double userNumber2;

        Console.WriteLine("Please enter 2 numbers to get them subtract.\nFor decimal numbers use period as a separator.");
        Console.WriteLine("First number: ");
        num1 = Console.ReadLine();
        if (num1.Contains(','))
        {
            string newNum1 = num1.Replace(',', '.');
            userNumber1 = double.Parse(newNum1);

        }
        else
        {
            userNumber1 = double.Parse(num1);
        }


        Console.WriteLine("\nMinus \n");
        Console.WriteLine("Second number: ");
        num2 = Console.ReadLine();
        // comma checking
        if (num2.Contains(','))
        {
            string newNum2 = num2.Replace(',', '.');
            userNumber2 = double.Parse(newNum2);

        }
        else
        {
            userNumber2 = double.Parse(num2);
        }
        // display result
        sum = userNumber1 - userNumber2;
        // Round up to 2 decimals if needed
        //sum = Math.Round(sum, 2);

        Console.WriteLine("\nEquals: " + sum);
        Console.WriteLine("\n===========================================================\n");


    }
    catch (Exception ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Only numbers allowed. Use period sign for decimal numbers.");
        Console.WriteLine("===========================================================\n\n");
        Console.ResetColor();
    };

}
// Divide 2 numbers
static void Division()
{
    double sum;
    string num1;
    string num2;

    try
    {
        double userNumber1;
        double userNumber2;

        Console.WriteLine("Please enter 2 numbers to get them divided.\nFor decimal numbers use period as a separator.");
        Console.WriteLine("First number: ");
        num1 = Console.ReadLine();
        if (num1.Contains(','))
        {
            string newNum1 = num1.Replace(',', '.');
            userNumber1 = double.Parse(newNum1);

        }
        else
        {
            userNumber1 = double.Parse(num1);
        }


        Console.WriteLine("\nDivided by: \n");
        Console.WriteLine("Second number: ");
        num2 = Console.ReadLine();
        // comma checking
        if (num2.Contains(','))
        {
            string newNum2 = num2.Replace(',', '.');
            userNumber2 = double.Parse(newNum2);

        }
        else
        {
            
                userNumber2 = double.Parse(num2);
                if (userNumber2 == 0)
                {
                    throw new DivideByZeroException("Division by zero not allowed\n\n");
                }
   
        }
        // display result
        sum = userNumber1 / userNumber2;
        // Round up to 2 decimals if needed
        //sum = Math.Round(sum, 2);

        Console.WriteLine("\nEquals: " + sum);
        Console.WriteLine("\n===========================================================\n");


    }
    catch (DivideByZeroException e)
    {
            Console.WriteLine(e.Message);
    }
    catch (Exception ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Only numbers allowed. Use period sign for decimal numbers.");
        Console.WriteLine("===========================================================\n\n");
        Console.ResetColor();
    };

}
// Multiplicate 2 numbers
static void Multiplication()
{
    double sum;
    string num1;
    string num2;

    try
    {
        double userNumber1;
        double userNumber2;

        Console.WriteLine("Please enter 2 numbers to multiplicate them.\nFor decimal numbers use period as a separator.");
        Console.WriteLine("First number: ");
        num1 = Console.ReadLine();
        if (num1.Contains(','))
        {
            string newNum1 = num1.Replace(',', '.');
            userNumber1 = double.Parse(newNum1);

        }
        else
        {
            userNumber1 = double.Parse(num1);
        }


        Console.WriteLine("\nMultiplicate by: \n");
        Console.WriteLine("Second number: ");
        num2 = Console.ReadLine();
        // comma checking
        if (num2.Contains(','))
        {
            string newNum2 = num2.Replace(',', '.');
            userNumber2 = double.Parse(newNum2);

        }
        else
        {

            userNumber2 = double.Parse(num2);

        }
        // display result
        sum = userNumber1 * userNumber2;
        // Round up to 2 decimals if needed
        //sum = Math.Round(sum, 2);

        Console.WriteLine("\nEquals: " + sum);
        Console.WriteLine("\n===========================================================\n");


    }
    catch (Exception ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Only numbers allowed. Use period sign for decimal numbers.");
        Console.WriteLine("===========================================================\n\n");
        Console.ResetColor();
    };

}

