using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hydro_Injector_v2
{
    public partial class HydroDownForm : Form
    {
        public HydroDownForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnInject_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HydroDownForm_Load(object sender, EventArgs e)
        {
            string Hydro_Down_Notice_Location = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            Hydro_Down_Notice_Location += "\\Hydrogen\\HydroDiscord.goth";
            File.CreateText(Hydro_Down_Notice_Location);
        }

        private void btnJoinDiscord_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discordapp.com/invite/7VwfT39");
        }
    }
}
