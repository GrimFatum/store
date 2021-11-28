using System;

namespace Store
{
    /// <summary>
    /// Сущность книги
    /// </summary>
    public class Book
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int ID { get; }

        /// <summary>
        /// Название книги
        /// </summary>
        public string Title { get; }



        public Book(int id, string title)
        {
            ID = id;
            Title = title;
        }
    }
}
