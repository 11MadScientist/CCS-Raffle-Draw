using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCS_Raffle_Draw
{
    class CircularButttons :Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath gpath = new GraphicsPath();
            gpath.AddEllipse(0,0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(gpath); 
            base.OnPaint(pevent);
        }
    }
}
