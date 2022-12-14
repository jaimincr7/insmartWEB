using AutoMapper;
using MediatR;
using Insmart.Application.Interfaces;
using Insmart.Application.Specialities.Queries;

namespace Insmart.Application.Specialities.Handlers
{
    public class SpecialityListQueryHandler : IRequestHandler<SpecialityListQuery, SpecialityListQueryResult>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public SpecialityListQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<SpecialityListQueryResult> Handle(SpecialityListQuery request, CancellationToken cancellationToken)
        {
            return await _unitOfWork.Specialities.GetAllSpecialitiesAsync(request);
        }
    }
}
