namespace BookShopManagement
{
    partial class EditBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditBookForm));
            this.label7 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.txtEID = new System.Windows.Forms.TextBox();
            this.loadEImg = new System.Windows.Forms.LinkLabel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.picECover = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEPublisher = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtEYear = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtEAuthor = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtETitle = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.txtEprice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picECover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(372, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(225, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Edit  Info Of The Book";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.bunifuSeparator1.LineThickness = 144;
            this.bunifuSeparator1.Location = new System.Drawing.Point(63, 56);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(853, 10);
            this.bunifuSeparator1.TabIndex = 23;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            this.bunifuSeparator1.Load += new System.EventHandler(this.bunifuSeparator1_Load);
            // 
            // txtEID
            // 
            this.txtEID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEID.Location = new System.Drawing.Point(146, 90);
            this.txtEID.Name = "txtEID";
            this.txtEID.Size = new System.Drawing.Size(184, 20);
            this.txtEID.TabIndex = 37;
            // 
            // loadEImg
            // 
            this.loadEImg.AutoSize = true;
            this.loadEImg.Location = new System.Drawing.Point(786, 232);
            this.loadEImg.Name = "loadEImg";
            this.loadEImg.Size = new System.Drawing.Size(105, 21);
            this.loadEImg.TabIndex = 4;
            this.loadEImg.TabStop = true;
            this.loadEImg.Text = "Load Image";
            this.loadEImg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.loadEImg_LinkClicked);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(768, 266);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(123, 38);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "   Edit";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // picECover
            // 
            this.picECover.Location = new System.Drawing.Point(580, 155);
            this.picECover.Name = "picECover";
            this.picECover.Size = new System.Drawing.Size(183, 98);
            this.picECover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picECover.TabIndex = 36;
            this.picECover.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(493, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 21);
            this.label6.TabIndex = 26;
            this.label6.Text = "Cover:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 21);
            this.label4.TabIndex = 27;
            this.label4.Text = "Publisher:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 21);
            this.label2.TabIndex = 28;
            this.label2.Text = "Title:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(493, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 21);
            this.label5.TabIndex = 29;
            this.label5.Text = "Year:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 21);
            this.label3.TabIndex = 30;
            this.label3.Text = "Author:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(62, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 21);
            this.label8.TabIndex = 31;
            this.label8.Text = "ID:";
            // 
            // txtEPublisher
            // 
            this.txtEPublisher.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEPublisher.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtEPublisher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEPublisher.HintForeColor = System.Drawing.Color.Empty;
            this.txtEPublisher.HintText = "";
            this.txtEPublisher.isPassword = false;
            this.txtEPublisher.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtEPublisher.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.txtEPublisher.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtEPublisher.LineThickness = 3;
            this.txtEPublisher.Location = new System.Drawing.Point(145, 266);
            this.txtEPublisher.Margin = new System.Windows.Forms.Padding(4);
            this.txtEPublisher.Name = "txtEPublisher";
            this.txtEPublisher.Size = new System.Drawing.Size(339, 44);
            this.txtEPublisher.TabIndex = 2;
            this.txtEPublisher.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtEYear
            // 
            this.txtEYear.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEYear.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtEYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEYear.HintForeColor = System.Drawing.Color.Empty;
            this.txtEYear.HintText = "";
            this.txtEYear.isPassword = false;
            this.txtEYear.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtEYear.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.txtEYear.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtEYear.LineThickness = 3;
            this.txtEYear.Location = new System.Drawing.Point(555, 87);
            this.txtEYear.Margin = new System.Windows.Forms.Padding(4);
            this.txtEYear.Name = "txtEYear";
            this.txtEYear.Size = new System.Drawing.Size(118, 44);
            this.txtEYear.TabIndex = 3;
            this.txtEYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtEAuthor
            // 
            this.txtEAuthor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEAuthor.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtEAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEAuthor.HintForeColor = System.Drawing.Color.Empty;
            this.txtEAuthor.HintText = "";
            this.txtEAuthor.isPassword = false;
            this.txtEAuthor.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtEAuthor.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.txtEAuthor.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtEAuthor.LineThickness = 3;
            this.txtEAuthor.Location = new System.Drawing.Point(145, 203);
            this.txtEAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.txtEAuthor.Name = "txtEAuthor";
            this.txtEAuthor.Size = new System.Drawing.Size(339, 44);
            this.txtEAuthor.TabIndex = 1;
            this.txtEAuthor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtETitle
            // 
            this.txtETitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtETitle.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtETitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtETitle.HintForeColor = System.Drawing.Color.Empty;
            this.txtETitle.HintText = "";
            this.txtETitle.isPassword = false;
            this.txtETitle.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtETitle.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.txtETitle.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtETitle.LineThickness = 3;
            this.txtETitle.Location = new System.Drawing.Point(145, 138);
            this.txtETitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtETitle.Name = "txtETitle";
            this.txtETitle.Size = new System.Drawing.Size(339, 44);
            this.txtETitle.TabIndex = 0;
            this.txtETitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(66, 317);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(851, 191);
            this.dgv1.TabIndex = 38;
            this.dgv1.SelectionChanged += new System.EventHandler(this.dgv1_SelectionChanged);
            this.dgv1.Click += new System.EventHandler(this.dgv1_Click);
            // 
            // txtEprice
            // 
            this.txtEprice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEprice.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtEprice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEprice.HintForeColor = System.Drawing.Color.Empty;
            this.txtEprice.HintText = "";
            this.txtEprice.isPassword = false;
            this.txtEprice.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtEprice.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.txtEprice.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtEprice.LineThickness = 3;
            this.txtEprice.Location = new System.Drawing.Point(773, 87);
            this.txtEprice.Margin = new System.Windows.Forms.Padding(4);
            this.txtEprice.Name = "txtEprice";
            this.txtEprice.Size = new System.Drawing.Size(118, 44);
            this.txtEprice.TabIndex = 3;
            this.txtEprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(711, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 21);
            this.label1.TabIndex = 29;
            this.label1.Text = "Price:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnDeleteBook.FlatAppearance.BorderSize = 0;
            this.btnDeleteBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteBook.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteBook.ForeColor = System.Drawing.Color.White;
            this.btnDeleteBook.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteBook.Image")));
            this.btnDeleteBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteBook.Location = new System.Drawing.Point(625, 266);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(123, 38);
            this.btnDeleteBook.TabIndex = 39;
            this.btnDeleteBook.Text = "  Delete";
            this.btnDeleteBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteBook.UseVisualStyleBackColor = false;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // EditBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(969, 532);
            this.Controls.Add(this.btnDeleteBook);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.txtEID);
            this.Controls.Add(this.loadEImg);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.picECover);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtEPublisher);
            this.Controls.Add(this.txtEprice);
            this.Controls.Add(this.txtEYear);
            this.Controls.Add(this.txtEAuthor);
            this.Controls.Add(this.txtETitle);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.label7);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "EditBookForm";
            this.Text = "EditBookForm";
            this.Load += new System.EventHandler(this.EditBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picECover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.TextBox txtEID;
        private System.Windows.Forms.LinkLabel loadEImg;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.PictureBox picECover;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEPublisher;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEYear;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEAuthor;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtETitle;
        private System.Windows.Forms.DataGridView dgv1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEprice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteBook;
    }
}