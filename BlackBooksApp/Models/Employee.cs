using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlackBooksApp.Models
{
    public class Employee
    {
        /// <summary>Возвращает или задает идентификатор сотрудника.</summary>
        public int Id { get; set; }

        /// <summary>Возвращает или задает ФИО сотрудника.</summary>
        [Display(Name = "ФИО")]
        public string Name { get; set; }

        /// <summary>Возвращает или задает дату рождения сотрудника.</summary>
        [Display(Name = "Дата рождения")]
        public string Birthday { get; set; }

        /// <summary>Возвращает или задает адрес.</summary>
        [Display(Name = "Адрес")]
        public string Address { get; set; }

        /// <summary>Возвращает или задает телефон.</summary>
        [Display(Name = "Телефон")]
        public string Phone { get; set; }

        /// <summary>Возвращает или задает должность.</summary>
        [Display(Name = "Должность")]
        public string Position { get; set; }

        [Display(Name = "Заказы данного сотрудника")]
        public virtual ICollection<Purchase> Purchases { get; set; }
    }
}