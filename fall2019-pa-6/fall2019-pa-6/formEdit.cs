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
    }
}
