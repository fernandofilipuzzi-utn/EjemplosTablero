using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TableroConPanel
{
    class Util
    {
        static public int columnas = 5;
        static public int renglones = 3;

        static public void cellToxy(int cel, ref int x, ref int y)
        {
            x = (cel - 1) % columnas;
            y = (cel - 1) / columnas;
        }
    }
}
