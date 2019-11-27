using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication6.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Пожалуйста, введите свое имя")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Введите Email")]
        [RegularExpression(@".+\@.+\..+", ErrorMessage = "Введите корректный Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Введите,пожалуйста, номер телефона")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Пожалуйста, выберите услугу")]
        public string WillAttend { get; set; }
        [Required(ErrorMessage = "Пожалуйста, выберите тип услуги")]
        public bool? Online { get; set; }
        public string Texts { get; set; }

    }
}