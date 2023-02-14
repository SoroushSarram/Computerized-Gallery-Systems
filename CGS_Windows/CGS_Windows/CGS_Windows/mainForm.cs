using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CGS_Lib;

namespace CGS_Windows
{
    public partial class mainForm : Form
    {
        Gallery gallery = new Gallery();
        public mainForm()
        {
            InitializeComponent();
        }

        private void buttonAddCur_Click(object sender, EventArgs e)
        {
            string msg = gallery.addCurator(textBoxCurID.Text, textBoxCurFirstName.Text, textBoxCurLastName.Text);
            MessageBox.Show(msg);
        }

        private void buttonViewCur_Click(object sender, EventArgs e)
        {
            richTextBoxCur.Clear();
            richTextBoxCur.AppendText(gallery.getCuratorInfo());
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxCurFirstName.Clear();
            textBoxCurLastName.Clear();
            textBoxCurID.Clear();
        }

        private void buttonAddArtist_Click(object sender, EventArgs e)
        {
            string msg = gallery.addArtist(textBoxArtistID.Text, textBoxArtistFn.Text, textBoxArtistLn.Text);
            MessageBox.Show(msg);
        }

        private void buttonViewArtist_Click(object sender, EventArgs e)
        {
            richTextBoxArtist.Clear();
            richTextBoxArtist.AppendText(gallery.getArtistInfo());
        }

        private void buttonClearArtist_Click(object sender, EventArgs e)
        {
            textBoxArtistFn.Clear();
            textBoxArtistLn.Clear();
            textBoxArtistID.Clear();
        }

        private void buttonCloseCur_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gallery.saveArtPieces();
        }

        private void buttonAddArtpiece_Click(object sender, EventArgs e)
        {
        }

        private void buttonAddArtPiece_Click_1(object sender, EventArgs e)
        {
            char status = 'D';
            if (radioButtonOnDisplay.Checked == true)
            {
                status = 'D';
            }
            else if (radioButtonInStorage.Checked == true)
            {
                status = 'G';
            }
            string msg = gallery.addArtPiece(textBoxPieceID.Text, textBoxTitle.Text, Convert.ToInt32(textBoxYear.Text), Convert.ToDouble(textBoxValue.Text), textBoxCurID2.Text, textBoxArtistID2.Text, status);
            MessageBox.Show(msg);
        }

        private void buttonListPieces_Click(object sender, EventArgs e)
        {
            richTextBoxPieces.Clear();
            richTextBoxPieces.AppendText(gallery.getArtPieceInfo());
        }

        private void buttonSellArt_Click(object sender, EventArgs e)
        {
            SellArtPiece sellArtPiece = new SellArtPiece(gallery);
            sellArtPiece.Show();
        }

        private void buttonCloseArtist_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void buttonClosePiece_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gallery.saveCurators();
        }

        private void buttonSaveArtist_Click(object sender, EventArgs e)
        {
            gallery.saveArtists();
        }

        private void buttonReturnPiece_Click(object sender, EventArgs e)
        {
            Return returnForm = new Return(gallery);
            returnForm.Show();
        }
    }
}

