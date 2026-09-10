namespace Tyuiu.SadykovSV.Sprint0.Task7.V0.Lib
{
    public class DataService
    {
        public static int[] AdditionArrays(int[] nums1, int[] nums2)
        {
            int[] result = new int[nums1.Length];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = nums1[i] + nums2[i];
            }
            return result;
        }
    }
}
