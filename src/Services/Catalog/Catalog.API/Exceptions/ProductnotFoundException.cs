using BuildingBlocks.Exceptions;

namespace Catalog.API.Exceptions
{
    public class ProductnotFoundException : NotFoundException
    {
        public ProductnotFoundException(Guid Id) : base("Product",Id)
        {
            
        }
    }
}
