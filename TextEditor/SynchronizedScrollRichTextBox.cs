using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class SynchronizedScrollRichTextBox : UserControl
    {
        public event vScrollEventHandler vScroll;
        public delegate void vScrollEventHandler(System.Windows.Forms.Message message);

        public const int WM_VSCROLL = 0x115;

        protected override void WndProc(ref System.Windows.Forms.Message msg)
        {
            if (msg.Msg == WM_VSCROLL)
            {
                if (vScroll != null)
                {
                    vScroll(msg);
                }
            }
            base.WndProc(ref msg);
        }

        public void PubWndProc(ref System.Windows.Forms.Message msg)
        {
            base.WndProc(ref msg);
        }
    }
}
