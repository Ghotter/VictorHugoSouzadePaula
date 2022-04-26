using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VictorHugoSouzadePaula.View
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb.Text = String.Empty;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "abrira arquivo";
            openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Arquivo txt|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader leitor = new System.IO.StreamReader(openFileDialog1.FileName);
                rtb.Text = leitor.ReadToEnd();
                leitor.Close();
            }

        }
    }
}
