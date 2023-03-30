using EFCoreRelationshipss.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EFCoreRelationshipss.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductsController : ControllerBase
	{
		private readonly AppDbContext appDbContext;

		public ProductsController(AppDbContext appDbContext)
		{
			this.appDbContext = appDbContext;

		}

		[HttpGet]
		public async Task<ActionResult<List<Product>>> Get(int categoryId)
		{
			var products = await appDbContext.Productss.Where
				(x => x.CategoryId == categoryId)
				.Include(x => x.Size)
				.Include(x => x.Colors).ToListAsync();
			return products;
		}
		//[HttpGet("{productId:int}")]
		//public async Task<ActionResult<Size>> GetProductSize(int productId)
		//{
			//var Size = await appDbContext.Sizes.FirstOrDefaultAsync((p => p.ProductId == productId));
			//return Size;
		}
	}
