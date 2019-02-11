using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BookStoreService
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде и файле конфигурации.
    public class Service : IService
    {
        BookStoreContext _context;
        public Service()
        {
            _context = new BookStoreContext();
        }
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
        public List<Author> SelectAuthors()
        {
            List<Author> authors = new List<Author>();
            foreach (var x in _context.Authors)
            {
                Author author = new Author();
                author.idAuthor = x.idAuthor;
                author.FIO = x.FIO;
                authors.Add(author);
            }
            return authors;
        }
        public void CreateAutor(string FIO)
        {
            Authors author = new Authors();
            author.FIO = FIO;
            _context.Authors.Add(author);
            _context.SaveChanges();
        }
        public List<AvailabilityBooks> AvailabilityBooks()
        {
            return _context.AvailabilityBooks.ToList();
        }
        public List<AvailabilityBooksInStore_Result> AutorsInStore( int idStore)
        {
            return _context.AvailabilityBooksInStore(idStore).ToList();
        }
        public Dictionary<int, string> StoreIdName()
        {
            Dictionary<int, string> stores = new Dictionary<int, string>();
            foreach (var x in _context.Stores)
                stores.Add(x.idStore, x.StoreName);
            return stores;
        }
        public void AddBook(Int64 ISBN, int idStore, int quantity)
        {
            _context.AddBook(ISBN, idStore, quantity);
        }

    }
}
