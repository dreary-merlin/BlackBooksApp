using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlackBooksApp.Models
{
    public class PublishingHouse
    {
        /// <summary>Возвращает идентификатор издательства.</summary>
        public int Id { get; set; }

        /// <summary>Возвращает название издательства.</summary>
        [Display(Name = "Название")]
        public string Name { get; set; }

        /// <summary>Возвращает адрес издательства.</summary>
        [Display(Name = "Адрес")]
        public string Address { get; set; }

        /// <summary>Возвращает телефон издательства.</summary>
        [Display(Name = "Телефон")]
        public string Phone { get; set; }

        [Display(Name = "Книги данного издательства")]
        public virtual ICollection<Book> Books { get; set; }
    }
}