using Library_of_books.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_of_books.Presenter.Interface
{
    interface IMainPrecenter
    {
      void GetAllBooks();
      void GetSelectedBook(int idBook);

      void SearchByName(string name);
      void SearchByAuthor(string author);
      void SearchByPublishingHouse(string publishingHouse);
      void SearchByPublishingYear(string publishingYear);

      

      void DeleteSelectedBook(int idBook);

      string ChangeBookInfo(Book book);

      string CreateNewBook(Book book);
     
    }
}
