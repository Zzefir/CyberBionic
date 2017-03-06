using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_2_
{
    class Book
    {
        Author author;
        Content content;
        Title title;

        void CreateBook()
        {
            this.author = new Author();
            this.title = new Title();
            this.content = new Content();
        }

        public Book (string author, string title, string content)
        {
            CreateBook();
            this.title.NewTitle = title;
            this.author.NewAuthor = author;
            this.content.NewContent = content;
        }

        public void Show()
        {
            this.title.Show();
            this.author.Show();
            this.content.Show();
        }

    }
}
