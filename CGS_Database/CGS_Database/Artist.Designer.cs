namespace CGS_Database
{
    partial class Artist
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
            this.textBoxArtistID = new System.Windows.Forms.TextBox();
            this.textBoxCuratorID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxArtistLN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxArtistFN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAddArtist = new System.Windows.Forms.Button();
            this.buttonDisplay = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.dataGridViewArtist = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtist)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Artist ID:";
            // 
            // textBoxArtistID
            // 
            this.textBoxArtistID.Location = new System.Drawing.Point(149, 37);
            this.textBoxArtistID.Name = "textBoxArtistID";
            this.textBoxArtistID.Size = new System.Drawing.Size(289, 22);
            this.textBoxArtistID.TabIndex = 1;
            // 
            // textBoxCuratorID
            // 
            this.textBoxCuratorID.Location = new System.Drawing.Point(149, 156);
            this.textBoxCuratorID.Name = "textBoxCuratorID";
            this.textBoxCuratorID.Size = new System.Drawing.Size(289, 22);
            this.textBoxCuratorID.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Curator ID:";
            // 
            // textBoxArtistLN
            // 
            this.textBoxArtistLN.Location = new System.Drawing.Point(149, 116);
            this.textBoxArtistLN.Name = "textBoxArtistLN";
            this.textBoxArtistLN.Size = new System.Drawing.Size(289, 22);
            this.textBoxArtistLN.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name:";
            // 
            // textBoxArtistFN
            // 
            this.textBoxArtistFN.Location = new System.Drawing.Point(149, 76);
            this.textBoxArtistFN.Name = "textBoxArtistFN";
            this.textBoxArtistFN.Size = new System.Drawing.Size(289, 22);
            this.textBoxArtistFN.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "First Name:";
            // 
            // buttonAddArtist
            // 
            this.buttonAddArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddArtist.Location = new System.Drawing.Point(325, 201);
            this.buttonAddArtist.Name = "buttonAddArtist";
            this.buttonAddArtist.Size = new System.Drawing.Size(113, 41);
            this.buttonAddArtist.TabIndex = 8;
            this.buttonAddArtist.Text = "Add Artist";
            this.buttonAddArtist.UseVisualStyleBackColor = true;
            this.buttonAddArtist.Click += new System.EventHandler(this.buttonAddArtist_Click);
            // 
            // buttonDisplay
            // 
            this.buttonDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisplay.Location = new System.Drawing.Point(206, 201);
            this.buttonDisplay.Name = "buttonDisplay";
            this.buttonDisplay.Size = new System.Drawing.Size(113, 41);
            this.buttonDisplay.TabIndex = 9;
            this.buttonDisplay.Text = "Display";
            this.buttonDisplay.UseVisualStyleBackColor = true;
            this.buttonDisplay.Click += new System.EventHandler(this.buttonDisplay_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(22, 201);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(91, 41);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // dataGridViewArtist
            // 
            this.dataGridViewArtist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArtist.Location = new System.Drawing.Point(12, 258);
            this.dataGridViewArtist.Name = "dataGridViewArtist";
            this.dataGridViewArtist.RowHeadersWidth = 51;
            this.dataGridViewArtist.RowTemplate.Height = 24;
            this.dataGridViewArtist.Size = new System.Drawing.Size(455, 173);
            this.dataGridViewArtist.TabIndex = 11;
            // 
            // Artist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 443);
            this.Controls.Add(this.dataGridViewArtist);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonDisplay);
            this.Controls.Add(this.buttonAddArtist);
            this.Controls.Add(this.textBoxArtistFN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxArtistLN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCuratorID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxArtistID);
            this.Controls.Add(this.label1);
            this.Name = "Artist";
            this.Text = "Artist";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxArtistID;
        private System.Windows.Forms.TextBox textBoxCuratorID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxArtistLN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxArtistFN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAddArtist;
        private System.Windows.Forms.Button buttonDisplay;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.DataGridView dataGridViewArtist;
    }
}