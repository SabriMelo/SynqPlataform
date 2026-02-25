using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.ComponentModel;

namespace DeskAgentRD_v2 {
    public class PainelArredondado : Panel {

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int Radius { get; set; } = 30;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color CorBorda { get; set; } = Color.MediumSlateBlue;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int TamanhoBorda { get; set; } = 0;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color CorFundo { get; set; } = Color.FromArgb(45, 48, 55);

        public PainelArredondado() {
            this.DoubleBuffered = true;
            this.BackColor = Color.Transparent;
            this.ForeColor = Color.White;
            this.Size = new Size(250, 150);
        }
        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectBorder = new RectangleF(1, 1, this.Width - 0.8f, this.Height - 1);

            if (Radius > 1) {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, Radius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, Radius - 1F))
                using (Pen penSurface = new Pen(this.Parent.BackColor, 2))
                using (Pen penBorder = new Pen(CorBorda, TamanhoBorda)) {
                    penBorder.Alignment = PenAlignment.Inset;
                    this.Region = new Region(pathSurface);

                    using (SolidBrush brushSurface = new SolidBrush(CorFundo)) {
                        e.Graphics.FillPath(brushSurface, pathSurface);
                    }

                    if (TamanhoBorda >= 1)
                        e.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else {
                this.Region = new Region(rectSurface);
                using (SolidBrush brushSurface = new SolidBrush(CorFundo)) {
                    e.Graphics.FillRectangle(brushSurface, rectSurface);
                }
            }
        }

        private GraphicsPath GetFigurePath(RectangleF rect, float radius) {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}