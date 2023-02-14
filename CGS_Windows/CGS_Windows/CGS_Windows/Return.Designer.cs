namespace CGS_Windows
{
    partial class Return
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
            this.textBoxPieceReturn = new System.Windows.Forms.TextBox();
            this.listViewPieces = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonReplace = new System.Windows.Forms.Button();
            this.buttonShowReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Art Piece ID:";
            // 
            // textBoxPieceReturn
            // 
            this.textBoxPieceReturn.Location = new System.Drawing.Point(162, 43);
            this.textBoxPieceReturn.Name = "textBoxPieceReturn";
            this.textBoxPieceReturn.Size = new System.Drawing.Size(166, 22);
            this.textBoxPieceReturn.TabIndex = 1;
            // 
            // listViewPieces
            // 
            this.listViewPieces.HideSelection = false;
            this.listViewPieces.Location = new System.Drawing.Point(12, 116);
            this.listViewPieces.Name = "listViewPieces";
            this.listViewPieces.Size = new System.Drawing.Size(391, 97);
            this.listViewPieces.TabIndex = 2;
            this.listViewPieces.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Art Piece info";
            // 
            // buttonReturn
            // 
            this.buttonReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturn.Location = new System.Drawing.Point(162, 246);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(99, 41);
            this.buttonReturn.TabIndex = 4;
            this.buttonReturn.Text = "Return";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Replace:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(105, 325);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(166, 22);
            this.textBox2.TabIndex = 6;
            // 
            // buttonReplace
            // 
            this.buttonReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReplace.Location = new System.Drawing.Point(286, 318);
            this.buttonReplace.Name = "buttonReplace";
            this.buttonReplace.Size = new System.Drawing.Size(99, 34);
            this.buttonReplace.TabIndex = 7;
            this.buttonReplace.Text = "Replace";
            this.buttonReplace.UseVisualStyleBackColor = true;
            // 
            // buttonShowReturn
            // 
            this.buttonShowReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowReturn.Location = new System.Drawing.Point(304, 219);
            this.buttonShowReturn.Name = "buttonShowReturn";
            this.buttonShowReturn.Size = new System.Drawing.Size(99, 34);
            this.buttonShowReturn.TabIndex = 8;
            this.buttonShowReturn.Text = "Show";
            this.buttonShowReturn.UseVisualStyleBackColor = true;
            this.buttonShowReturn.Click += new System.EventHandler(this.buttonShowReturn_Click);
            // 
            // Return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(415, 411);
            this.Controls.Add(this.buttonShowReturn);
            this.Controls.Add(this.buttonReplace);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listViewPieces);
            this.Controls.Add(this.textBoxPieceReturn);
            this.Controls.Add(this.label1);
            this.Name = "Return";
            this.Text = "Return";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPieceReturn;
        private System.Windows.Forms.ListView listViewPieces;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonReplace;
        private System.Windows.Forms.Button buttonShowReturn;
    }
}