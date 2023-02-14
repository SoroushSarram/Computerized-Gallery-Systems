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
    public partial class Return : Form
    {
        Gallery gallery;
        public Return()
        {
            InitializeComponent();
        }
        public Return(Gallery gallery)
        {
            this.gallery = gallery;
            InitializeComponent();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            double returnVal = gallery.returnValue(textBoxPieceReturn.Text);
            MessageBox.Show(returnVal + "$ will be returned to you", "Piece Returned!");
        }

        private void buttonShowReturn_Click(object sender, EventArgs e)
        {
            string msg = gallery.showReturnArtPiece(textBoxPieceReturn.Text);
            listViewPieces.Items.Add(msg);
        }
    }
}
