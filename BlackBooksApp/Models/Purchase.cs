using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BlackBooksApp.Models
{
    public class Purchase
    {
        /// <summary>Возвращает идентификатор заказа.</summary>
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        /// <summary>Возвращает идентификатор сотрудника.</summary>
        [Display(Name = "Сотрудник")]
        public int EmployeeId { get; set; }

        /// <summary>Возвращает идентификатор клиента.</summary>
        [Display(Name = "Клиент")]
        public int ClientId { get; set; }

        /// <summary>Возвращает идентификатор службы доставки.</summary>
        [Display(Name = "Служба доставки")]
        public int DeliveryId { get; set; }

        /// <summary>Возвращает дату заказа.</summary>
        [Display(Name = "Дата заказа")]
        public string Ordate { get; set; }

        /// <summary>Возвращает адрес доставки.</summary>
        [Display(Name = "Адрес доставки")]
        public string Address { get; set; }

        /// <summary>Возвращает стоимость доставки.</summary>
        [Display(Name = "Стоимость доставки")]
        public int Delcost { get; set; }

        /// <summary>Возвращает дату продажи.</summary>
        [Display(Name = "Дата продажи")]
        public string Saledate { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Client Client { get; set; }
        public virtual Delivery Delivery { get; set; }

        [Display(Name = "Заказанные книги")]
        public virtual ICollection<Purchased> PurchasedBooks { get; set; }
    }
}