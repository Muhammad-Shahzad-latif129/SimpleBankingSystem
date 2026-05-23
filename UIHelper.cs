using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing.Drawing2D;

namespace SimpleBankingSystem
{
    public class UIHelper
    {
        public static void RoundButton(Button btn)
        {
            GraphicsPath path =
                new GraphicsPath();

            int radius = 20;

            path.AddArc(
                0, 0,
                radius, radius,
                180, 90);

            path.AddArc(
                btn.Width - radius, 0,
                radius, radius,
                270, 90);

            path.AddArc(
                btn.Width - radius,
                btn.Height - radius,
                radius, radius,
                0, 90);

            path.AddArc(
                0,
                btn.Height - radius,
                radius, radius,
                90, 90);

            path.CloseAllFigures();

            btn.Region =
                new Region(path);
        }
        
    }
}
