using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int YearOfPublication { get; set; }
        public string Jenre {  get; set; }
        public bool IsReaden {  get; set; }

        public Book(string name, string author, int yearOfPublication, string jenre)
        {
            Name = name;
            Author = author;
            YearOfPublication = yearOfPublication;
            Jenre = jenre;
            IsReaden = false;
        }
    }
}
