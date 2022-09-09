using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace HospiEnCasa.App.Frontend.Pages
{
    public class RegistrosModel : PageModel
    {
        private readonly ILogger<RegistrosModel> _logger;

        public RegistrosModel(ILogger<RegistrosModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
