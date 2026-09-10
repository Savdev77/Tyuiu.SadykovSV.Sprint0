namespace Tyuiu.SadykovSV.Sprint0.Task6.V0.Lib
{
    public class DataService
    {
        public static object AdditionArray(int[] numbers)
        {
            var total = 0;
            for (var i=0; i <numbers.Length; i++)
            {
                total +=numbers[i];
            }
            return total;
        }
        public static object SubtractionArray(int[] numbers)
        {
            var total = 0;
            for (var i = 0; i < numbers.Length; i++)
            {
                total-=numbers[i];
            }
            return total;
        }
        public static object MultiplucationArray(int[] numbers)
        {
            var total = 1;
            int i = 0;
            do
            {
                total = total * numbers[i];
                i++;
            }
            while (i < numbers.Length);
            return total;
        }
    }
}
