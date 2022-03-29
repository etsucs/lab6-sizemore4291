/**       
 *--------------------------------------------------------------------
 * 	   File name: Program.cs
 * 	Project name: Lab 6
 *--------------------------------------------------------------------
 * Author’s name and email:	 Derrick Sizemore sizemoredl@etsu.edu				
 *          Course-Section:  002
 *           Creation Date:	 24 March 2022		
 * -------------------------------------------------------------------
 */


System.Console.Write("Please enter the name of a U.S. State: ");
string state = Console.ReadLine();
int length = state.Length;

System.Console.Write($"Please enter a number between 1 and {length}: ");
int num = Convert.ToInt32(Console.ReadLine());

ShowCharacter($"{state}", num);

System.Console.WriteLine();  //Blank line//

System.Console.Write("Please enter the wholesale cost: $");
Double cost = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Please enter the markup percentage: ");
Double markup = Convert.ToDouble(Console.ReadLine());

var price = CalculateRetail(cost, markup);
System.Console.WriteLine($"Your item's wholesale cost is ${cost} with a markup of {markup}% for a total retail price of ${Math.Round(price)}.");

System.Console.WriteLine(); //Blank line//

System.Console.Write("Please enter a number to find out if it is prime: ");
int numPrime = Convert.ToInt32(Console.ReadLine());

if (isPrime(numPrime))
{
    System.Console.WriteLine($"{numPrime} is a prime number.");
}
else
{
    System.Console.WriteLine($"{numPrime} is not a prime number.");
}




static void ShowCharacter(string state, int num)
{
    System.Console.WriteLine($"The number {num} letter in {state} is: {state.ToUpper()[num-1]}.");
}

static double CalculateRetail(double cost, double markup)
{
    return cost * markup/100 + cost;    
}

static bool isPrime(int numPrime)
{
    for (int i=2; i < numPrime; i++)
    if(numPrime % 2 == 0)
    {
    return false;
    }
    return true;
}