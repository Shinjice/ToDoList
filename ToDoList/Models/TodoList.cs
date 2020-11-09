using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    [IgnoreAntiforgeryToken(Order = 1001)]
    public class TodoList 
    {
        public int Id { get; set; }
        [Required]
        public string Content { get; set; }
    }
}
