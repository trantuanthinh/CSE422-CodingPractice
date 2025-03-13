using Microsoft.AspNetCore.Mvc;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

[ApiController]
[Route("api/[controller]")]
public class GenericController<T> : ControllerBase where T : class, new()
{
    [HttpPost]
    public IActionResult CreateEntity([FromBody] T entity)
    {
        if (entity == null)
            return BadRequest("Invalid data");

        // Use Reflection to get the "Name" property dynamically
        PropertyInfo nameProperty = typeof(T).GetProperty("Name");

        if (nameProperty == null)
            return BadRequest("Entity must have a Name property.");

        string name = nameProperty.GetValue(entity) as string;

        if (string.IsNullOrEmpty(name))
            return BadRequest("Invalid data: Name is required.");

        return Ok($"{typeof(T).Name} {name} created successfully.");
    }
}
