
namespace Catalog.API.Products.GetProductById
{
    public record GetProductByIdQuery(Guid id) : IQuery<GetProductByIdResult>;
    public record GetProductByIdResult(Product Product);
    public class GetProductByIdhandler(IDocumentSession session) 
        : IQueryHandler<GetProductByIdQuery, GetProductByIdResult>
    {
        public async Task<GetProductByIdResult> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var product = await session.LoadAsync<Product>(request.id, cancellationToken);
            if(product is null)
            {
                throw new ProductnotFoundException(request.id);
            }
            return new GetProductByIdResult(product);
        }
    }
}
