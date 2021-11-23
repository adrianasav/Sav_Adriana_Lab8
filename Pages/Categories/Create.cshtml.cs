using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Sav_Adriana_Lab8.Data;
using Sav_Adriana_Lab8.Models;

namespace Sav_Adriana_Lab8.Pages.Categories
{
    public class CreateModel : PageModel
    {
        private readonly Sav_Adriana_Lab8.Data.Sav_Adriana_Lab8Context _context;

        public CreateModel(Sav_Adriana_Lab8.Data.Sav_Adriana_Lab8Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Category Category { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Category.Add(Category);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
