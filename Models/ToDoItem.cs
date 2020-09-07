using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoV2.Models
{
    public class ToDoItem
    {
        public int Id { get; set; }

        [StringLength(255)]
        public string Text { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreatedOn { get; set; }

        public bool Done { get; set; }

        public int Order { get; set; }
    }
}
