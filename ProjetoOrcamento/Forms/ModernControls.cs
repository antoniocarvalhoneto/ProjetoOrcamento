using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ProjetoOrcamento.Forms
{
    internal sealed class ModernPanel : Panel
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int CornerRadius { get; set; } = 12;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color BorderColor { get; set; } = ColorTranslator.FromHtml("#D1D5DB");

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color FillColor { get; set; } = Color.White;

        public ModernPanel()
        {
            SetStyle(
                ControlStyles.AllPaintingInWmPaint
                | ControlStyles.OptimizedDoubleBuffer
                | ControlStyles.ResizeRedraw
                | ControlStyles.UserPaint,
                true);
            BackColor = Color.Transparent;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (Width <= 0 || Height <= 0)
                return;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            var bounds = new Rectangle(0, 0, Width - 1, Height - 1);

            using var path = ModernControlRenderer.CreateRoundedRectangle(bounds, CornerRadius);
            using var fill = new SolidBrush(FillColor);
            using var border = new Pen(BorderColor);

            e.Graphics.FillPath(fill, path);
            e.Graphics.DrawPath(border, path);
        }
    }

    internal sealed class ModernButton : Button
    {
        private Color _normalBackColor = ColorTranslator.FromHtml("#2563EB");

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int CornerRadius { get; set; } = 10;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color NormalBackColor
        {
            get => _normalBackColor;
            set
            {
                _normalBackColor = value;
                BackColor = value;
                Invalidate();
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color HoverBackColor { get; set; } = ColorTranslator.FromHtml("#1E40AF");

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color PressedBackColor { get; set; } = ColorTranslator.FromHtml("#1D4ED8");

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color BorderColor { get; set; } = Color.Transparent;

        public ModernButton()
        {
            SetStyle(
                ControlStyles.AllPaintingInWmPaint
                | ControlStyles.OptimizedDoubleBuffer
                | ControlStyles.ResizeRedraw
                | ControlStyles.UserPaint,
                true);

            Cursor = Cursors.Hand;
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            ForeColor = Color.White;
            Padding = new Padding(14, 0, 14, 0);
            TextAlign = ContentAlignment.MiddleCenter;
            UseVisualStyleBackColor = false;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);

            if (Enabled)
                BackColor = HoverBackColor;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            BackColor = NormalBackColor;
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);

            if (Enabled)
                BackColor = PressedBackColor;
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);

            if (Enabled)
                BackColor = ClientRectangle.Contains(PointToClient(Cursor.Position))
                    ? HoverBackColor
                    : NormalBackColor;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            if (Width <= 0 || Height <= 0)
                return;

            using var path = ModernControlRenderer.CreateRoundedRectangle(
                new Rectangle(0, 0, Width, Height),
                CornerRadius);
            Region?.Dispose();
            Region = new Region(path);
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            if (Width <= 0 || Height <= 0)
                return;

            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            var bounds = new Rectangle(0, 0, Width - 1, Height - 1);
            var fillColor = Enabled ? BackColor : ColorTranslator.FromHtml("#CBD5E1");
            var textColor = Enabled ? ForeColor : ColorTranslator.FromHtml("#64748B");

            using var path = ModernControlRenderer.CreateRoundedRectangle(bounds, CornerRadius);
            using var fill = new SolidBrush(fillColor);
            using var border = new Pen(BorderColor);

            pevent.Graphics.FillPath(fill, path);

            if (BorderColor != Color.Transparent)
                pevent.Graphics.DrawPath(border, path);

            TextRenderer.DrawText(
                pevent.Graphics,
                Text,
                Font,
                ClientRectangle,
                textColor,
                TextFormatFlags.HorizontalCenter
                | TextFormatFlags.VerticalCenter
                | TextFormatFlags.EndEllipsis);
        }
    }

    internal static class ModernControlRenderer
    {
        public static GraphicsPath CreateRoundedRectangle(Rectangle bounds, int radius)
        {
            var path = new GraphicsPath();
            var diameter = Math.Max(1, Math.Min(radius * 2, Math.Min(bounds.Width, bounds.Height)));
            var arc = new Rectangle(bounds.Location, new Size(diameter, diameter));

            path.AddArc(arc, 180, 90);

            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);

            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }
    }
}
