using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ZubkovaMG.Sprint3.Task2.V10.Lib
{
    public class DataService : ISprint3Task2V10
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double multiplySeries = 1;
            int k = startValue;

            do
            {
                multiplySeries *= (Math.Pow(value, k) + (1.0 / (k + 1)));
                k++;
            } while (k <= stopValue);

            return Math.Round(multiplySeries, 3);
        }
    }
}