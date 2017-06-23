using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_of_books.Presenter.Interface;
using Library_of_books.Model.Interface;
using Library_of_books.View.Interface;
using Library_of_books.Model;

namespace Library_of_books.Presenter
{
    class MainPresenter: IMainPrecenter
    {
        private readonly IMainForm formView;
        private readonly IMainFormFunction formModel;

        string incorrectCharacter = " ,.!@#$%^&*()_-+=<>";

        public MainPresenter(IMainForm mainFormView, IMainFormFunction mainFormModel)
        {
            formModel = mainFormModel;
            formView = mainFormView;
            
            
            LoadData();
        }


        void LoadData()
        {
            var loadedData = formModel.LoadBooks();
            formView.SetLoadedBooks(loadedData);
        }

        public void Run()
        {
            formView.Show(this);
        }



        void IMainPrecenter.GetAllBooks()
        {
            var loadedData = formModel.LoadBooks();
            formView.SetLoadedBooks(loadedData);
        }
        void IMainPrecenter.GetSelectedBook(int idBook)
        {
            var selectedBook = formModel.SetSelectedBook(idBook);
            formView.SetSelectedBook(selectedBook);
        }

        void IMainPrecenter.SearchByName(string name)
        {
            var resaltSearch = formModel.SearchByName(name);
            formView.SetLoadedBooks(resaltSearch);
        }
        void IMainPrecenter.SearchByAuthor(string author)
        {
            var resaltSearch = formModel.SearchByAuthor(author);
            formView.SetLoadedBooks(resaltSearch);
        }
        void IMainPrecenter.SearchByPublishingHouse(string publishingHouse)
        {
            var resaltSearch = formModel.SearchByPublishingHouse(publishingHouse);
            formView.SetLoadedBooks(resaltSearch);
        }
        void IMainPrecenter.SearchByPublishingYear(string publishingYear)
        {
            var resaltSearch = formModel.SearchByPublishingYear(publishingYear);
            formView.SetLoadedBooks(resaltSearch);
        }

        void IMainPrecenter.DeleteSelectedBook(int idBook)
        {
            formModel.DeleteBook(idBook);            
        }

        string IMainPrecenter.ChangeBookInfo(Book book)
        {
            var resaltText = "Information has been chenged";
            var shouldChange = IsBookCorrect(book);

            if (shouldChange)
            {
                formModel.ChangeBookInfo(book);
            }
            if(!shouldChange)
            {
                resaltText = "Sending wronge, information hasn`t chenged";
            }
            return resaltText;
        }

        string IMainPrecenter.CreateNewBook(Book book)
        {
            var returnText = "Book successful added";
            var shouldAdd = IsBookCorrect(book);

            if (shouldAdd)
            {
                formModel.CreateNewBook(book);

                var loadedData = formModel.LoadBooks();
                formView.SetLoadedBooks(loadedData);
            }
            if (!shouldAdd)
            {
                returnText = "You entered incorrect information. Book don`t added";
            }

            return returnText;
        }


        private bool IsBookCorrect(Book book)
        {
            bool resalt = true;

            var loadedData = formModel.LoadBooks();
            foreach (Book b in loadedData)
            {
                if (book.NameBook == b.NameBook && book.Author == b.Author && book.PublishingHouse == b.PublishingHouse &&
                    book.PublishingYear == b.PublishingYear && book.Description == b.Description)
                {
                    resalt = false;
                    break;
                }
                if (book.NameBook == "" || book.Author == "" || book.PublishingHouse == "" ||
                    book.PublishingYear == "" || book.Description == "")
                {
                    resalt = false;
                    break;
                }
            }

            if(resalt)
            {
                foreach (char c in incorrectCharacter)
                {
                    if (book.NameBook == c.ToString() || book.Author == c.ToString() || book.PublishingHouse == c.ToString() ||
                        book.PublishingYear == c.ToString() || book.Description == c.ToString())
                    {
                        resalt = false;
                        break;
                    }
                }
            }
               

            return resalt;
        }
    }
}
