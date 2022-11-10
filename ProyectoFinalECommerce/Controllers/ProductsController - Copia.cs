//using Back_End.Models;
//using Microsoft.AspNetCore.Mvc;
//using Back_End.Repositories;

//namespace Back_End.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ProductsController : ControllerBase
//    {

//        //[HttpGet("GetErrorExample")]
//        //public IActionResult GetErrorExample()
//        //{
//        //    try
//        //    {
//        //        Product product = new Product(1, "fshbsfbnh", 100, false);
//        //        product.SetNewPrice(50);
//        //    }
//        //    catch (Exception ex)
//        //    {
//        //        return BadRequest(ex.Message);
//        //    }
//        //    return Ok();
//        //}

//        //[HttpGet("GetProductsHome")]
//        //public ActionResult GetProductsHome()
//        //{
//        //    List<Product> products = new List<Product>();
//        //    try
//        //    {
//        //        ProductRepository repo = new ProductRepository();
//        //        products = repo.GetProducts();
//        //    }
//        //    catch (Exception ex)
//        //    {
//        //        return BadRequest(ex.Message);
//        //    }
//        //    return Ok(products);
//        //}

//        //[HttpGet("GetProductsByCategory")]
//        //public IActionResult GetProductsByCategory(int idCategory)
//        //{
//        //    List<Product> products = new List<Product>();
//        //    List<Product> productsByCategory = new List<Product>();
//        //    try
//        //    {
//        //        ProductRepository repo = new ProductRepository();
//        //        products = repo.GetProducts();
//        //        foreach (var product in products)
//        //        {
//        //            if (product.category.idCategory == idCategory)
//        //            {
//        //                productsByCategory.Add(product);
//        //            }
//        //        }
//        //    }
//        //    catch (Exception ex)
//        //    {
//        //        return BadRequest(ex.Message);
//        //    }
//        //    return Ok(productsByCategory);
//        //}
        
//        [HttpGet("GetProductsByDestacados")]
//        public IActionResult GetProductsByDestacados()
//        {
//            try
//            {
//                ProductRepository repo = new ProductRepository();
//                return Ok(repo.GetProducts().FindAll(product => product.Destacado));
//            }
//            catch (Exception ex)
//            {
//                return BadRequest(ex.Message);
//            }
//        }

//        [HttpPost("AddProductToCart")] //Crear
//        public IActionResult AddProductToCart(int idProducto, int cantidad) {
//            try
//            {
//                CartRepository.AddProductToCart(idProducto, cantidad);
//                return Ok("El producto se agrego con exito");
//            }
//            catch (Exception ex)
//            {
//                return BadRequest(ex.Message);
//            }
//        }

//        [HttpGet("GetCart")]
//        public IActionResult GetCart() {
//            try
//            {
//                if (CartRepository.GetCart() != null)
//                    return Ok(CartRepository.GetCart().items);
//                else
//                    throw new Exception("Carrito Vacío");
//            }
//            catch (Exception ex)
//            {

//                return BadRequest(ex.Message);
//            }
//        }

//        [HttpGet("GetProductsByBanner")]
//        public IActionResult GetProductsByBanner()
//        {
//            try

//            {
//                ProductRepository repo = new ProductRepository();
//                return Ok(repo.GetProducts().FindAll(product => product.mostrarEnHome));
//            }
//            catch (Exception ex)
//            {
//                return BadRequest(ex.Message);
//            }
//        }


//    }
//}
