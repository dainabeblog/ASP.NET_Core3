using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SampleRazorApp.Pages
{
    public enum Gender
    {
        male,
        female
    }
    public enum Platform
    {
        Windows,
        macOs,
        Linux,
        ChromeOS,
        AndroidOs,
        iOs
    }
    public class OtherModel : PageModel
    {
        public string Message { get; set; }

        public bool check { get; set; }
        public Gender gender { get; set; }
        public Platform pc { get; set; }
        public Platform[] pc2 { get; set; }


        public void OnGet()
        {
            Message = "check & select id!";
        }

        public void OnPost(bool check, string gender, Platform pc, Platform[] pc2)
        {
            Message = $"result; {check}, {gender}, {pc}, {pc2.Length}";
        }
    }
}
