using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_of_books.Model.Interface;

namespace Library_of_books.Model
{
    class MainFormFunction:IMainFormFunction
    {
        List<Book> Books;
        int nextID = 1;

        public MainFormFunction()
        {
            Books = new List<Book>();
            Books.Add(new Book("The Giver ", "Lois Lowry", "PublishingHouse_1","2015","Description",nextID) );
            nextID++;
            Books.Add(new Book("The Hobbit ", " J.R.R. Tolkien", "Houghton Mifflin ", "2002", "In a hole in the ground there lived a hobbit. Not a nasty, dirty, wet hole, filled with the ends of worms and an oozy smell, nor yet a dry, bare, sandy hole with nothing in it to sit down on or to eat: it was a hobbit-hole, and that means comfort.", nextID));
            nextID++;
            Books.Add(new Book("Royal Assassin", "Robin Hobb ", "Spectra", "2002", "Fitz has survived his first hazardous mission as king’s assassin, but is left little more than a cripple. Battered and bitter, he vows to abandon his oath to King Shrewd, remaining in the distant mountains. But love and events of terrible urgency draw him back to the court at Buckkeep, and into the deadly intrigues of the royal family.", nextID));
            nextID++;
            Books.Add(new Book("Lord of Emperors", "Guy Gavriel Kay", "2001", "Harper Voyager", "Beckoned by the Emperor Valerius, Crispin, a renowned mosaicist, has arrived in the fabled city of Sarantium. Here he seeks to fulfill his artistic ambitions and his destiny high upon a dome that will become the emerror's magnificent sanctuary and legacy.", nextID));
            nextID++;
            Books.Add(new Book("Dracula", " Bram Stoker", "W.W. Norton & Company", "1986", "A rich selection of background and source materials is provided in three areas: Contexts includes probable inspirations for Dracula in the earlier works of James Malcolm Rymer and Emily Gerard. Also included are a discussion of Stoker's working notes for the novel and Dracula's Guest, the original open", nextID));
            nextID++;
        }


        List<Book> IMainFormFunction.LoadBooks()
        {
            return Books;
        }

        List<Book> IMainFormFunction.SearchByName(string name)
        {
            var returnList = Books.FindAll(s => s.NameBook == name);
            return returnList;
        }
        List<Book> IMainFormFunction.SearchByAuthor(string author)
        {
            var returnList = Books.FindAll(s => s.Author == author);
            return returnList;
        }
        List<Book> IMainFormFunction.SearchByPublishingHouse(string publishingHouse)
        {
            var returnList = Books.FindAll(s => s.PublishingHouse == publishingHouse);
            return returnList;
        }
        List<Book> IMainFormFunction.SearchByPublishingYear(string publishingYear)
        {
            var returnList = Books.FindAll(s => s.PublishingYear == publishingYear);
            return returnList;
        }

        Book IMainFormFunction.SetSelectedBook(int idBook)
        {
            var selectedBook = Books.Find(b=> b.ID == idBook);
            return selectedBook;
        }
        
        void IMainFormFunction.DeleteBook(int idBook)
        {
            for (int i=0; i<Books.Count; i++)
            {
                if (Books[i].ID == idBook)
                {
                    Books.RemoveAt(i);
                    break;
                }
            }
        }

        void IMainFormFunction.ChangeBookInfo(Book book)
        {
            for(int i=0;i<Books.Count;i++)
            {
                if (Books[i].ID == book.ID)
                {
                    Books[i] = book;
                    break;
                }
            }

           
        }
        void IMainFormFunction.CreateNewBook(Book book)
        {
            book.ID = nextID;
            Books.Add(book);
            nextID++;
        }
    }
}
