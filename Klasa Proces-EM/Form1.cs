using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace Klasa_Proces_EM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonIExplorer_Click(object sender, EventArgs e)
        {
            Process.Start("IExplore.exe");
        }

        private void ButtonExcel_Click(object sender, EventArgs e)
        {
            Process.Start("Excel.exe");
        }

        private void ButtonWord_Click(object sender, EventArgs e)
        {
            Process.Start("Word.exe");
        }

        private void ButtonStartInfo_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo("IExplore.exe");

            startInfo.WindowStyle = ProcessWindowStyle.Normal;

            startInfo.Arguments = "www.sser.hr";

            Process.Start(startInfo);


        }
    }
}
