using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyCompanySite2.Domain.Entities
{
    public class TextField : EntityBase
    {
        [Required]
        public string CodeWord { get; set; }

        [Display(Name = "Название (заголовок)")]
        public override string Title { get; set; }

        [Display(Name = "Содержание страницы")]
        public override string Text { get; set; }

    }
}
