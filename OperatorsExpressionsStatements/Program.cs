using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Baseline set of operators/keywords ---basic commands Syntax Rules


//Expression- (operators(verbs)/operands(nouns))is made up of combinations of operands which are strings, variables, objects like the cosole class itself. Operators are built in the application which you must memorize
//Operators- addition operators, string concatination operator, all the assignment operators
//use expressions to create statements(complete thoughts)which are the actions an application are express to the compiler and ultimately to the .net runtime which execute the applications.
//parsing
// x + y; is not a valid statement, a syntactical mistakes that create a red squiggly line
//lesson for bigenners is there is a proper syntax, just like there is a proper grammar in the english language
namespace OperatorsExpressionsStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable declaration
            int x, y, a, b;

            // Assignment operator
            x = 3;
            y = 2;
            a = 1;
            b = 0;

            // There are many mathematical operators ...

            // Addition operator
            x = 3 + 4;

            // Subtraction operator
            x = 4 - 3;

            // Multiplication operator
            x = 10 * 5;

            // Division operator
            x = 10 / 5;

            // Order of operations using parenthesis
            x = (x + y) * (a - b);

            //There are many operators used to evaluate values ...

            // Equality operator
            if (x == y)  // "==" is equal to x and y 
                //"if" equate to either true or false results
            {

            }

            // Greater than operator
            if (x > y)
            {

            }

            // Less than operator
            if (x < y)
            {

            }
            
            // Greater or equal to operator
            if (x >= y)
            {

            }

            // Less than or equal to operator
            if (x <= y)
            {

            }

            //There are two "conditional" operators as well that can
            // be used to expand / enhace an evaluation...
            // ... and they can be combined together multiple times.

            // Conditional And operator ...
            if ((x > y) && (a > b))
            {

            }

            // Conditional OR operator ...
            if ((x > y) || (a > b))
            {

            }

            // Also, here's the in-line conditional operator we
            // learned about in the previous lesson ...
            string message = (x == 1) ? "Car" : "Boat"; ////if its true then 1st value which is "Car" if false then 2nd value "Boat" then assigning to "message" variable's value

            // Member access and Method invocation
            Console.WriteLine("Hi"); //"Console" is a class,classes are containers for "WriteLine" which is a method
                                     //"." dot/period is a member accessor operator, is the way to access a member method or a class or an object by using "." or the "period"
                                     //"()" a method invocation operator....invoking a method called "WriteLine"
                                     //";" is an end of line character
        }
    }
}