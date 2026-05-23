using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UnitConverter.Models;
using UnitConverter.Services;

namespace UnitConverter.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IConverterService _converter;

        public IndexModel(IConverterService converter)
        {
            _converter = converter;
        }

        public string ActiveTab { get; set; } = "length";

        [BindProperty]
        public ConversionRequest ConversionInput { get; set; } = new();

        public double? Result { get; set; }

        public string? ErrorMessage { get; set; }

        public void OnGet(string tab = "length")
        {
            ActiveTab = tab;
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                ActiveTab = ConversionInput.ConversionType ?? "length";
                return Page();
            }

            try
            {
                ActiveTab = ConversionInput.ConversionType ?? "length";
                Result = _converter.Convert(ConversionInput);
            }
            catch (ArgumentException ex)
            {
                ErrorMessage = ex.Message;
            }

            return Page();
        }
    }
}
