namespace CGS_Database
{
    partial class Curator
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCurID = new System.Windows.Forms.TextBox();
            this.textBoxLN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxComm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAddCur = new System.Windows.Forms.Button();
            this.dataGridViewCur = new System.Windows.Forms.DataGridView();
            this.buttonDisplay = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCur)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Curator ID:";
            // 
            // textBoxCurID
            // 
            this.textBoxCurID.Location = new System.Drawing.Point(165, 36);
            this.textBoxCurID.Name = "textBoxCurID";
            this.textBoxCurID.Size = new System.Drawing.Size(259, 22);
            this.textBoxCurID.TabIndex = 1;
            // 
            // textBoxLN
            // 
            this.textBoxLN.Location = new System.Drawing.Point(165, 112);
            this.textBoxLN.Name = "textBoxLN";
            this.textBoxLN.Size = new System.Drawing.Size(259, 22);
            this.textBoxLN.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name:";
            // 
            // textBoxFN
            // 
            this.textBoxFN.Location = new System.Drawing.Point(165, 73);
            this.textBoxFN.Name = "textBoxFN";
            this.textBoxFN.Size = new System.Drawing.Size(259, 22);
            this.textBoxFN.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "First Name:";
            // 
            // textBoxComm
            // 
            this.textBoxComm.Location = new System.Drawing.Point(165, 152);
            this.textBoxComm.Name = "textBoxComm";
            this.textBoxComm.Size = new System.Drawing.Size(259, 22);
            this.textBoxComm.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Commission:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(28, 191);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(92, 36);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAddCur
            // 
            this.buttonAddCur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddCur.Location = new System.Drawing.Point(290, 191);
            this.buttonAddCur.Name = "buttonAddCur";
            this.buttonAddCur.Size = new System.Drawing.Size(134, 36);
            this.buttonAddCur.TabIndex = 9;
            this.buttonAddCur.Text = "Add curator";
            this.buttonAddCur.UseVisualStyleBackColor = true;
            this.buttonAddCur.Click += new System.EventHandler(this.buttonAddCur_Click);
            // 
            // dataGridViewCur
            // 
            this.dataGridViewCur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCur.Location = new System.Drawing.Point(12, 242);
            this.dataGridViewCur.Name = "dataGridViewCur";
            this.dataGridViewCur.RowHeadersWidth = 51;
            this.dataGridViewCur.RowTemplate.Height = 24;
            this.dataGridViewCur.Size = new System.Drawing.Size(435, 218);
            this.dataGridViewCur.TabIndex = 10;
            this.dataGridViewCur.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCur_CellContentClick);
            // 
            // buttonDisplay
            // 
            this.buttonDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisplay.Location = new System.Drawing.Point(192, 191);
            this.buttonDisplay.Name = "buttonDisplay";
            this.buttonDisplay.Size = new System.Drawing.Size(92, 36);
            this.buttonDisplay.TabIndex = 11;
            this.buttonDisplay.Text = "Display";
            this.buttonDisplay.UseVisualStyleBackColor = true;
            this.buttonDisplay.Click += new System.EventHandler(this.buttonDisplay_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Curator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 468);
            this.Controls.Add(this.buttonDisplay);
            this.Controls.Add(this.dataGridViewCur);
            this.Controls.Add(this.buttonAddCur);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxComm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxFN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxLN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCurID);
            this.Controls.Add(this.label1);
            this.Name = "Curator";
            this.Text = "Curator";
            this.Load += new System.EventHandler(this.Curator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCurID;
        private System.Windows.Forms.TextBox textBoxLN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxComm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAddCur;
        private System.Windows.Forms.DataGridView dataGridViewCur;
        private System.Windows.Forms.Button buttonDisplay;
        private System.Windows.Forms.Timer timer1;
    }
}