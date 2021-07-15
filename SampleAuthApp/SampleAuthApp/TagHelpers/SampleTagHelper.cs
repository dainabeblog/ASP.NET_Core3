using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;


namespace SampleAuthApp.TagHelpers
{
    public class SampleTagHelper : TagHelper
    {
        public List<string> items { get; set; }


        public override void Process(TagHelperContext context,
                TagHelperOutput output)
        {
            if (items == null)
            {
                output.TagName = "p";
                output.Content.SetContent("*** no-data ***");
                return;
            }
            output.TagName = "ul";
            output.Attributes.SetAttribute("style", "text-align:left; font-size:20pt;");
            output.Content.Clear();


            foreach (var item in items)
            {
                output.Content.AppendHtml("<li>" + item + "</li>");
            }
        }
    }
}