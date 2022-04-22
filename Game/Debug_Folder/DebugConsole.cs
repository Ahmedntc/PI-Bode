using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#pragma warning disable IDE0079 // Remover a supressão desnecessária // é sério isso?
#pragma warning disable IDE1006 // Estilos de Nomenclatura

namespace Game
{
    public partial class DebugConsole : Form
    {

        public DebugConsole()
        {
            InitializeComponent();
        }

        
        public double Angle_toRadian(float angle)
        {
            return (Math.PI / 180) * angle;
        }


        public Image Rotate(Bitmap target, float angle)
        {

            if (target == null)
                return null;

            // descobre as dimensões
            int width;
            int height;
            
            double radian = Angle_toRadian( angle <= 0.0 ? -angle : angle);
    
            double sin = Math.Sin(radian);
            double cos = Math.Cos(radian);

            // calculamos a largura nova
            int minus = target.Width - (int)(cos * target.Width);
            int bonus = (int)(sin * target.Height);
            int diffw = bonus - minus;

            // calculamos a altura nova
            minus = target.Height - (int)(cos * target.Height);
            bonus = (int)(sin * target.Width);
            int diffh = bonus - minus;

            width = target.Width + diffw;
            height = target.Height + diffh;

            Image result = new Bitmap(width, height);

            using (Graphics gfx = Graphics.FromImage(result))
            {
                PointF point = new PointF(width/2, height/2);
                gfx.TranslateTransform(point.X, point.Y, System.Drawing.Drawing2D.MatrixOrder.Prepend);
                gfx.RotateTransform( angle );
                gfx.TranslateTransform(-target.Width/2, -target.Height/2, System.Drawing.Drawing2D.MatrixOrder.Prepend);
                gfx.DrawImage(target, new PointF());
                gfx.Dispose();
            }
            
            return result;
        }


        public void Main(int c)
        {
            // sen ( pi * (x / w)) * (h / c) + h

            // variáveis
            int width = 100;
            int height = 150;
            int pWidth = this.pnlCards.Width;
            int pHeight = this.pnlCards.Height;
            int count = c;

            // espaço de sobra
            double dispWidth = pWidth - width * count;


            // centralizamos as cartas
            double betweenWidth = dispWidth / (count + 1);

            // para apertar as cartas
            double auxWidth = count <= 1 ? 0 : (300 / count);

            // adicionamos as cartas
            Global.Card[] test_cards = Global.cards;
            Bitmap[] cards = new Bitmap[count];
            for (int i = 0; i < count; i++)
            {
                cards[i] = new Bitmap(width, height);
                var p = test_cards[i].get_Panel(width, height);    
                p.panel.DrawToBitmap(cards[i], new Rectangle(0, 0, width, height));
            }




            // preparamos as variáveis da fórmula da posição
            // y = sin( pi * (x/w)) * (h / c) + h;

            double w1 = pWidth + 20;
            double c1 = 1.5;
            double h = pHeight - height - 20;

            double x = auxWidth/2;
            double y;


            // preparamos as variáveis da fórmula do ângulo
            // a = - (x / w) * v + c;
            double w2 = pWidth;
            double c2 =-30;
            double v  = 60;

            for (int i = 0; i < count; i++)
            {
                x += betweenWidth;

                // extraimos o ângulo
                float a = (float)(((x + width / 2) / w2) * v + c2);

                // desenhamos o cartão
                Image rotated = Rotate(cards[i], a);

                // extraimos o Y
                y = Math.Sin(-Math.PI * ((x + (rotated.Width / 2)) / w1)) * (h / c1) + h;
                
                Graphics phandle = pnlCards.CreateGraphics();
                phandle.DrawImage(rotated, (int)x, (int)y);

                // movimentamos o X
                x += width - (auxWidth * 2 / count);
            }
        }
    }
}
