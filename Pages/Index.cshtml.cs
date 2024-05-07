using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Linq.Expressions;

namespace Szamologep.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string? Elso { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? Masodik { get; set; }

        [BindProperty(SupportsGet = true)]
        public char Operator { get; set; }

        public double? Eredmeny { get; set; }

        public string? HibaUzenet { get; set; }

        public void OnPost()
        {
			if (Elso == null || Masodik == null)
			{
				HibaUzenet = "Kérem 2 darab számot adjon meg!";
			}
			else if (!double.TryParse(Elso, out double elso) || !double.TryParse(Masodik, out double masodik))
			{
				HibaUzenet = "Kérem számokat adjon meg!";
			}
			else
			{
				switch (Operator)
                {
                    case '+':
                        Eredmeny = elso + masodik;
                        break;
                    case '-':
                        Eredmeny = elso - masodik;
                        break;
                    case '*':
                        Eredmeny = elso * masodik;
                        break;
                    case '/':
                        Eredmeny = elso / masodik;
                        break;
                    default:
                        Eredmeny = null;
                        break;
                }
			}
		}
    }
}