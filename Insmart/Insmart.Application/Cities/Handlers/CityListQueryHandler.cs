using AutoMapper;
using MediatR;
using Insmart.Application.Interfaces;
using Insmart.Application.Cities.Queries;
using Insmart.Core.DTOs;
using Insmart.Core;

namespace Insmart.Application.Cities.Handlers
{
    public class CityListQueryHandler : IRequestHandler<CityListQuery, CityListQueryResult>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CityListQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<CityListQueryResult> Handle(CityListQuery request, CancellationToken cancellationToken)
        {
            return await _unitOfWork.Cities.GetAllCitiesAsync(request);
        }
    }
}
