using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDo.Models;

namespace ToDo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public string Username { get; set; }

        public List<ToDoItem> Items { get; set; }

        private readonly AppDbContext _dbConnection;

        public IndexModel(ILogger<IndexModel> logger, AppDbContext _db)
        {
            _logger = logger;
            _dbConnection = _db;
        }

        public void OnGet()
        {
            Items = _dbConnection.ToDoItems.ToList();
            Username = "DefaultUser";
        }

        public void OnPost(string _username)
        {
            Username = _username;
        }
    }
}
