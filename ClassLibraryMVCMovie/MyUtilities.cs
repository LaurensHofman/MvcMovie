using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ClassLibraryMVCMovie
{
    public class MyUtilities
    {
        public const int STANDARD_VALUE_MIN = 0,
            STANDARD_VALUE_MAX = 1;

        public static int randomNumber()
        {
            return randomNumber(STANDARD_VALUE_MIN, STANDARD_VALUE_MAX);
        }

        public static int randomNumber(int minimum, int maximum)
        {
            int returnValue = 41267845;

            int aidValue = 0;

            if (minimum > maximum)
            {
                aidValue = minimum;
                minimum = maximum;
                maximum = aidValue;

                Console.Beep();
            }
            
            Random random = new Random();
            returnValue = random.Next(minimum, (maximum + 1) );

            return returnValue;
        }

        public static Color renderRandomColor()
        {
            Color newColor = Color.FromArgb(randomNumber(0, 255), randomNumber(0, 255), randomNumber(0, 255));

            return newColor;
        }

        public static string convertIntToHex(int integer)
        {
            return integer.ToString("X"); //dit geeft een hexadecimale waarde ( .ToString("X") )
        }

        public static string convertColorToHex(Color color)
        {
            int minimumValue = 150;

            return convertIntToHex(color.R < minimumValue ? minimumValue : color.R) +
                convertIntToHex(color.G < minimumValue ? minimumValue : color.G) +
                convertIntToHex(color.B < minimumValue ? minimumValue : color.B);
            
        }
    }
}
