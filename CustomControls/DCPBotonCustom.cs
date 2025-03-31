﻿using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace CruzPatinoDiego_Practica2U2__Boton.CustomControls
{
    public class BotonCustomHilos : Button
    {
        //Bordes
        private int borderSize = 20;
        private int borderRadius = 40;
        private Color borderColor = Color.BlueViolet;

        [Category("Apariencia")]
        public int BorderSize { get => borderSize; set => borderSize = value; }
        [Category("Apariencia")]
        public int BorderRadius { get => borderRadius; set => borderRadius = value; }
        [Category("Apariencia")]
        public Color BorderColor { get => borderColor; set => borderColor = value; }

        //Constructor
        public BotonCustomHilos()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(250, 90);
            this.BackColor = Color.SkyBlue; //color boton 
            this.ForeColor = Color.Red; //color fuente 
        }

        //Metodos
        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectBorder = new RectangleF(1, 1, this.Width - 0.8F, this.Height - 1);

            if (borderRadius > 2)//Boton Rodeado
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - 1F))
                using (Pen penSurface = new Pen(this.Parent.BackColor, 2))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    //Superficie del botón
                    this.Region = new Region(pathSurface);
                    //Borde de superficie dramática para resultado HD
                    pevent.Graphics.DrawPath(penSurface, pathSurface);

                    //Borde de botón
                    if (borderSize >= 1)
                        //draw control  border
                        pevent.Graphics.DrawPath(penBorder, pathBorder);

                }
            }
            else//Botón normal
            {   //Superficie del botón
                this.Region = new Region(rectSurface);
                //Bode de botón
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }
}
