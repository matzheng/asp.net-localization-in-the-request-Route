using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace localization_Test.Models
{
    public class LoginUser
    {
        [Required(ErrorMessageResourceType = typeof(LocalizationResources.Resources), ErrorMessageResourceName = "user_name_required")]
        [Display(ResourceType = typeof(LocalizationResources.Resources), Name = "user_name")]
        [MaxLength(100)]
        public string UserName { get; set; }

        [Required(ErrorMessageResourceType = typeof(LocalizationResources.Resources), ErrorMessageResourceName = "password_required")]
        [Display(ResourceType = typeof(LocalizationResources.Resources), Name = "password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessageResourceType = typeof(LocalizationResources.Resources), ErrorMessageResourceName = "email_required")]
        [Display(ResourceType = typeof(LocalizationResources.Resources), Name = "email")]
        [MaxLength(100)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}