using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AdminApp.Mvc.ViewComponents
{
	public class ShowBadgeComponent : ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync()
		{
			return View("/Views/Shared/Components/ShowBadgeComponent.cshtml", "Omidi");
		}

	}
}