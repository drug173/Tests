using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Auth.ViewModel
{
    public class RegisterM
    {
        [Required(ErrorMessage = "укажите Телефон")]
        [RegularExpression(@"\d+", ErrorMessage = "Некорректный номер")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "введите пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Неправильный пароль")]
        public string ConfirmPassword { get; set; }
    }
}

