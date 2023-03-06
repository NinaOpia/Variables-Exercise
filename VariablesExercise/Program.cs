namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string dogName; //Declaration Syntax

            dogName = "Rex"; //Initialization

            int dogAge = 5; //Declaration and Initialization Syntax

            char firstInitial = 'R';

            bool isHungry = true;

            double dogWeight = 54.3;

            decimal dogHeight = 14.7m;

            Console.WriteLine ($"My dog's name is {dogName} and he is {dogAge} years old.");

            Console.WriteLine ($"It is {isHungry} that he is always hungry. He is {dogWeight} lbs and is {dogHeight} inches tall.");

        }
    }
}
