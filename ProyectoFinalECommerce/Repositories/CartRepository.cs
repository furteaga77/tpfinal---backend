using Back_End.Models;

namespace Back_End.Repositories
{
    public class CartRepository
    {
        private static Cart _cart { get; set; }

        public static Cart GetCart() { 
            return _cart;
        }
        public static void AddProductToCart(int idProduct, int cantidad) {
            if(_cart==null)_cart = new Cart();
            ProductRepository repo = new ProductRepository();
            List<Product> products = new List<Product>();
            products = repo.GetProducts();
            Product product = products.Find(prod => prod.Id == idProduct);
            CartItem productincart = _cart.items.Find(prodcart => prodcart.product.Id == idProduct);
            if (product != null)
            {
                if (productincart == null) _cart.items.Add(new CartItem(product, cantidad));
                else productincart.cantidad += cantidad;
            }
            else
            {
                throw new Exception("Producto no encontrado");
            }
        }

        
    }
}
