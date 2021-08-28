using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using Azure.Core;


namespace pffapp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            _logger.LogInformation("INFO: Get request to Index");
            _logger.LogWarning("WARRNING: Get request to Index");
            _logger.LogDebug("DEBUG: Get request to Index");
            _logger.LogError("ERROR: Get request to Index");
            
        }
    }
}
