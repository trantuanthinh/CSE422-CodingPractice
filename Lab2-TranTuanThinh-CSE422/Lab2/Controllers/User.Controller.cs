using Lab2.Models;
using Lab2.Utils;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View(Datas.Datas.UserList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                bool isUnique = ObjectService<User>.CheckUniqueId(user.Id, Datas.Datas.UserList);
                if (isUnique)
                {
                    Datas.Datas.UserList.Add(user);
                }
            }
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            var user = Datas.Datas.UserList.FirstOrDefault(o => o.Id == id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        [HttpPost]
        public IActionResult Edit(User user)
        {
            if (ModelState.IsValid)
            {
                var existingUser = Datas.Datas.UserList.FirstOrDefault(o => o.Id == user.Id);
                if (existingUser != null)
                {
                    existingUser.FullName = user.FullName;
                    existingUser.Email = user.Email;
                    existingUser.PhoneNumber = user.PhoneNumber;
                }
            }
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            if (Datas.Datas.UserList == null || !Datas.Datas.UserList.Any())
            {
                return NotFound();
            }

            var user = Datas.Datas.UserList.FirstOrDefault(o => o.Id == id);

            if (user != null)
            {
                Datas.Datas.UserList.Remove(user);
                return RedirectToAction(nameof(Index));
            }

            return NotFound();
        }
    }
}
