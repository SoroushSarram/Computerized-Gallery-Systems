namespace CGS_Windows
{
    partial class mainForm
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
            this.Curatortab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonClear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonCloseCur = new System.Windows.Forms.Button();
            this.richTextBoxCur = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonViewCur = new System.Windows.Forms.Button();
            this.buttonAddCur = new System.Windows.Forms.Button();
            this.textBoxCurID = new System.Windows.Forms.TextBox();
            this.textBoxCurLastName = new System.Windows.Forms.TextBox();
            this.textBoxCurFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonSaveArtist = new System.Windows.Forms.Button();
            this.buttonClearArtist = new System.Windows.Forms.Button();
            this.buttonCloseArtist = new System.Windows.Forms.Button();
            this.richTextBoxArtist = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonViewArtist = new System.Windows.Forms.Button();
            this.buttonAddArtist = new System.Windows.Forms.Button();
            this.textBoxArtistID = new System.Windows.Forms.TextBox();
            this.textBoxArtistLn = new System.Windows.Forms.TextBox();
            this.textBoxArtistFn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonSaveArtPiece = new System.Windows.Forms.Button();
            this.richTextBoxPieces = new System.Windows.Forms.RichTextBox();
            this.buttonClosePiece = new System.Windows.Forms.Button();
            this.buttonSellArt = new System.Windows.Forms.Button();
            this.buttonListPieces = new System.Windows.Forms.Button();
            this.buttonAddArtPiece = new System.Windows.Forms.Button();
            this.radioButtonInStorage = new System.Windows.Forms.RadioButton();
            this.radioButtonOnDisplay = new System.Windows.Forms.RadioButton();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxCurID2 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxArtistID2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxPieceID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonReturnPiece = new System.Windows.Forms.Button();
            this.Curatortab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Curatortab
            // 
            this.Curatortab.Controls.Add(this.tabPage1);
            this.Curatortab.Controls.Add(this.tabPage2);
            this.Curatortab.Controls.Add(this.tabPage3);
            this.Curatortab.Location = new System.Drawing.Point(6, 5);
            this.Curatortab.Name = "Curatortab";
            this.Curatortab.SelectedIndex = 0;
            this.Curatortab.Size = new System.Drawing.Size(790, 439);
            this.Curatortab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Silver;
            this.tabPage1.Controls.Add(this.buttonClear);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.buttonCloseCur);
            this.tabPage1.Controls.Add(this.richTextBoxCur);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.buttonViewCur);
            this.tabPage1.Controls.Add(this.buttonAddCur);
            this.tabPage1.Controls.Add(this.textBoxCurID);
            this.tabPage1.Controls.Add(this.textBoxCurLastName);
            this.tabPage1.Controls.Add(this.textBoxCurFirstName);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(782, 410);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Curators";
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(22, 190);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(119, 43);
            this.buttonClear.TabIndex = 12;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Curator Information:";
            // 
            // buttonCloseCur
            // 
            this.buttonCloseCur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCloseCur.Location = new System.Drawing.Point(645, 226);
            this.buttonCloseCur.Name = "buttonCloseCur";
            this.buttonCloseCur.Size = new System.Drawing.Size(119, 43);
            this.buttonCloseCur.TabIndex = 10;
            this.buttonCloseCur.Text = "Close";
            this.buttonCloseCur.UseVisualStyleBackColor = true;
            this.buttonCloseCur.Click += new System.EventHandler(this.buttonCloseCur_Click);
            // 
            // richTextBoxCur
            // 
            this.richTextBoxCur.Location = new System.Drawing.Point(6, 275);
            this.richTextBoxCur.Name = "richTextBoxCur";
            this.richTextBoxCur.Size = new System.Drawing.Size(770, 129);
            this.richTextBoxCur.TabIndex = 9;
            this.richTextBoxCur.Text = "";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(376, 177);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 43);
            this.button3.TabIndex = 8;
            this.button3.Text = "Save Curator";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonViewCur
            // 
            this.buttonViewCur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewCur.Location = new System.Drawing.Point(376, 226);
            this.buttonViewCur.Name = "buttonViewCur";
            this.buttonViewCur.Size = new System.Drawing.Size(119, 43);
            this.buttonViewCur.TabIndex = 7;
            this.buttonViewCur.Text = "View Curator";
            this.buttonViewCur.UseVisualStyleBackColor = true;
            this.buttonViewCur.Click += new System.EventHandler(this.buttonViewCur_Click);
            // 
            // buttonAddCur
            // 
            this.buttonAddCur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddCur.Location = new System.Drawing.Point(376, 128);
            this.buttonAddCur.Name = "buttonAddCur";
            this.buttonAddCur.Size = new System.Drawing.Size(119, 43);
            this.buttonAddCur.TabIndex = 6;
            this.buttonAddCur.Text = "Add Curator";
            this.buttonAddCur.UseVisualStyleBackColor = true;
            this.buttonAddCur.Click += new System.EventHandler(this.buttonAddCur_Click);
            // 
            // textBoxCurID
            // 
            this.textBoxCurID.Location = new System.Drawing.Point(136, 153);
            this.textBoxCurID.Name = "textBoxCurID";
            this.textBoxCurID.Size = new System.Drawing.Size(199, 22);
            this.textBoxCurID.TabIndex = 5;
            // 
            // textBoxCurLastName
            // 
            this.textBoxCurLastName.Location = new System.Drawing.Point(136, 108);
            this.textBoxCurLastName.Name = "textBoxCurLastName";
            this.textBoxCurLastName.Size = new System.Drawing.Size(199, 22);
            this.textBoxCurLastName.TabIndex = 4;
            // 
            // textBoxCurFirstName
            // 
            this.textBoxCurFirstName.Location = new System.Drawing.Point(136, 61);
            this.textBoxCurFirstName.Name = "textBoxCurFirstName";
            this.textBoxCurFirstName.Size = new System.Drawing.Size(199, 22);
            this.textBoxCurFirstName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "First name:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Silver;
            this.tabPage2.Controls.Add(this.buttonSaveArtist);
            this.tabPage2.Controls.Add(this.buttonClearArtist);
            this.tabPage2.Controls.Add(this.buttonCloseArtist);
            this.tabPage2.Controls.Add(this.richTextBoxArtist);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.buttonViewArtist);
            this.tabPage2.Controls.Add(this.buttonAddArtist);
            this.tabPage2.Controls.Add(this.textBoxArtistID);
            this.tabPage2.Controls.Add(this.textBoxArtistLn);
            this.tabPage2.Controls.Add(this.textBoxArtistFn);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(782, 410);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Artists";
            // 
            // buttonSaveArtist
            // 
            this.buttonSaveArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveArtist.Location = new System.Drawing.Point(380, 88);
            this.buttonSaveArtist.Name = "buttonSaveArtist";
            this.buttonSaveArtist.Size = new System.Drawing.Size(119, 43);
            this.buttonSaveArtist.TabIndex = 24;
            this.buttonSaveArtist.Text = "Save Artist";
            this.buttonSaveArtist.UseVisualStyleBackColor = true;
            this.buttonSaveArtist.Click += new System.EventHandler(this.buttonSaveArtist_Click);
            // 
            // buttonClearArtist
            // 
            this.buttonClearArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearArtist.Location = new System.Drawing.Point(19, 186);
            this.buttonClearArtist.Name = "buttonClearArtist";
            this.buttonClearArtist.Size = new System.Drawing.Size(100, 43);
            this.buttonClearArtist.TabIndex = 23;
            this.buttonClearArtist.Text = "Clear";
            this.buttonClearArtist.UseVisualStyleBackColor = true;
            this.buttonClearArtist.Click += new System.EventHandler(this.buttonClearArtist_Click);
            // 
            // buttonCloseArtist
            // 
            this.buttonCloseArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCloseArtist.Location = new System.Drawing.Point(638, 186);
            this.buttonCloseArtist.Name = "buttonCloseArtist";
            this.buttonCloseArtist.Size = new System.Drawing.Size(119, 43);
            this.buttonCloseArtist.TabIndex = 22;
            this.buttonCloseArtist.Text = "Close";
            this.buttonCloseArtist.UseVisualStyleBackColor = true;
            this.buttonCloseArtist.Click += new System.EventHandler(this.buttonCloseArtist_Click);
            // 
            // richTextBoxArtist
            // 
            this.richTextBoxArtist.Location = new System.Drawing.Point(6, 235);
            this.richTextBoxArtist.Name = "richTextBoxArtist";
            this.richTextBoxArtist.Size = new System.Drawing.Size(770, 164);
            this.richTextBoxArtist.TabIndex = 21;
            this.richTextBoxArtist.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Curator Information:";
            // 
            // buttonViewArtist
            // 
            this.buttonViewArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewArtist.Location = new System.Drawing.Point(380, 186);
            this.buttonViewArtist.Name = "buttonViewArtist";
            this.buttonViewArtist.Size = new System.Drawing.Size(119, 43);
            this.buttonViewArtist.TabIndex = 19;
            this.buttonViewArtist.Text = "View Artists";
            this.buttonViewArtist.UseVisualStyleBackColor = true;
            this.buttonViewArtist.Click += new System.EventHandler(this.buttonViewArtist_Click);
            // 
            // buttonAddArtist
            // 
            this.buttonAddArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddArtist.Location = new System.Drawing.Point(380, 137);
            this.buttonAddArtist.Name = "buttonAddArtist";
            this.buttonAddArtist.Size = new System.Drawing.Size(119, 43);
            this.buttonAddArtist.TabIndex = 18;
            this.buttonAddArtist.Text = "Add Artist";
            this.buttonAddArtist.UseVisualStyleBackColor = true;
            this.buttonAddArtist.Click += new System.EventHandler(this.buttonAddArtist_Click);
            // 
            // textBoxArtistID
            // 
            this.textBoxArtistID.Location = new System.Drawing.Point(133, 150);
            this.textBoxArtistID.Name = "textBoxArtistID";
            this.textBoxArtistID.Size = new System.Drawing.Size(199, 22);
            this.textBoxArtistID.TabIndex = 17;
            // 
            // textBoxArtistLn
            // 
            this.textBoxArtistLn.Location = new System.Drawing.Point(133, 105);
            this.textBoxArtistLn.Name = "textBoxArtistLn";
            this.textBoxArtistLn.Size = new System.Drawing.Size(199, 22);
            this.textBoxArtistLn.TabIndex = 16;
            // 
            // textBoxArtistFn
            // 
            this.textBoxArtistFn.Location = new System.Drawing.Point(133, 58);
            this.textBoxArtistFn.Name = "textBoxArtistFn";
            this.textBoxArtistFn.Size = new System.Drawing.Size(199, 22);
            this.textBoxArtistFn.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Last name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "First name:";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Silver;
            this.tabPage3.Controls.Add(this.buttonReturnPiece);
            this.tabPage3.Controls.Add(this.buttonSaveArtPiece);
            this.tabPage3.Controls.Add(this.richTextBoxPieces);
            this.tabPage3.Controls.Add(this.buttonClosePiece);
            this.tabPage3.Controls.Add(this.buttonSellArt);
            this.tabPage3.Controls.Add(this.buttonListPieces);
            this.tabPage3.Controls.Add(this.buttonAddArtPiece);
            this.tabPage3.Controls.Add(this.radioButtonInStorage);
            this.tabPage3.Controls.Add(this.radioButtonOnDisplay);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.textBoxCurID2);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.textBoxArtistID2);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.textBoxValue);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.textBoxYear);
            this.tabPage3.Controls.Add(this.textBoxTitle);
            this.tabPage3.Controls.Add(this.textBoxPieceID);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(782, 410);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Art Pieces";
            // 
            // buttonSaveArtPiece
            // 
            this.buttonSaveArtPiece.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveArtPiece.Location = new System.Drawing.Point(645, 169);
            this.buttonSaveArtPiece.Name = "buttonSaveArtPiece";
            this.buttonSaveArtPiece.Size = new System.Drawing.Size(119, 43);
            this.buttonSaveArtPiece.TabIndex = 42;
            this.buttonSaveArtPiece.Text = "Save Pieces";
            this.buttonSaveArtPiece.UseVisualStyleBackColor = true;
            this.buttonSaveArtPiece.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBoxPieces
            // 
            this.richTextBoxPieces.Location = new System.Drawing.Point(6, 267);
            this.richTextBoxPieces.Name = "richTextBoxPieces";
            this.richTextBoxPieces.Size = new System.Drawing.Size(770, 137);
            this.richTextBoxPieces.TabIndex = 41;
            this.richTextBoxPieces.Text = "";
            // 
            // buttonClosePiece
            // 
            this.buttonClosePiece.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClosePiece.Location = new System.Drawing.Point(645, 218);
            this.buttonClosePiece.Name = "buttonClosePiece";
            this.buttonClosePiece.Size = new System.Drawing.Size(119, 43);
            this.buttonClosePiece.TabIndex = 40;
            this.buttonClosePiece.Text = "Close";
            this.buttonClosePiece.UseVisualStyleBackColor = true;
            this.buttonClosePiece.Click += new System.EventHandler(this.buttonClosePiece_Click);
            // 
            // buttonSellArt
            // 
            this.buttonSellArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSellArt.Location = new System.Drawing.Point(450, 157);
            this.buttonSellArt.Name = "buttonSellArt";
            this.buttonSellArt.Size = new System.Drawing.Size(119, 43);
            this.buttonSellArt.TabIndex = 39;
            this.buttonSellArt.Text = "Sell Art Piece";
            this.buttonSellArt.UseVisualStyleBackColor = true;
            this.buttonSellArt.Click += new System.EventHandler(this.buttonSellArt_Click);
            // 
            // buttonListPieces
            // 
            this.buttonListPieces.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListPieces.Location = new System.Drawing.Point(450, 206);
            this.buttonListPieces.Name = "buttonListPieces";
            this.buttonListPieces.Size = new System.Drawing.Size(119, 43);
            this.buttonListPieces.TabIndex = 38;
            this.buttonListPieces.Text = "List Pieces";
            this.buttonListPieces.UseVisualStyleBackColor = true;
            this.buttonListPieces.Click += new System.EventHandler(this.buttonListPieces_Click);
            // 
            // buttonAddArtPiece
            // 
            this.buttonAddArtPiece.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddArtPiece.Location = new System.Drawing.Point(450, 108);
            this.buttonAddArtPiece.Name = "buttonAddArtPiece";
            this.buttonAddArtPiece.Size = new System.Drawing.Size(119, 43);
            this.buttonAddArtPiece.TabIndex = 37;
            this.buttonAddArtPiece.Text = "Add Art Piece";
            this.buttonAddArtPiece.UseVisualStyleBackColor = true;
            this.buttonAddArtPiece.Click += new System.EventHandler(this.buttonAddArtPiece_Click_1);
            // 
            // radioButtonInStorage
            // 
            this.radioButtonInStorage.AutoSize = true;
            this.radioButtonInStorage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonInStorage.Location = new System.Drawing.Point(450, 74);
            this.radioButtonInStorage.Name = "radioButtonInStorage";
            this.radioButtonInStorage.Size = new System.Drawing.Size(106, 22);
            this.radioButtonInStorage.TabIndex = 36;
            this.radioButtonInStorage.TabStop = true;
            this.radioButtonInStorage.Text = "In Storage";
            this.radioButtonInStorage.UseVisualStyleBackColor = true;
            // 
            // radioButtonOnDisplay
            // 
            this.radioButtonOnDisplay.AutoSize = true;
            this.radioButtonOnDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonOnDisplay.Location = new System.Drawing.Point(450, 48);
            this.radioButtonOnDisplay.Name = "radioButtonOnDisplay";
            this.radioButtonOnDisplay.Size = new System.Drawing.Size(111, 22);
            this.radioButtonOnDisplay.TabIndex = 35;
            this.radioButtonOnDisplay.TabStop = true;
            this.radioButtonOnDisplay.Text = "On Display";
            this.radioButtonOnDisplay.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(446, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 20);
            this.label16.TabIndex = 34;
            this.label16.Text = "Status:";
            // 
            // textBoxCurID2
            // 
            this.textBoxCurID2.Location = new System.Drawing.Point(133, 229);
            this.textBoxCurID2.Name = "textBoxCurID2";
            this.textBoxCurID2.Size = new System.Drawing.Size(199, 22);
            this.textBoxCurID2.TabIndex = 33;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(16, 231);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 18);
            this.label15.TabIndex = 32;
            this.label15.Text = "Curator ID:";
            // 
            // textBoxArtistID2
            // 
            this.textBoxArtistID2.Location = new System.Drawing.Point(133, 201);
            this.textBoxArtistID2.Name = "textBoxArtistID2";
            this.textBoxArtistID2.Size = new System.Drawing.Size(199, 22);
            this.textBoxArtistID2.TabIndex = 31;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(16, 203);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 18);
            this.label14.TabIndex = 30;
            this.label14.Text = "Artist ID:";
            // 
            // textBoxValue
            // 
            this.textBoxValue.Location = new System.Drawing.Point(133, 169);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(199, 22);
            this.textBoxValue.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(16, 171);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 18);
            this.label13.TabIndex = 28;
            this.label13.Text = "Value:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 20);
            this.label9.TabIndex = 27;
            this.label9.Text = "Art Piece Information:";
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(133, 135);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(199, 22);
            this.textBoxYear.TabIndex = 26;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(133, 107);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(199, 22);
            this.textBoxTitle.TabIndex = 25;
            // 
            // textBoxPieceID
            // 
            this.textBoxPieceID.Location = new System.Drawing.Point(133, 79);
            this.textBoxPieceID.Name = "textBoxPieceID";
            this.textBoxPieceID.Size = new System.Drawing.Size(199, 22);
            this.textBoxPieceID.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 18);
            this.label10.TabIndex = 23;
            this.label10.Text = "Year:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 18);
            this.label11.TabIndex = 22;
            this.label11.Text = "Title:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(16, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 18);
            this.label12.TabIndex = 21;
            this.label12.Text = "ID:";
            // 
            // buttonReturnPiece
            // 
            this.buttonReturnPiece.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturnPiece.Location = new System.Drawing.Point(645, 22);
            this.buttonReturnPiece.Name = "buttonReturnPiece";
            this.buttonReturnPiece.Size = new System.Drawing.Size(119, 56);
            this.buttonReturnPiece.TabIndex = 43;
            this.buttonReturnPiece.Text = "Return Pieces";
            this.buttonReturnPiece.UseVisualStyleBackColor = true;
            this.buttonReturnPiece.Click += new System.EventHandler(this.buttonReturnPiece_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Curatortab);
            this.Name = "mainForm";
            this.Text = "mainForm";
            this.Curatortab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Curatortab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBoxCurFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonCloseCur;
        private System.Windows.Forms.RichTextBox richTextBoxCur;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonViewCur;
        private System.Windows.Forms.Button buttonAddCur;
        private System.Windows.Forms.TextBox textBoxCurID;
        private System.Windows.Forms.TextBox textBoxCurLastName;
        private System.Windows.Forms.Button buttonCloseArtist;
        private System.Windows.Forms.RichTextBox richTextBoxArtist;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonViewArtist;
        private System.Windows.Forms.Button buttonAddArtist;
        private System.Windows.Forms.TextBox textBoxArtistID;
        private System.Windows.Forms.TextBox textBoxArtistLn;
        private System.Windows.Forms.TextBox textBoxArtistFn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioButtonInStorage;
        private System.Windows.Forms.RadioButton radioButtonOnDisplay;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxCurID2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxArtistID2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxPieceID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox richTextBoxPieces;
        private System.Windows.Forms.Button buttonClosePiece;
        private System.Windows.Forms.Button buttonSellArt;
        private System.Windows.Forms.Button buttonListPieces;
        private System.Windows.Forms.Button buttonAddArtPiece;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonClearArtist;
        private System.Windows.Forms.Button buttonSaveArtPiece;
        private System.Windows.Forms.Button buttonSaveArtist;
        private System.Windows.Forms.Button buttonReturnPiece;
    }
}