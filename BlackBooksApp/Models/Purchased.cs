using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BlackBooksApp.Models
{
    public class Purchased
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Display(Name = "Покупатель")]
        public int PurchaseId { get; set; }

        [Display(Name = "ISBN книги")]
        public int BookId { get; set; }

        [Display(Name = "Цена заказа")]
        public int OrderPrice { get; set; }

        [Display(Name = "Количество")]
        public int Number { get; set; }

        [Display(Name = "Итого")]
        public int Total
        {
            get
            {
                return OrderPrice * Number;
            }
        }

        public virtual Purchase Purchase { get; set; }
        public virtual Book Book { get; set; }
    }
}