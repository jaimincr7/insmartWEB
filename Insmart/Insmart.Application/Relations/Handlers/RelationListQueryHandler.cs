using AutoMapper;
using MediatR;
using Insmart.Application.Interfaces;
using Insmart.Application.Relations.Queries;
using Insmart.Core.DTOs;
using Insmart.Core;

namespace Insmart.Application.Relations.Handlers
{
    public class RelationListQueryHandler : IRequestHandler<RelationListQuery, RelationListQueryResult>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public RelationListQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<RelationListQueryResult> Handle(RelationListQuery request, CancellationToken cancellationToken)
        {
            var result = new RelationListQueryResult();
            var dataQuery = new DapperQueryAndParams<Relation>()
            {
                RawSql = "Name!=''",
            };

            IEnumerable<Relation> items;

            items = await _unitOfWork.Relations.GetAllAsync(dataQuery, "RelationId Asc");

            result.Relations = _mapper.Map<IEnumerable<RelationDetailsQueryResult>>(items);

            return result;
        }
    }
}
