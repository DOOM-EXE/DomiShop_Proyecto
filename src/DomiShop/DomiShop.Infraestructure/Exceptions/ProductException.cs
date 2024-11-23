using System;

namespace DomiShop.Infrastructure.Exceptions
{
    public class ProductException : Exception
    {
        public ProductException(string message) : base(message) { }
    }
}
