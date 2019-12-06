using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fall2019_pa_6
{
    public partial class formEdit : Form
    {
        private Book myBook;
        private string cwid;
        private string mode;

        public formEdit(Object tempBook, string tempMode, string tempCWID)
        {
            myBook = (Book)tempBook;
            cwid = tempCWID;
            mode = tempMode;
            InitializeComponent();
            pictureCover.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void FormEdit_Load(object sender, EventArgs e)
        {
            if (mode == "edit")
            {
                textTitle.Text = myBook.title;
                textAuthor.Text = myBook.author;
                textGenre.Text = myBook.genre;
                textCopies.Text = myBook.copies.ToString();
                textLength.Text = myBook.length.ToString();
                textISBN.Text = myBook.isbn;
                textCover.Text = myBook.cover;

                pictureCover.Load(myBook.cover);
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            myBook.title = textTitle.Text;
            myBook.author = textAuthor.Text;
            myBook.genre = textGenre.Text;
            myBook.copies = int.Parse(textCopies.Text);
            myBook.length = int.Parse(textLength.Text);
            myBook.isbn = textISBN.Text;
            myBook.cover = textCover.Text;
            myBook.cwid = cwid;

            BookFile.SaveBook(myBook, cwid, mode);

            MessageBox.Show("Content Saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
    }
}
