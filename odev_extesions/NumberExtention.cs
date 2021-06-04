using System;

namespace odev_extesions
{
    public  static class NumberExtention
    {
        
        public static bool IsPerfectNumber(this int number)
        {
            int total = 0;
            for(int i = 1 ; i< number; i++)
            {
                if(number % i ==0)
                {
                    total += i;

                }
            }

            return number == total;

        }
    }
}
