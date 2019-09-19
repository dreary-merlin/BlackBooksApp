using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlackBooksApp.Models
{
    public class Book
    {
        /// <summary>Возвращает идентификатор книги.</summary>
        public int Id { get; set; }

        /// <summary>Возвращает идентификатор издательства.</summary>
        [Display(Name = "Издательство")]
        public int PublishingHouseId { get; set; }

        /// <summary>Возвращает идентификатор поставщика.</summary>
        [Display(Name = "Поставщик")]
        public int SupplierId { get; set; }

        /// <summary>Возвращает ISBN книги.</summary>
        [Display(Name = "ISBN")]
        public string ISBN { get; set; }

        /// <summary>Возвращает наименование книги.</summary>
        [Display(Name = "Наименование")]
        public string Name { get; set; }

        /// <summary>Возвращает автора книги.</summary>
        [Display(Name = "Автор")]
        public string Author { get; set; }

        /// <summary>Возвращает тип книги.</summary>
        [Display(Name = "Категория жанра")]
        public int TypeId { get; set; }

        /// <summary>Возвращает жанр книги.</summary>
        [Display(Name = "Жанр")]
        public string Genre { get; set; }

        /// <summary>Возвращает год издания книги.</summary>
        [Display(Name = "Год издания")]
        public int PublishingYear { get; set; }

        /// <summary>Возвращает количество страниц.</summary>
        [Display(Name = "Количество страниц")]
        public int Pages { get; set; }

        /// <summary>Возвращает тип обложки книги.</summary>
        [Display(Name = "Тип обложки")]
        public string CoverType { get; set; }

        /// <summary>Возвращает цену книги.</summary>
        [Display(Name = "Цена книги")]
        public int BookPrice { get; set; }

        /// <summary>Возвращает дату поставки.</summary>
        [Display(Name = "Дата поставки")]
        public string SupplyDate { get; set; }

        /// <summary>Возвращает остаток.</summary>
        [Display(Name = "Остаток")]
        public int Rest { get; set; }

        public virtual PublishingHouse PublishingHouse { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual Type Type { get; set; }
        public virtual ICollection<Purchased> PurchasedBooks { get; set; }
    }
}