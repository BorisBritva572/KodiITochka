using System;

namespace SimpleTask
{
    public static class SimpleTask
    {
        /// <summary>
        /// Container With Most Water
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static int MaxArea(int[] height)
        {
            if (height == null) throw new ArgumentNullException("height is null");

            int left = 0; //Левая граница ёмкости
            int right = height.Length - 1; //Правая граница ёмкости
            int V = 0; //Искомый объём
            while(left < right)
            {
                V = Math.Max(V, Math.Min(height[left], height[right]) * (right - left));
                //Будем двигать границу с наименьшей высотой, иначе, объём жидкости будет только уменьшаться
                if (height[left] < height[right]) left++;
                else right--;
            }
            return V;
        }
    }
}
