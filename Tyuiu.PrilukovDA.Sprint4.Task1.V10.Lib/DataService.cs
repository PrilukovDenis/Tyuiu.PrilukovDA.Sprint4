using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.PrilukovDA.Sprint4.Task1.V10.Lib
{
    public class DataService : ISprint4Task1V10
    {
        public int Calculate(int[] array)
        {
            int product = 1;

            foreach (int num in array)
            {
                if (num % 2 != 0) 
                {
                    product *= num;
                }
            }

            return product;
        }
    }
}
