using CGS_Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGS_Windows
{
    public partial class SellArtPiece : Form
    {
        Gallery gallery;
        public SellArtPiece()
        {
            InitializeComponent();
        }

        public SellArtPiece(Gallery gallery)
        {
            this.gallery = gallery;
            InitializeComponent();
        }

        private void buttonSell_Click(object sender, EventArgs e)
        {
            string msg = gallery.sellArtPiece(textBoxSellArtPieceID.Text, Convert.ToDouble(textBoxEstimate.Text));
            MessageBox.Show(msg);
        }

        private void richTextBoxSellPiece_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBoxSellPiece.Clear();
            richTextBoxSellPiece.AppendText(gallery.getArtPieceInfo());
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
