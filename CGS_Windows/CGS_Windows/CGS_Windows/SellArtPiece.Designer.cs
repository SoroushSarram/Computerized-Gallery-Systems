namespace CGS_Windows
{
    partial class SellArtPiece
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxSellPiece = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSellArtPieceID = new System.Windows.Forms.TextBox();
            this.textBoxEstimate = new System.Windows.Forms.TextBox();
            this.buttonSell = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonViewArtPiece = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "List of Art Pieces:";
            // 
            // richTextBoxSellPiece
            // 
            this.richTextBoxSellPiece.Location = new System.Drawing.Point(25, 77);
            this.richTextBoxSellPiece.Name = "richTextBoxSellPiece";
            this.richTextBoxSellPiece.Size = new System.Drawing.Size(374, 119);
            this.richTextBoxSellPiece.TabIndex = 1;
            this.richTextBoxSellPiece.Text = "";
            this.richTextBoxSellPiece.TextChanged += new System.EventHandler(this.richTextBoxSellPiece_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "ArtPiece ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Estimate :";
            // 
            // textBoxSellArtPieceID
            // 
            this.textBoxSellArtPieceID.Location = new System.Drawing.Point(187, 237);
            this.textBoxSellArtPieceID.Name = "textBoxSellArtPieceID";
            this.textBoxSellArtPieceID.Size = new System.Drawing.Size(153, 22);
            this.textBoxSellArtPieceID.TabIndex = 4;
            // 
            // textBoxEstimate
            // 
            this.textBoxEstimate.Location = new System.Drawing.Point(187, 289);
            this.textBoxEstimate.Name = "textBoxEstimate";
            this.textBoxEstimate.Size = new System.Drawing.Size(153, 22);
            this.textBoxEstimate.TabIndex = 5;
            // 
            // buttonSell
            // 
            this.buttonSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSell.Location = new System.Drawing.Point(167, 333);
            this.buttonSell.Name = "buttonSell";
            this.buttonSell.Size = new System.Drawing.Size(87, 34);
            this.buttonSell.TabIndex = 6;
            this.buttonSell.Text = "Sell";
            this.buttonSell.UseVisualStyleBackColor = true;
            this.buttonSell.Click += new System.EventHandler(this.buttonSell_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(167, 373);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(87, 34);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonViewArtPiece
            // 
            this.buttonViewArtPiece.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewArtPiece.Location = new System.Drawing.Point(25, 202);
            this.buttonViewArtPiece.Name = "buttonViewArtPiece";
            this.buttonViewArtPiece.Size = new System.Drawing.Size(75, 33);
            this.buttonViewArtPiece.TabIndex = 8;
            this.buttonViewArtPiece.Text = "View List";
            this.buttonViewArtPiece.UseVisualStyleBackColor = true;
            this.buttonViewArtPiece.Click += new System.EventHandler(this.button1_Click);
            // 
            // SellArtPiece
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(431, 423);
            this.Controls.Add(this.buttonViewArtPiece);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSell);
            this.Controls.Add(this.textBoxEstimate);
            this.Controls.Add(this.textBoxSellArtPieceID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBoxSellPiece);
            this.Controls.Add(this.label1);
            this.Name = "SellArtPiece";
            this.Text = "SellArtPiece";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxSellPiece;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSellArtPieceID;
        private System.Windows.Forms.TextBox textBoxEstimate;
        private System.Windows.Forms.Button buttonSell;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonViewArtPiece;
    }
}