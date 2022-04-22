namespace program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Week 3 assignment!
            // LAB ONE
             int num, index = 0;
            
            Console.WriteLine("Enter any number of your choice: ");
            num = Convert.ToInt32(Console.ReadLine());

            for(int i = 2; i <= num/2; i++){
                if (num % i == 0)
                {
                    index = 1;
                    break;
                }
            }

            if (index == 0)
            {
                Console.WriteLine("This is a prime number!");
            }
            else{
                Console.WriteLine("This is not a prime number!");
            }

            // LAB TWO

            int num1, num2 = 0;
            Console.WriteLine("Enter first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            int sum = num1 + num2;

            if(sum < 100){
                Console.WriteLine("True!");
            }
            else
            {
                Console.WriteLine("False!");
            }

            // By SiriDaniels!
        

        }
    }
    
}

