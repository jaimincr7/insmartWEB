using MediatR;

namespace Insmart.Application.Languages.Queries
{
    public class GetLanguageDetailsQuery: IRequest<LanguageDetailsQueryResult>
    {
        public int Id { get; set; }
    }
}
