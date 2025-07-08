using _4003projectsetup.Data;
using _4003projectsetup.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _4003projectsetup.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly MyApplicationDbContext _myApplicationDbContext;

        // Bind the MailingList model to the form input
        [BindProperty]
        public MailingList MailingList { get; set; }

        public IndexModel(ILogger<IndexModel> logger, MyApplicationDbContext myApplicationDbContext)
        {
            _logger = logger;
            _myApplicationDbContext = myApplicationDbContext;
        }

        public void OnGet()
        {
            // Optional: Load existing data, show messages, etc.
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _myApplicationDbContext.MailingLists.Add(MailingList);
            await _myApplicationDbContext.SaveChangesAsync();

            TempData["Message"] = "Thank you for signing up!";

            return RedirectToPage();
        }
    }
}
