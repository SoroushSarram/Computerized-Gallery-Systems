namespace CGS_Database
{
    partial class ArtPiece
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
            this.textBoxPieceID = new System.Windows.Forms.TextBox();
            this.textBoxArtistID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCurID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButtonOnDisplay = new System.Windows.Forms.RadioButton();
            this.radioButtonStorage = new System.Windows.Forms.RadioButton();
            this.buttonAddPiece = new System.Windows.Forms.Button();
            this.buttonSell = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonDisplay = new System.Windows.Forms.Button();
            this.dataGridViewPiece = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPiece)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ArtPiece ID:";
            // 
            // textBoxPieceID
            // 
            this.textBoxPieceID.Location = new System.Drawing.Point(172, 40);
            this.textBoxPieceID.Name = "textBoxPieceID";
            this.textBoxPieceID.Size = new System.Drawing.Size(235, 22);
            this.textBoxPieceID.TabIndex = 1;
            // 
            // textBoxArtistID
            // 
            this.textBoxArtistID.Location = new System.Drawing.Point(172, 84);
            this.textBoxArtistID.Name = "textBoxArtistID";
            this.textBoxArtistID.Size = new System.Drawing.Size(235, 22);
            this.textBoxArtistID.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Artist ID:";
            // 
            // textBoxCurID
            // 
            this.textBoxCurID.Location = new System.Drawing.Point(172, 131);
            this.textBoxCurID.Name = "textBoxCurID";
            this.textBoxCurID.Size = new System.Drawing.Size(235, 22);
            this.textBoxCurID.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Curator ID:";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(172, 179);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(235, 22);
            this.textBoxTitle.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Title:";
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(172, 225);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(235, 22);
            this.textBoxYear.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Year:";
            // 
            // textBoxValue
            // 
            this.textBoxValue.Location = new System.Drawing.Point(172, 270);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(235, 22);
            this.textBoxValue.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Value:";
            // 
            // radioButtonOnDisplay
            // 
            this.radioButtonOnDisplay.AutoSize = true;
            this.radioButtonOnDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonOnDisplay.Location = new System.Drawing.Point(16, 326);
            this.radioButtonOnDisplay.Name = "radioButtonOnDisplay";
            this.radioButtonOnDisplay.Size = new System.Drawing.Size(119, 24);
            this.radioButtonOnDisplay.TabIndex = 12;
            this.radioButtonOnDisplay.TabStop = true;
            this.radioButtonOnDisplay.Text = "On display";
            this.radioButtonOnDisplay.UseVisualStyleBackColor = true;
            // 
            // radioButtonStorage
            // 
            this.radioButtonStorage.AutoSize = true;
            this.radioButtonStorage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonStorage.Location = new System.Drawing.Point(16, 356);
            this.radioButtonStorage.Name = "radioButtonStorage";
            this.radioButtonStorage.Size = new System.Drawing.Size(95, 24);
            this.radioButtonStorage.TabIndex = 13;
            this.radioButtonStorage.TabStop = true;
            this.radioButtonStorage.Text = "Storage";
            this.radioButtonStorage.UseVisualStyleBackColor = true;
            // 
            // buttonAddPiece
            // 
            this.buttonAddPiece.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddPiece.Location = new System.Drawing.Point(256, 313);
            this.buttonAddPiece.Name = "buttonAddPiece";
            this.buttonAddPiece.Size = new System.Drawing.Size(151, 37);
            this.buttonAddPiece.TabIndex = 14;
            this.buttonAddPiece.Text = "Add Artpiece";
            this.buttonAddPiece.UseVisualStyleBackColor = true;
            this.buttonAddPiece.Click += new System.EventHandler(this.buttonAddPiece_Click);
            // 
            // buttonSell
            // 
            this.buttonSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSell.Location = new System.Drawing.Point(256, 356);
            this.buttonSell.Name = "buttonSell";
            this.buttonSell.Size = new System.Drawing.Size(151, 37);
            this.buttonSell.TabIndex = 15;
            this.buttonSell.Text = "Sell Artpiece";
            this.buttonSell.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(161, 356);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(89, 37);
            this.buttonCancel.TabIndex = 16;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonDisplay
            // 
            this.buttonDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisplay.Location = new System.Drawing.Point(161, 313);
            this.buttonDisplay.Name = "buttonDisplay";
            this.buttonDisplay.Size = new System.Drawing.Size(89, 37);
            this.buttonDisplay.TabIndex = 17;
            this.buttonDisplay.Text = "Display";
            this.buttonDisplay.UseVisualStyleBackColor = true;
            this.buttonDisplay.Click += new System.EventHandler(this.buttonDisplay_Click);
            // 
            // dataGridViewPiece
            // 
            this.dataGridViewPiece.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPiece.Location = new System.Drawing.Point(12, 413);
            this.dataGridViewPiece.Name = "dataGridViewPiece";
            this.dataGridViewPiece.RowHeadersWidth = 51;
            this.dataGridViewPiece.RowTemplate.Height = 24;
            this.dataGridViewPiece.Size = new System.Drawing.Size(449, 197);
            this.dataGridViewPiece.TabIndex = 18;
            // 
            // ArtPiece
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 622);
            this.Controls.Add(this.dataGridViewPiece);
            this.Controls.Add(this.buttonDisplay);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSell);
            this.Controls.Add(this.buttonAddPiece);
            this.Controls.Add(this.radioButtonStorage);
            this.Controls.Add(this.radioButtonOnDisplay);
            this.Controls.Add(this.textBoxValue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCurID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxArtistID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPieceID);
            this.Controls.Add(this.label1);
            this.Name = "ArtPiece";
            this.Text = "ArtPiece";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPiece)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPieceID;
        private System.Windows.Forms.TextBox textBoxArtistID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCurID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButtonOnDisplay;
        private System.Windows.Forms.RadioButton radioButtonStorage;
        private System.Windows.Forms.Button buttonAddPiece;
        private System.Windows.Forms.Button buttonSell;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonDisplay;
        private System.Windows.Forms.DataGridView dataGridViewPiece;
    }
}