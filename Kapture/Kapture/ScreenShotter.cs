using System;
using System.Windows;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kapture
{
    static class ScreenShotter
    {
        /// <summary>
        /// Returns a bitmap iamge of the specified region on screen.
        /// </summary>
        /// <param name="x">X coordinate of the source rectangle</param>
        /// <param name="y">Y coordinate of the source rectangle</param>
        /// <param name="width">Width of the source rectangle</param>
        /// <param name="height">Height of the source rectangle</param>
        /// <returns></returns>
        public static Image CaptureRegion(int x, int y, int width, int height)
        {
            Image bitmap = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.CopyFromScreen(x, y, 0, 0, new Size(width, height));
            }
            return bitmap;
        }

        /// <summary>
        /// Returns a bitmap image of the specified window.
        /// </summary>
        /// <param name="window">Window to be captured</param>
        /// <returns></returns>
        public static Image CaptureWindow(IntPtr window)
        {
            Point loc = Win32.GetWindowLocation(window);
            Size size = Win32.GetWindowSize(window);
            return CaptureRegion(loc.X, loc.Y, size.Width, size.Height);
        }

        /// <summary>
        /// Returns a bitmap image of the screen containing the specified point.
        /// </summary>
        /// <param name="sourcePoint"></param>
        /// <returns></returns>
        public static Image CaptureScreen(Point sourcePoint)
        {
            Screen screen = Screen.FromPoint(sourcePoint);
            return CaptureRegion(screen.Bounds.X, screen.Bounds.Y, screen.Bounds.Width, screen.Bounds.Height);
        }

        /// <summary>
        /// Returns a bitmap image of all screens combined.
        /// </summary>
        /// <returns></returns>
        public static Image CaptureScreens()
        {
            return CaptureRegion(
                SystemInformation.VirtualScreen.Width,
                SystemInformation.VirtualScreen.Height,
                SystemInformation.VirtualScreen.X,
                SystemInformation.VirtualScreen.Y);
        }
    }
}
