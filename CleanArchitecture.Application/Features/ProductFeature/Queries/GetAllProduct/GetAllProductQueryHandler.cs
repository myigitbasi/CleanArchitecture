using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Application.Features.ProductFeature.Queries.GetAllProduct;

public sealed class GetAllProductQueryHandler : IRequestHandler<GetAllProductQuery, List<Product>>
{
    private readonly IProductRepository _productRepository;

    public GetAllProductQueryHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<List<Product>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
    {
        return await _productRepository.GetAll().ToListAsync(cancellationToken);
    }
}
