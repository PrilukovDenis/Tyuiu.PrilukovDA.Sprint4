using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.PrilukovDA.Sprint4.Task2.V25.Lib
{
    public class DataService : ISprint4Task2V25
    {
        public int Calculate(int[] array)
        {
            int product = 1;

            foreach (int num in array)
            {
                if (num % 2 == 0)
                {
                    product *= num;
                }
            }

            return product;
        }
    }
}
