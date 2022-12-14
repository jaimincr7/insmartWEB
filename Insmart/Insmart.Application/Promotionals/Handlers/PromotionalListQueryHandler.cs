using AutoMapper;
using MediatR;
using Insmart.Application.Interfaces;
using Insmart.Application.Promotionals.Queries;
using Insmart.Core.DTOs;
using Insmart.Core.Enums;

namespace Insmart.Application.Promotionals.Handlers
{
    public class PromotionalListQueryHandler : IRequestHandler<PromotionalListQuery, PromotionalListQueryResult>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public PromotionalListQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<PromotionalListQueryResult> Handle(PromotionalListQuery request, CancellationToken cancellationToken)
        {
            var result = new PromotionalListQueryResult();

            IEnumerable<Promotional> items;

            items = await _unitOfWork.Promotionals.GetAllPromotionsAsync();

            result.Promotionals = _mapper.Map<IEnumerable<PromotionalDetailsQueryResult>>(items);
          
            foreach (var item in result.Promotionals)
            {
                switch (item.PromotionalType)
                {
                    case (int)PromotionalType.Doctor:
                        item.Doctors = await _unitOfWork.Doctors.GetAllPromotionalAsync(item.PromotionalId);
                        break;
                    case (int)PromotionalType.Hospital:
                        item.Hospitals = await _unitOfWork.Hospitals.GetAllPromotionalAsync(item.PromotionalId);
                        break;
                    case (int)PromotionalType.Speciality:
                        item.Specialities = await _unitOfWork.Specialities.GetAllPromotionalAsync(item.PromotionalId);
                        break;
                    case (int)PromotionalType.Symptoms:
                        item.Symptoms = await _unitOfWork.Symptoms.GetAllPromotionalAsync(item.PromotionalId);
                        break;
                    default:
                        break;
                }                
            }

            return result;
        }
    }
}
