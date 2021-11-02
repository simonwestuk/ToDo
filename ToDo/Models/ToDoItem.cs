using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo.Models
{
    public class ToDoItem
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(150)]
        [Required]
        public string Desc { get; set; }

        [Required]
        public bool IsCompleted { get; set; }
    }
}
