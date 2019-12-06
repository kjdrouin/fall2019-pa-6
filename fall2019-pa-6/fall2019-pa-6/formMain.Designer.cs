namespace fall2019_pa_6
{
    partial class formMain
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.textTitle = new System.Windows.Forms.TextBox();
            this.textAuthor = new System.Windows.Forms.TextBox();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.textGenre = new System.Windows.Forms.TextBox();
            this.labelGenre = new System.Windows.Forms.Label();
            this.textCopies = new System.Windows.Forms.TextBox();
            this.labelCopies = new System.Windows.Forms.Label();
            this.textISBN = new System.Windows.Forms.TextBox();
            this.labelISBN = new System.Windows.Forms.Label();
            this.textLength = new System.Windows.Forms.TextBox();
            this.labelLength = new System.Windows.Forms.Label();
            this.listBooks = new System.Windows.Forms.ListBox();
            this.pictureCover = new System.Windows.Forms.PictureBox();
            this.buttonRent = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCover)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(317, 35);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(38, 20);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Title";
            // 
            // textTitle
            // 
            this.textTitle.Location = new System.Drawing.Point(321, 58);
            this.textTitle.Name = "textTitle";
            this.textTitle.Size = new System.Drawing.Size(182, 26);
            this.textTitle.TabIndex = 1;
            // 
            // textAuthor
            // 
            this.textAuthor.Location = new System.Drawing.Point(321, 121);
            this.textAuthor.Name = "textAuthor";
            this.textAuthor.Size = new System.Drawing.Size(182, 26);
            this.textAuthor.TabIndex = 3;
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(317, 98);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(57, 20);
            this.labelAuthor.TabIndex = 2;
            this.labelAuthor.Text = "Author";
            // 
            // textGenre
            // 
            this.textGenre.Location = new System.Drawing.Point(321, 187);
            this.textGenre.Name = "textGenre";
            this.textGenre.Size = new System.Drawing.Size(182, 26);
            this.textGenre.TabIndex = 5;
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(317, 164);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(54, 20);
            this.labelGenre.TabIndex = 4;
            this.labelGenre.Text = "Genre";
            // 
            // textCopies
            // 
            this.textCopies.Location = new System.Drawing.Point(321, 251);
            this.textCopies.Name = "textCopies";
            this.textCopies.Size = new System.Drawing.Size(182, 26);
            this.textCopies.TabIndex = 7;
            // 
            // labelCopies
            // 
            this.labelCopies.AutoSize = true;
            this.labelCopies.Location = new System.Drawing.Point(317, 228);
            this.labelCopies.Name = "labelCopies";
            this.labelCopies.Size = new System.Drawing.Size(125, 20);
            this.labelCopies.TabIndex = 6;
            this.labelCopies.Text = "Copies Available";
            // 
            // textISBN
            // 
            this.textISBN.Location = new System.Drawing.Point(321, 309);
            this.textISBN.Name = "textISBN";
            this.textISBN.Size = new System.Drawing.Size(182, 26);
            this.textISBN.TabIndex = 9;
            // 
            // labelISBN
            // 
            this.labelISBN.AutoSize = true;
            this.labelISBN.Location = new System.Drawing.Point(317, 286);
            this.labelISBN.Name = "labelISBN";
            this.labelISBN.Size = new System.Drawing.Size(47, 20);
            this.labelISBN.TabIndex = 8;
            this.labelISBN.Text = "ISBN";
            // 
            // textLength
            // 
            this.textLength.Location = new System.Drawing.Point(321, 372);
            this.textLength.Name = "textLength";
            this.textLength.Size = new System.Drawing.Size(182, 26);
            this.textLength.TabIndex = 11;
            // 
            // labelLength
            // 
            this.labelLength.AutoSize = true;
            this.labelLength.Location = new System.Drawing.Point(317, 349);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(59, 20);
            this.labelLength.TabIndex = 10;
            this.labelLength.Text = "Length";
            // 
            // listBooks
            // 
            this.listBooks.FormattingEnabled = true;
            this.listBooks.ItemHeight = 20;
            this.listBooks.Location = new System.Drawing.Point(12, 35);
            this.listBooks.Name = "listBooks";
            this.listBooks.Size = new System.Drawing.Size(281, 364);
            this.listBooks.TabIndex = 12;
            this.listBooks.SelectedIndexChanged += new System.EventHandler(this.ListBooks_SelectedIndexChanged);
            // 
            // pictureCover
            // 
            this.pictureCover.Location = new System.Drawing.Point(578, 35);
            this.pictureCover.Name = "pictureCover";
            this.pictureCover.Size = new System.Drawing.Size(228, 277);
            this.pictureCover.TabIndex = 13;
            this.pictureCover.TabStop = false;
            // 
            // buttonRent
            // 
            this.buttonRent.Location = new System.Drawing.Point(578, 375);
            this.buttonRent.Name = "buttonRent";
            this.buttonRent.Size = new System.Drawing.Size(93, 71);
            this.buttonRent.TabIndex = 14;
            this.buttonRent.Text = "Rent";
            this.buttonRent.UseVisualStyleBackColor = true;
            this.buttonRent.Click += new System.EventHandler(this.ButtonRent_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(713, 375);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(93, 71);
            this.buttonReturn.TabIndex = 15;
            this.buttonReturn.Text = "Return";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.ButtonReturn_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(337, 477);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(93, 28);
            this.buttonNew.TabIndex = 16;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(457, 477);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(93, 28);
            this.buttonEdit.TabIndex = 17;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(578, 477);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(97, 28);
            this.buttonDelete.TabIndex = 18;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(713, 477);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(93, 28);
            this.buttonClose.TabIndex = 19;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 524);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonRent);
            this.Controls.Add(this.pictureCover);
            this.Controls.Add(this.listBooks);
            this.Controls.Add(this.textLength);
            this.Controls.Add(this.labelLength);
            this.Controls.Add(this.textISBN);
            this.Controls.Add(this.labelISBN);
            this.Controls.Add(this.textCopies);
            this.Controls.Add(this.labelCopies);
            this.Controls.Add(this.textGenre);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.textAuthor);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.textTitle);
            this.Controls.Add(this.labelTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "formMain";
            this.Text = "Audio Book Rental System";
            this.Load += new System.EventHandler(this.formMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textTitle;
        private System.Windows.Forms.TextBox textAuthor;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.TextBox textGenre;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.TextBox textCopies;
        private System.Windows.Forms.Label labelCopies;
        private System.Windows.Forms.TextBox textISBN;
        private System.Windows.Forms.Label labelISBN;
        private System.Windows.Forms.TextBox textLength;
        private System.Windows.Forms.Label labelLength;
        private System.Windows.Forms.ListBox listBooks;
        private System.Windows.Forms.PictureBox pictureCover;
        private System.Windows.Forms.Button buttonRent;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonClose;
    }
}