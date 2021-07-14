using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace SampleRazorApp.Models
{
    public class Person: IValidatableObject
    {
        public int PersonId { get; set; }
        [Display(Name="名前")]
        [Required(ErrorMessage = "必須項目です。") ]
        public string Name { get; set; }
        [Display(Name="メールアドレス")]
        [EmailAddress(ErrorMessage = "メールアドレスを入力してください")]
        public string Mail { get; set; }
        [Display(Name="年齢")]
        [Range(0, 200, ErrorMessage = "0: {0}から1: {1} 2: {2}の間で入力してください")]
        public int Age { get; set; }

        [Display(Name = "投稿")]
        public ICollection<Message> Messages { get; set; }

        //public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        //{
        //    if(Name == null)
        //    {
        //        yield return new ValidationResult("名前は必須項目です。");
        //    }
        //    if (Mail != null && !Regex.IsMatch(Mail,"[a-zA-Z0-9.+-_%]+@[a-zA-Z0-9.-]+"))
        //    {
        //        yield return new ValidationResult
        //               ("メールアドレスが必要です。");
        //    }
        //    if (Age < 0)
        //    {
        //        yield return new ValidationResult
        //                ("年齢はマイナスにはできません。");
        //    }
        //}

        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            throw new System.NotImplementedException();
        }

        public Person()
        {
        }
    }
}
