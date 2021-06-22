using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;

namespace SampleRazorApp.Pages
{
    public class IndexModel : PageModel
    {

        
        public string Message { get; set; } = "sample message";

        //[DataType(DataType.Text)]
        //public string Name { get; set; }

        //[DataType(DataType.Password)]
        //public string Password { get; set; }

        //[DataType(DataType.EmailAddress)]
        //public string Mail { get; set; }

        //[DataType(DataType.PhoneNumber)]
        //public string Tel { get; set; }


        //public void OnGet()
        //{
        //    Message = "入力していください。";
        //}

        //public void OnPost(string name, string password, string mail, string tel)
        //{
        //    Message = $"[Name: {name} , password: ({password.Length}cahrs), mail: {mail}, <{tel}>]";
        //}

        [BindProperty(SupportsGet = true)]
        public int Num { get; set; }

    }
}
