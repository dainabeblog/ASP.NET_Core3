using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SampleRazorApp.Models;

namespace SampleRazorApp.Pages
{
    public class FindModel : PageModel
    {
        private readonly SampleRazorAppContext _context;
        public IList<Person> People { get; set; }

        public FindModel(SampleRazorAppContext context)
        {
            _context = context;
        }

        public string[] Pdata { get; set; }

        [BindProperty(SupportsGet = true)]
        public int p { get; set; }
        [BindProperty(SupportsGet = true)]
        public int n { get; set; }

        public async Task OnGetAsync()
        {
            Pdata = await _context.Person.Select(m => m.Name).ToArrayAsync();
            n = n <= 0 ? 3 : n;
            People = await _context.Person.OrderBy(m => m.Age)
                .Skip(p * n).Take(n).ToListAsync();
        }

        public async Task OnPostAsync(string Find)
        {
            Pdata = await _context.Person.Select(m => m.Name).ToArrayAsync();
            People = await _context.Person
                .Where(m =>m.Name.Contains(Find))
                .OrderBy(m => m.Age).ToListAsync();
        }
    }
}
