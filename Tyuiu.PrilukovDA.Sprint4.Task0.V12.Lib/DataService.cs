using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.PrilukovDA.Sprint4.Task0.V12.Lib
{
    public class DataService : ISprint4Task0V12
    {
        public int GetMultEvenArrEl(int[] array)
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
