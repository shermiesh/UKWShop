using Microsoft.AspNetCore.Mvc;
using UKWShop.DAL;

namespace UKWShop.ViewComponents
{
    public class MenuViewComponent : ViewComponent
    {
        FilmsContext db;
        public MenuViewComponent(FilmsContext db)
        {
            this.db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categories = db.Categories.ToList();
            return await Task.FromResult(View("_Menu", categories));
        }
    }
}
