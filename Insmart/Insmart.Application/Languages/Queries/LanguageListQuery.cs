using Insmart.Core;
using MediatR;

namespace Insmart.Application.Languages.Queries
{
    public class LanguageListQuery : PaginationFilter, IRequest<LanguageListQueryResult>
    {
        public LanguageListQuery() { }

        public LanguageListQuery(int pageIndex, int pageSize)
        {
            PageNumber = pageIndex;
            PageSize = pageSize;
        }

    }
}
