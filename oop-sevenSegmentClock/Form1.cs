using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace oop_sevenSegmentClock
{
    public partial class sevensegmentclock : Form
    {
        // Declare list of table layout panels
        List<TableLayoutPanel> panels = new List<TableLayoutPanel>();

        public sevensegmentclock()
        {
            InitializeComponent();

            // Add tables to global list
            panels.Add(h1); panels.Add(h2); panels.Add(m1);
            panels.Add(m2); panels.Add(s1); panels.Add(s2);
        }

        private void loadTime(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToString("HHmmss");
            for (int i = 0, n = time.Length; i < n; i++)
                printSegment(panels[i], time[i]);
        }

        private void printSegment(TableLayoutPanel tlp, char val)
        {
            var buttons = new Button[7];

            foreach (var button in tlp.Controls.OfType<Button>())
                buttons[button.Name[2] - '0'] = button;

            bool[] segments = {};
            switch (val)
            {
                case '0':
                    segments = new bool[] { 
                        true, true, true, true, true, true, false 
                    }; break;
                case '1':
                    segments = new bool[] {
                        false, true, true, false, false, false, false
                    }; break;
                case '2':
                    segments = new bool[] {
                        true, true, false, true, true, false, true
                    }; break;
                case '3':
                    segments = new bool[] {
                        true, true, true, true, false, false, true
                    }; break;
                case '4':
                    segments = new bool[] {
                        false, true, true, false, false, true, true
                    }; break;
                case '5':
                    segments = new bool[] {
                        true, false, true, true, false, true, true
                    }; break;
                case '6':
                    segments = new bool[] {
                        true, false, true, true, true, true, true
                    }; break;
                case '7':
                    segments = new bool[] {
                        true, true, true, false, false, false, false
                    }; break;
                case '8':
                    segments = new bool[] {
                        true, true, true, true, true, true, true
                    }; break;
                case '9':
                    segments = new bool[] {
                        true, true, true, true, false, true, true
                    }; break;
            }

            for (int i = 0, n = buttons.Length; i < n; i++)
            {
                if (segments[i]) 
                    buttons[i].BackColor = SystemColors.ControlDarkDark;
                else 
                    buttons[i].BackColor = SystemColors.AppWorkspace;
            }
        }
    }
}
