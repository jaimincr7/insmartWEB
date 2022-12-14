using MediatR;

namespace Insmart.Application.Banners.Queries
{
    public class BannerDetailsQuery: IRequest<BannerDetailsQueryResult>
    {
        public int Id { get; set; }
    }
}
