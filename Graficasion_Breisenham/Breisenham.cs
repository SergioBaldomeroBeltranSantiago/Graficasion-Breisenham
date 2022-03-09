using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Graficasion_Breisenham
{
    class Breisenham
    {
        public static void putPixel(Graphics objeto_grafico, Color c, int x, int y) {
            Bitmap objeto_bitmap = new Bitmap(1, 1);
            objeto_bitmap.SetPixel(0, 0, c);
            objeto_grafico.DrawImageUnscaled(objeto_bitmap, x, y);
        }

        public static void lineaBresenham(Graphics objeto_grafico, Color c, int x1, int y1, int x2, int y2)
        {
            if (x1 > x2)
            {
                lineaBresenham(objeto_grafico, c, x2, y2, x1, y1);
                return;
            }
            int slope, d;
            int dx = x2 - x1, dy = y2 - y1, y = y1;
            if (dy < 0)
            {
                slope = -1;
                dy *= -1;
            }
            else
            {
                slope = 1;
            }
            int incE = 2 * dy;
            int incNE = (2 * dy) - (2 * dx);
            d = (2 * dy) - dx;

            for (int x = x1; x <= x2; x++)
            {
                putPixel(objeto_grafico, c, x, y);
                if (d <= 0)
                {
                    d += incE;
                }
                else
                {
                    d += incNE;
                    y += slope;
                }
            }
        }

        public static void circulo(Graphics objeto_grafico, Pen objeto_pluma, int x, int y, int r) {
            int x1 = 0;
            int y1 = r;
            int d = 3 - (2 * r);
            while (x1 <= y1) {
                objeto_grafico.DrawRectangle(objeto_pluma, x + x1, y + y1, 1, 1);
                objeto_grafico.DrawRectangle(objeto_pluma, x - x1, y + y1, 1, 1);
                objeto_grafico.DrawRectangle(objeto_pluma, x + x1, y - y1, 1, 1);
                objeto_grafico.DrawRectangle(objeto_pluma, x - x1, y - y1, 1, 1);
                objeto_grafico.DrawRectangle(objeto_pluma, x + y1, y + x1, 1, 1);
                objeto_grafico.DrawRectangle(objeto_pluma, x - y1, y + x1, 1, 1);
                objeto_grafico.DrawRectangle(objeto_pluma, x + y1, y - x1, 1, 1);
                objeto_grafico.DrawRectangle(objeto_pluma, x - y1, y - x1, 1, 1);
                if (d < 0)
                {
                    d += (4 * x1) + 6;
                }
                else {
                    d += (4 * (x1 - y1)) + 10;
                    y1--;
                }
                x1++;
            }
        }

        public static void lineaEscalaN(Graphics objeto_grafico, Color c, int x1, int y1, int x2, int y2, int n, int witdh, int height) {
            x1 *= n;
            x2 *= n;
            x2 += n;
            y1 *= n;
            y2 *= n;
            x1 = witdh + x1;
            x2 = witdh + x2;
            y1 = height + (-1 * y1);
            y2 = height + (-1 * y2);
            for (int i = 0; i < n; i++) {
                lineaBresenham(objeto_grafico, c, x1, y1 + i, x2, y2 + i);
            }
        }

        public static void circuloEscalaN(Graphics objeto_grafico, Pen objeto_pluma, int x, int y, int r, int n, int witdh, int height) {
            x *= n;
            y *= n;
            r *= n;
            x = witdh + x;
            y = height + (-1 * y);
            for (int i = 0; i < n; i++) {
                circulo(objeto_grafico, objeto_pluma, x, y, r + i);
            }
        }
    }
}
