using Lab2.Models;
using Lab2.Utils;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View(Datas.Datas.CategoryList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                bool isUnique = ObjectService<Category>.CheckUniqueId(category.Id, Datas.Datas.CategoryList);
                if (isUnique)
                {
                    Datas.Datas.CategoryList.Add(category);
                }
            }
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            var category = Datas.Datas.CategoryList.FirstOrDefault(o => o.Id == id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        [HttpPost]
        public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                bool isUnique = ObjectService<Category>.CheckUniqueId(category.Id, Datas.Datas.CategoryList);
                if (isUnique)
                {
                    var existingCategory = Datas.Datas.CategoryList.FirstOrDefault(o => o.Id == category.Id);
                    if (existingCategory != null)
                    {
                        existingCategory.Name = category.Name;
                    }
                }
            }
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            if (Datas.Datas.CategoryList == null || !Datas.Datas.CategoryList.Any())
            {
                return NotFound();
            }

            var category = Datas.Datas.CategoryList.FirstOrDefault(o => o.Id == id);

            if (category != null)
            {
                Datas.Datas.CategoryList.Remove(category);
                return RedirectToAction(nameof(Index));
            }

            return NotFound();
        }
    }
}
