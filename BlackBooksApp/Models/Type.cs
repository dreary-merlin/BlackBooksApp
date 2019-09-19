using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlackBooksApp.Models
{
    public class Type
    {
        /// <summary>Возвращает идентификатор типа.</summary>
        public int Id { get; set; }

        /// <summary>Возвращает категорию.</summary>
        [Display(Name = "Категория")]
        public string Category { get; set; }

        /// <summary>Возвращает описание.</summary>
        [Display(Name = "Описание")]
        public string Description { get; set; }

        [Display(Name = "Книги данной категории")]
        public virtual ICollection<Book> Books { get; set; }
    }
}