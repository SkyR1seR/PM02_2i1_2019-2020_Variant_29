using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pifagor
{
    public static class Pif
    {
        /// <summary>
        /// Метод вывода Пифагоровых чисел из промежутка
        /// </summary>
        /// <param name="x">Начало промежутка</param>
        /// <param name="y">Конец промежутка</param>
        /// <returns></returns>
        public static string Number(int x, int y)
        {
            string row = "";
            {
                for (int c = x; c <= y; ++c)
                    for (int b = x; b <= c; ++b)
                        for (int a = x; a <= b; ++a)
                            if (a * a + b * b == c * c)  row += (a,b,c) + ", ";
            }
            return row;
        }
    }
}
