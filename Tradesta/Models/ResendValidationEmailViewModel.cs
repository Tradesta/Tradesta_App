using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tradesta.Models
{
    public class ResendValidationEmailViewModel
    {
        public int? UserId { get; set; }
        public string CallbackUrl { get; set; }
    }
}