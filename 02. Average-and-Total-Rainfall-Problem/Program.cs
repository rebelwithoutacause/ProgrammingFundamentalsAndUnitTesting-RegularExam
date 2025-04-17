int[] dailyRainfallAmount = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

int startDay = int.Parse(Console.ReadLine());
int endDay = int.Parse(Console.ReadLine());

int totalRainfall = 0;
int count = 0;

for(int i = startDay; i <= endDay; i++) 
{
 totalRainfall += dailyRainfallAmount[i];
    count++;
}
double averageRainfall = (double)totalRainfall / count;

Console.WriteLine(totalRainfall);
Console.WriteLine($"{averageRainfall:F2}");