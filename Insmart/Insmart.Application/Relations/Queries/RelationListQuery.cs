using Insmart.Core;
using MediatR;

namespace Insmart.Application.Relations.Queries
{
    public class RelationListQuery : IRequest<RelationListQueryResult>
    {
        public RelationListQuery() { }
    }
}
