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

namespace FormEditorDeTexto
{
    public partial class FrmEditorDeTexto : Form
    {
        String path = String.Empty;
        public FrmEditorDeTexto()
        {
            InitializeComponent();
        }

        private void rtbPrincipal_TextChanged(object sender, EventArgs e)
        {
            lblStatus.Text = rtbPrincipal.Text.Length + " caracteres";
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files (*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                StreamReader streamReader = new StreamReader(openFileDialog.FileName);

                rtbPrincipal.Text = streamReader.ReadToEnd();

                streamReader.Close();

            }

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (this.path != String.Empty)
            {
                StreamWriter streamReader = new StreamWriter(this.path, false);

                streamReader.Write(rtbPrincipal.Text);

                streamReader.Close();

            }
            else
            {
                this.guardarComoToolStripMenuItem_Click(sender, e);
            }


        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "txt files (*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.path = saveFileDialog.FileName;
                StreamWriter streamReader = new StreamWriter(this.path,false);

                streamReader.Write(rtbPrincipal.Text);

                streamReader.Close();

            }
        }

    }
}
