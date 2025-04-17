namespace _01.ProblemOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberN = int.Parse(Console.ReadLine());

            if (numberN <= 0) 
            {
                Console.WriteLine(0);
                return;
            }
            
            int comulativeWaterConsumption = 0;

            for(int i = 1; i <= numberN; i++) 
            {
                int dailyConsumption = int.Parse(Console.ReadLine());
                comulativeWaterConsumption += dailyConsumption;
                Console.WriteLine(comulativeWaterConsumption);
            }

        }
    }
}