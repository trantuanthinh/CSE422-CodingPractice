using Lab2.DefaultEnums;
using Lab2.Models;
using Lab2.Utils;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers
{
    public class DeviceController : Controller
    {
        public IActionResult Index(string searchName, string searchCode, int? filterStatus, int? filterCategoryId)
        {
            var devices = Datas.Datas.DeviceList.AsQueryable();
            if (!string.IsNullOrEmpty(searchName))
            {
                devices = devices.Where(d => d.Name.Contains(searchName));
            }

            if (!string.IsNullOrEmpty(searchCode))
            {
                devices = devices.Where(d => d.Code.ToString().Contains(searchCode));
            }

            if (filterStatus.HasValue)
            {
                devices = devices.Where(d => d.Status == (DeviceStatus)filterStatus.Value);
            }

            if (filterCategoryId.HasValue)
            {
                devices = devices.Where(d => d.CategoryId == filterCategoryId.Value);
            }
            return View(devices);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Device device)
        {
            if (ModelState.IsValid)
            {
                bool isUnique = ObjectService<Device>.CheckUniqueId(device.Id, Datas.Datas.DeviceList);
                if (isUnique)
                {
                    var category = Datas.Datas.CategoryList.FirstOrDefault(o => o.Id == device.CategoryId);
                    device.Category = category;
                    Datas.Datas.DeviceList.Add(device);
                }
            }
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            var device = Datas.Datas.DeviceList.FirstOrDefault(o => o.Id == id);
            if (device == null)
            {
                return NotFound();
            }
            return View(device);
        }

        [HttpPost]
        public IActionResult Edit(Device device)
        {
            if (ModelState.IsValid)
            {
                var existingDevice = Datas.Datas.DeviceList.FirstOrDefault(o => o.Id == device.Id);
                var category = Datas.Datas.CategoryList.FirstOrDefault(o => o.Id == device.CategoryId);
                if (existingDevice != null)
                {
                    existingDevice.Name = device.Name;
                    existingDevice.Code = device.Code;
                    existingDevice.CategoryId = device.CategoryId;
                    existingDevice.Status = device.Status;
                    existingDevice.Category = category;
                }
            }
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            var device = Datas.Datas.DeviceList.FirstOrDefault(o => o.Id == id);

            if (device != null)
            {
                Datas.Datas.DeviceList.Remove(device);
                return RedirectToAction(nameof(Index));
            }

            return NotFound();
        }
    }
}
