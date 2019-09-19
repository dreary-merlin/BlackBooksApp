using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlackBooksApp.Models
{
    public class Supplier
    {
        /// <summary>Возвращает идентификатор поставщика.</summary>
        public int Id { get; set; }

        /// <summary>Возвращает имя поставщика.</summary>
        [Display(Name = "Наименование")]
        public string Name { get; set; }

        /// <summary>Возвращает контактное лицо компании.</summary>
        [Display(Name = "Контактное лицо")]
        public string ContactPerson { get; set; }

        /// <summary>Возвращает должность контактного лица компании.</summary>
        [Display(Name = "Должность")]
        public string Position { get; set; }

        /// <summary>Возвращает юридический адрес поставщика.</summary>
        [Display(Name = "Юридический адрес")]
        public string Address { get; set; }

        /// <summary>Возвращает телефон поставщика.</summary>
        [Display(Name = "Телефон")]
        public string Phone { get; set; }

        /// <summary>Возвращает дополнительные сведения о поставщике.</summary>
        [Display(Name = "О компании")]
        public string AboutCompany { get; set; }

        [Display(Name = "Книги от данного поставщика")]
        public virtual ICollection<Book> Books { get; set; }
    }
}