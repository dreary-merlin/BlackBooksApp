using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlackBooksApp.Models
{
    public class Client
    {
        /// <summary>Возвращает или задет идентификатор клиента.</summary>
        public int Id { get; set; }

        /// <summary>Возвращает или задает ФИО или наименование организации.</summary>
        [Display(Name = "ФИО")]
        public string Name { get; set; }

        /// <summary>Возвращает или задает дату рождения клиента.</summary>
        [Display(Name = "Дата рождения")]
        public string Birthday { get; set; }

        /// <summary>Возвращает или задает адрес клиента.</summary>
        [Display(Name = "Адрес")]
        public string Address { get; set; }

        /// <summary>Возвращает или задает телефон клиента.</summary>
        [Display(Name = "Телефон")]
        public string Phone { get; set; }

        [Display(Name = "Заказы от данного клиента")]
        public virtual ICollection<Purchase> Purchases { get; set; }
    }
}