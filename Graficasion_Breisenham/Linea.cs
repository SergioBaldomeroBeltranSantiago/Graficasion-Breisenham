using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graficasion_Breisenham
{
    public partial class Linea : Form
    {

        public int dibujar = 0;

        public Linea()
        {
            InitializeComponent();
            lb_Escala.Text = "Escala: x" + trb_Escala.Value;
        }

        private void Dibujasion_Paint(object sender, PaintEventArgs e)
        {
            Graphics objeto_grafico = e.Graphics;
            Pen objeto_pluma = new Pen(Color.Black, 1);
            switch (dibujar)
            {
                case 0:
                    objeto_grafico.DrawLine(objeto_pluma, 0, Dibujasion.Height / 2, Dibujasion.Width, Dibujasion.Height / 2);
                    objeto_grafico.DrawLine(objeto_pluma, Dibujasion.Width / 2, 0, Dibujasion.Width / 2, Dibujasion.Height);
                    break;
                default:
                    int witdh = Dibujasion.Width / 2;
                    int height = Dibujasion.Height / 2;
                    objeto_grafico.DrawLine(objeto_pluma, 0, Dibujasion.Height / 2, Dibujasion.Width, Dibujasion.Height / 2);
                    objeto_grafico.DrawLine(objeto_pluma, Dibujasion.Width / 2, 0, Dibujasion.Width / 2, Dibujasion.Height);
                    Breisenham.lineaEscalaN(objeto_grafico, Color.Purple, (int)num_x1.Value, (int)num_y1.Value, (int)num_x2.Value, (int)num_y2.Value, trb_Escala.Value, witdh, height);
                    break;
            }
        }

        private void trb_Escala_Scroll(object sender, EventArgs e)
        {
            lb_Escala.Text = "Escala: x" + trb_Escala.Value;
        }

        private void btn_Dibujar_Click(object sender, EventArgs e)
        {
            dibujar = 1;
            Dibujasion.Invalidate();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            dibujar = 0;
            trb_Escala.Value = 1;
            num_x1.Value = 0;
            num_y1.Value = 0;
            num_x2.Value = 0;
            num_y2.Value = 0;
            lb_Escala.Text = "Escala: x" + trb_Escala.Value;
            Dibujasion.Invalidate();
        }
    }
}
