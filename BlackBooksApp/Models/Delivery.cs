using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlackBooksApp.Models
{
    public class Delivery
    {
        /// <summary>Возвращает идентификатор службы доставки.</summary>
        public int Id { get; set; }

        /// <summary>Возвращает наименование службы доставки.</summary>
        [Display(Name = "Наименование")]
        public string Name { get; set; }

        /// <summary>Возвращает телефон службы доставки.</summary>
        [Display(Name = "Телефон")]
        public string Phone { get; set; }

        /// <summary>Возвращает стоимость доставки.</summary>
        [Display(Name = "Стоимость доставки")]
        public int Cost { get; set; }

        [Display(Name = "Заказы для данной службы доставки")]
        public virtual ICollection<Purchase> Purchases { get; set; }
    }
}