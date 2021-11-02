using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ToDo.Models;

namespace ToDo.Pages
{
    public class CreateModel : PageModel
    {
        private readonly AppDbContext _dbConnection;
        public ToDoItem Item { get; set; }
        public CreateModel(AppDbContext context)
        {
            _dbConnection = context;
        }

        public void OnGet()
        {
        }

        public void OnPost(ToDoItem item)
        {
            //Modelstate

            _dbConnection.ToDoItems.Add(item);
            _dbConnection.SaveChanges();
            Response.Redirect("Index");
        }
    }
}
