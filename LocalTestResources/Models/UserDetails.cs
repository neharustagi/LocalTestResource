using LocalTestResources.App_LocalResources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LocalTestResources.Models
{
    public class UserDetails
    {
        [Required(ErrorMessageResourceType = typeof(strings), ErrorMessageResourceName = "NameRequired")]
        public string UserName { get; set; }

        public string City { get; set; }
    }
}