using System;
using MonoMac.Foundation;
using MonoMac.AppKit;

namespace NeHeLesson1
{
        public partial class MainWindow : MonoMac.AppKit.NSWindow
        {
                public MainWindow (IntPtr handle) : base(handle)
                {
                }

                public MainWindow (NSCoder coder) : base(coder)
                {
                }
        }
}

