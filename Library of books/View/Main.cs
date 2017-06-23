using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library_of_books.View.Interface;
using Library_of_books.Model;
using Library_of_books.Presenter.Interface;


namespace Library_of_books
{
    partial class fmMain : Form, IMainForm
    {
        List<string> nameBooks;
        List<string> authorBooks;
        List<string> publishingHouse;
        List<string> publishingYear;

        IMainPrecenter presenter
        {
            get;
            set;
        }

        DataTable table;

        public fmMain()
        {
            InitializeComponent();

            StartConfiguration();
        }

        private void StartConfiguration()
        {          

            nameBooks = new List<string>();
            authorBooks = new List<string>();
            publishingHouse = new List<string>();
            publishingYear = new List<string>();


            table = new DataTable();

            table.Columns.Add("Name book",typeof(string)); 
            table.Columns.Add("Author", typeof(string));
            table.Columns.Add("Publishing house", typeof(string));
            table.Columns.Add("Publishing year", typeof(string));
            table.Columns.Add("Code", typeof(string));

            dgvShowingField.DataSource = table;
                        
            dgvShowingField.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

           
        }

        #region Buttons

        private void bnAddNewData_Click(object sender, EventArgs e)
        {
            Book newBook = new Book(tbNameBook.Text,
                                    tbAuthor.Text,
                                    tbPublishingHouse.Text,
                                    tbPublishingYear.Text,
                                    tbDescription.Text,
                                    0);
            var returnText =  presenter.CreateNewBook(newBook);
            MessageBox.Show(returnText);
        }

        private void bnChangeData_Click(object sender, EventArgs e)
        {
            Book newBook = new Book(tbNameBook.Text,
                                    tbAuthor.Text,
                                    tbPublishingHouse.Text,
                                    tbPublishingYear.Text,
                                    tbDescription.Text,
                                    Int32.Parse(lbID.Text));
            var returnText = presenter.ChangeBookInfo(newBook);
            MessageBox.Show(returnText);
        }
        
        private void bnDeleteData_Click(object sender, EventArgs e)
        {
            presenter.DeleteSelectedBook(Int32.Parse(lbID.Text));
            presenter.GetAllBooks();


            tbNameBook.Text = "";
            tbAuthor.Text = "";
            tbPublishingHouse.Text = "";
            tbPublishingYear.Text = "";
            tbDescription.Text = "";
        }

        private void bnShowAllBook_Click(object sender, EventArgs e)
        {
            presenter.GetAllBooks();
        }
       
        #endregion
        
        #region Search

        private void tbSearchAutor_TextChanged(object sender, EventArgs e)
        {
            presenter.SearchByAuthor(tbSearchAutor.Text);
        }

        private void tbSearchName_TextChanged(object sender, EventArgs e)
        {
            presenter.SearchByName(tbSearchName.Text);
        }

        private void tbSearchPublishingHouse_TextChanged(object sender, EventArgs e)
        {
            if (tbSearchPublishingHouse.Text != "")
            {
                presenter.SearchByPublishingHouse(tbSearchPublishingHouse.Text);
            }
            if (tbSearchPublishingHouse.Text == "")
            {
                MessageBox.Show("You don`t enter any name of publishing house");
            }
        }

        private void tbSearchPublishingYear_TextChanged(object sender, EventArgs e)
        {
            presenter.SearchByPublishingYear(tbSearchPublishingYear.Text);
        }

        private void cbSearchAuthor_DropDownClosed(object sender, EventArgs e)
        {
            if (cbSearchAuthor.SelectedIndex != -1)
            {
                tbSearchAutor.Text = cbSearchAuthor.SelectedItem.ToString();
            }
        }


        private void dgvShowingField_DoubleClick(object sender, EventArgs e)
        {
            presenter.GetSelectedBook(Int32.Parse( dgvShowingField.CurrentRow.Cells[3].Value.ToString()) );
        }
        #endregion
       
        void IMainForm.SetLoadedBooks(List<Book> books)
        {
            authorBooks.Clear();
            cbSearchAuthor.DataSource = null;
            table.Rows.Clear();

            foreach (Book book in books)
            {
                table.Rows.Add(book.NameBook,book.Author, book.PublishingHouse,book.PublishingYear,book.ID);

                nameBooks.Add(book.NameBook);                
                publishingHouse.Add(book.PublishingHouse);
                publishingYear.Add(book.PublishingYear);

                if (!authorBooks.Cast<string>().Any(cbi => cbi.Equals(book.Author)))
                {
                    authorBooks.Add(book.Author);
                }
            }

            dgvShowingField.DataSource = table;

            cbSearchAuthor.DataSource = authorBooks;
            cbSearchAuthor.SelectedIndex = -1;
        }
        
        void IMainForm.SetSelectedBook(Book book)
        {        

            tbNameBook.Text = book.NameBook;
            tbAuthor.Text = book.Author;
            tbPublishingHouse.Text = book.PublishingHouse;
            tbPublishingYear.Text = book.PublishingYear;
            tbDescription.Text = book.Description;
            lbID.Text = book.ID.ToString();

        }
               

        public new void Show(IMainPrecenter newPresenter)
        {
            presenter = newPresenter;
            Application.Run(this);
        }

        
    }
}