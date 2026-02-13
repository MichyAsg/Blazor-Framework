using Microsoft.AspNetCore.Mvc;
using MyApp.Api.DTOs;
using MyApp.Domain.Entities;
using MyApp.Logic;
using MyApp.Logic.Services;

[ApiController]
[Route("api/products")]
public class ProductsController : ControllerBase
{
    private readonly ProductService _service;

    public ProductsController(ProductService service)
    {
        _service = service;
    }

    [HttpPost]
    public async Task<IActionResult> Create(ProductDto dto)
    {
        // Handmatige mapping van DTO → Domain entity
        var product = new Product(dto.Name, dto.Price);
        await _service.CreateAsync(product.Name, product.Price);
        return Ok();
    }

    [HttpGet]
    public async Task<ActionResult<List<ProductDto>>> GetAll()
    {
        var products = await _service.GetAllAsync();

        // Handmatige mapping van Domain → DTO
        var result = products.Select(p => new ProductDto
        {
            Id = p.Id,
            Name = p.Name,
            Price = p.Price
        }).ToList();

        return Ok(result);
    }
}
