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
    public partial class formMain : Form
    {
        string cwid;
        List<Book> myBooks;

        public formMain(string temp)
        {
            this.cwid = temp;
            InitializeComponent();
            pictureCover.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        private void LoadList()
        {
            myBooks = BookFile.GetAllBooks(cwid);
            listBooks.DataSource = myBooks;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            Book myBook = (Book)listBooks.SelectedItem;

            textTitle.Text = myBook.title;
            textAuthor.Text = myBook.author;
            textGenre.Text = myBook.genre;
            textCopies.Text = myBook.copies.ToString();
            textISBN.Text = myBook.isbn;
            textLength.Text = myBook.length.ToString();

            try
            {
                pictureCover.Load(myBook.cover);
            }
            catch
            {

            }
        }

        private void ButtonRent_Click(object sender, EventArgs e)
        {
            Book myBook = (Book)listBooks.SelectedItem;

            myBook.copies--;
            BookFile.SaveBook(myBook, cwid, "edit");
            LoadList();
        }

        private void ButtonReturn_Click(object sender, EventArgs e)
        {
            Book myBook = (Book)listBooks.SelectedItem;

            myBook.copies++;
            BookFile.SaveBook(myBook, cwid, "edit");
            LoadList();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            Book myBook = (Book)listBooks.SelectedItem;

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete?", "Delete", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                BookFile.DeleteBook(myBook, cwid);
                LoadList();
            }
        }
    }
}
