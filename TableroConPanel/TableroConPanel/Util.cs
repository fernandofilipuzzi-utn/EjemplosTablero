using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TableroConPanel
{
    class Util
    {
        static public int Columnas { get; set; } = 5;
        static public int Renglones { get; set; } = 3;

        /// <summary>
        /// conversión de celdas a filas y columnas
        /// </summary>
        /// <param name="cel"></param>
        /// <param name="fila"></param>
        /// <param name="columna"></param>
        static public void CellToFilaColumna(int cel, ref int fila, ref int columna)
        {
            fila = (cel - 1) / Columnas;
            columna = (cel - 1) % Columnas;
        }

        static public int FilaColumnaToCell(int fila, int columna)
        {
            return fila* Columnas + columna;
        }

        /// <summary>
        /// conversión de filas,columnas a y,x en pixeles
        /// </summary>
        /// <param name="fila"></param>
        /// <param name="columna"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="ancho"></param>
        /// <param name="alto"></param>
        static public void FilaColumnaToXY(int fila, int columna,ref int x, ref int y, int ancho, int alto)
        {
            x = ancho * columna;
            y = alto * fila;
        }
    }
}
