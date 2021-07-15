using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace SampleAuthApp.Pages
{
    public class FormData
    {
        [Required]
        public string Name { get; set; }
        public string Message { get; set; }

        public FormData()
        {
            Name = "";
            Message = "";
        }

        public FormData(string name, string msg)
        {
            Name = name;
            Message = msg;
        }
        public override string ToString()
        {
            return $"{{ {Name} ,\" {Message} \" }}"; 
        }
    }
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public string SampleData { get; set; }

        private ISampleDependency _sample;

        public IndexModel(ILogger<IndexModel> logger, ISampleDependency sample)
        {
            _logger = logger;
            _sample = sample;
        }

    

        public void OnGet()
        {
            //SampleData = HttpContext.Session.GetString("SampleData");
            SampleData = _sample.getData().ToString();
        }
    }
}
