using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kapture
{
    public partial class FrmSelect : Form
    {
        public Rectangle Selected = new Rectangle();

        private Point _down;
        private Point _up;

        public FrmSelect(Screen destination)
        {
            InitializeComponent();
            Size = destination.Bounds.Size;
            Location = destination.Bounds.Location;
        }

        private void FrmSelect_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _up = e.Location;
                Selected = new Rectangle(
                    Math.Min(_down.X, _up.X),
                    Math.Min(_down.Y, _up.Y),
                    Math.Abs(_down.X - _up.X),
                    Math.Abs(_down.Y - _up.Y));

                Invalidate();
            }
        }

        private void FrmSelect_MouseDown(object sender, MouseEventArgs e)
        {
            _down = e.Location;
        }

        private void FrmSelect_MouseUp(object sender, MouseEventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void FrmSelect_Paint(object sender, PaintEventArgs e)
        {
            if (Selected.Width > 0)
                e.Graphics.FillRectangle(
                    Brushes.Fuchsia, Selected);
        }
    }
}
