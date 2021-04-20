using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsoSportiveGUI
{
    public partial class FrmUtilitaire : Form
    {
        public const int Coord = 20;

        public static FrmUtilitaire init()
        {
            return new FrmUtilitaire();
        }

        public static Label setLabel(string text, int x = Coord, int y = Coord)
        {
            Label lbl = new Label();
            lbl.Text = text;
            lbl.AutoSize = true;
            lbl.Location = new Point(x, y);
            lbl.Dock = DockStyle.Fill;
            lbl.TextAlign = ContentAlignment.MiddleCenter;

            return lbl;
        }

        public void putLabelInPnl(List<Label> labels, Control[] control)
        {
            foreach (Label label in labels) { control[0].Controls.Add(label); }
        }
    }
}
