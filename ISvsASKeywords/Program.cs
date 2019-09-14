using System;

namespace ISvsASKeywords
{
    class Program
    {
        static void Main(string[] args)
        {

            //is
            var speaker = new Speaker { Name = "Gaurav Kumar Arora" };

            var isTrue = speaker is Speaker;
            Console.WriteLine("speaker is of Speaker type:{0}", isTrue);

            var author = new Author { Name = "Gaurav Kumar Arora" };
            var isTrue2 = speaker is Author;
            Console.WriteLine("speaker is of Author type:{0}", isTrue2);

            //as

            var speaker2 = new Speaker { Name = "Gaurav Kumar Arora" };
            var author2 = new Author { Name = "Gaurav Kumar Arora" };

            var authorName = GetAuthorName(author2);
            Console.WriteLine("Author name is:{0}", authorName);

            authorName = GetAuthorName(speaker);
            Console.WriteLine("Author name is:{0}", authorName);
        }

        public static string GetAuthorName(dynamic obj)
        {
            Author authorObj = obj as Author;
            return (authorObj != null) ? authorObj.Name : string.Empty;
        }
    }

    class Speaker
    {
        public string Name
        {
            get;
            set;
        }
    }
    class Author
    {
        public string Name
        {
            get;
            set;
        }
    }
}
