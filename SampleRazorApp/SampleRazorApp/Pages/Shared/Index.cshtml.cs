using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SampleRazorApp.Models;

namespace SampleRazorApp.Pages.Shared
{
    public class IndexModel : PageModel
    {
        private readonly SampleRazorApp.Models.SampleRazorAppContext _context;

        public IndexModel(SampleRazorApp.Models.SampleRazorAppContext context)
        {
            _context = context;
        }

        public IList<Message> Message { get;set; }

        public async Task OnGetAsync()
        {
            Message = await _context.Message
                .Include(m => m.Person).ToListAsync();
        }
    }
}
