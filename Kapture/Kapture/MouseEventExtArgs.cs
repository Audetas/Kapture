using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kapture
{
    class MouseEventExtArgs : MouseEventArgs
    {
        /// <summary>
        /// Initializes a new instance of the MouseEventArgs class. 
        /// </summary>
        /// <param name="buttons">One of the MouseButtons values indicating which mouse button was pressed.</param>
        /// <param name="clicks">The number of times a mouse button was pressed.</param>
        /// <param name="x">The x-coordinate of a mouse click, in pixels.</param>
        /// <param name="y">The y-coordinate of a mouse click, in pixels.</param>
        /// <param name="delta">A signed count of the number of detents the wheel has rotated.</param>
        public MouseEventExtArgs(MouseButtons buttons, int clicks, int x, int y, int delta)
            : base(buttons, clicks, x, y, delta)
        { }

        /// <summary>
        /// Initializes a new instance of the MouseEventArgs class. 
        /// </summary>
        /// <param name="e">An ordinary <see cref="MouseEventArgs"/> argument to be extended.</param>
        internal MouseEventExtArgs(MouseEventArgs e)
            : base(e.Button, e.Clicks, e.X, e.Y, e.Delta)
        { }

        private bool m_Handled;

        /// <summary>
        /// Set this property to <b>true</b> inside your event handler to prevent further processing of the event in other applications.
        /// </summary>
        public bool Handled
        {
            get { return m_Handled; }
            set { m_Handled = value; }
        }
    }
}
