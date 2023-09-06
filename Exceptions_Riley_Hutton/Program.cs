// See https://aka.ms/new-console-template for more information

//Two float variables, and a third called result.
float myFloat = 65.4f;
float myOtherFloat = 0.0f;
float result = 0.0f;

//Creates a new random object from a range from 2 to 30
Random rand = new Random();
int myInt = rand.Next(2, 30);

//Takes the two variables as arguments and divides them.
try
{
    result = Divide(myFloat, myOtherFloat);
}
//Catch any exceptions and print to console the error Message. Then asks the user to input a floating point number other than zero.
catch (Exception e)
{
    Console.WriteLine(e.Message);
    Console.WriteLine("Please enter a number other than zero.");

    //assigns result to the Divide method again, then prints result to console.
    try
    {
        myOtherFloat = (float)Convert.ToDouble(Console.ReadLine());
        result = Divide(myFloat, myOtherFloat);
    }
    catch (Exception e2)
    {
        Console.WriteLine(e2.Message);
    }

}
//finally block that prints, "Calculations completed, with result of <result>!".
finally
{
    Console.WriteLine("Calculations completed with a result of " + result);
}
//calls CheckAge and passes through the int variable.
try
{
    CheckAge(myInt);
}
//Prints a custom error message.
catch
{
    Console.WriteLine("You are not old enough!");
}

//Method that returns a float, called Divide and takes two parameters.
static float Divide(float a, float b)
{
    //The second parameter is equal to zero, then throws a DivideByZeroException.
    if (b == 0)
    {
        throw new DivideByZeroException();
    }
    else
    {
        return a / b;
    }
}

//Method called CheckAge that has one int parameter, called age.
static void CheckAge(int age)
{
    //the parameter is greater than or equal to 17 then printsthe sentence to console.
    if (age >= 17)
    {
        Console.WriteLine($"You are {age}, you can play mature games!");
    }
    else
    {
        throw new ArgumentException();
    }
}