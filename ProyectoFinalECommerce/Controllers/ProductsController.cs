using Back_End.Models;
using Microsoft.AspNetCore.Mvc;
using Back_End.Repositories;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using Microsoft.VisualBasic;
using System.Threading;
using System;
using System.Reflection.Metadata;

namespace Back_End.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {        
        [HttpGet("GetProductsByDestacados")]  //TAREA 1

        //Descripción:
        //Hacer el endpoint, en el proyecto de back-end, de productos destacados,  agregando al modelo la propiedad bool de destacado.
        //Subirlo al repositorio de Github, y entregarlo.

        public IActionResult GetProductsByDestacados()
        {
            try
            {
                ProductRepository repo = new ProductRepository();
                return Ok(repo.GetProducts().FindAll(product => product.Destacado));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetProductsByBanner")]    //TAREA 2

        //Descripción:
        //Yo como usuario final quiero que al ingresar al sitio se vea un carrousel tipo banner informativo que muestre "A definir con el cliente" para ver "A definir por el cliente".
        //Hacer un metodo en el back-end que recupere una lista de productos que tengan la propiedad mostrarEnHome.
        //Para realizar esta tarea deberan agregar en el modelo a la clase producto la propiedad booleana mostrarEnHome, y la deberan agregar en el constructor de la clase producto para poder pasarle el valor por parametro en el momento que hacen el new del objecto producto.
        //Realizar el endpoint GetProductsByBanner, que devuelva la lista de productos a mostrar en el banner.

        public IActionResult GetProductsByBanner()
        {
            try

            {
                ProductRepository repo = new ProductRepository();
                return Ok(repo.GetProducts().FindAll(product => product.mostrarEnHome));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("AddProductToCart")] //TAREA 3

        //Descripción:
        //Del proyecto general, en el metodo AddProductToCart deberan verificar si el producto que recibe por parametro ya se encuentra en el carrito deberan sumarle la cantidad a la existente.
        //Ejemplo
        //Carrito
        //Producto 1 cantidad 5
        //Si llamo al addProductToCart con los valores producto 1, cantidad 10
        //El resultado dera ser,
        //Producto 1, cantidad 15.

        public IActionResult AddProductToCart(int idProducto, int cantidad) {
            try
            {
                CartRepository.AddProductToCart(idProducto, cantidad);
                return Ok("El producto se agrego con exito");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetCart")]

        //ESTE ENDPOINT NO SE CORRESPONDE A NINGUNA DE LKS TAREAS SUBIDAS AL CAMPUS PERO ES NECESARIO PARA COMPROBAR SI LA TAREA 3 SE HIZO BIEN

        public IActionResult GetCart() {
            try
            {
                if (CartRepository.GetCart() != null)
                    return Ok(CartRepository.GetCart().items);
                else
                    throw new Exception("Carrito Vacío");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
