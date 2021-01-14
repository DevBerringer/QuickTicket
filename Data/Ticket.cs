using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace QuickTicket.Data
{
    public class Ticket
    {
        [Key]
        public int ticket_id { get; set; }

        [Required]
        public string Content  { get; set; }

        //public bit Status { get; set; }

        public string priority { get; set; }

        public DateTime PublishDate { get; set; }
    }
}