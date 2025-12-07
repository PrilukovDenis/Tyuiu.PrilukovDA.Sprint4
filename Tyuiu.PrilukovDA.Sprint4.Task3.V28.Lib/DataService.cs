using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.PrilukovDA.Sprint4.Task3.V28.Lib
{
    public class DataService : ISprint4Task3V28
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetLength(0);
            int columnIndex = 3;

            int min = array[0, columnIndex]; 

            for (int i = 1; i < rows; i++)
            {
                if (array[i, columnIndex] < min)
                {
                    min = array[i, columnIndex];
                }
            }
            return min;
        }
    }
}
