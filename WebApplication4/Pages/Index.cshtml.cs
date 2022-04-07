using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Data;
using WebApplication4.Models;

namespace WebApplication4.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        private readonly MemoryDbContext _ctx;

        [FromForm]
        public List<string> MyList { get; set; } = new List<string>();

        [FromForm]
        public string Item { get; set; }

        [FromForm]
        public SimpleModel mdl { get; set; }

        public IndexModel(ILogger<IndexModel> logger, MemoryDbContext ctx)
        {
            _logger = logger;
            _ctx = ctx;
        }

        public void OnGet()
        {
            ViewData["mdlCount"] = _ctx.SimpleModel.Count();
        }

        public void OnPost()
        {
            MyList.Add(Item);
            mdl.Name = Item;
            _ctx.Add(mdl);
            _ctx.SaveChanges();
        }
    }
}
