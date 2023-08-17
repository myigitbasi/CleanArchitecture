using CleanArchitecture.Domain.Entities;
using MediatR;

namespace CleanArchitecture.Application.Features.ProductFeature.Queries.GetAllProduct;

public sealed record GetAllProductQuery() : IRequest<List<Product>>;
