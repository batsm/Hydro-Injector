using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hydro_Injector_v2
{
    public partial class MenuDown : Form
    {
        int OldX, OldY;

        public MenuDown(int x, int y)
        {
            InitializeComponent();

            OldX = x;
            OldY = y;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MenuDown_Load(object sender, EventArgs e)
        {
            this.Top = OldX;
            this.Left = OldY;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
