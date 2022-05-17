using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoListDeloitte.Models
{
    public class ToDo
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public bool IsChecked { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}