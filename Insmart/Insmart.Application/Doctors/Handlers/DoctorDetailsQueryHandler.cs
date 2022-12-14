using AutoMapper;
using MediatR;
using Insmart.Application.Interfaces;
using Insmart.Application.Doctors.Queries;

namespace Insmart.Application.Doctors.Handlers
{
    public class DoctorDetailsQueryHandler : IRequestHandler<DoctorDetailsQuery, DoctorCompleteDetailsQueryResult>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DoctorDetailsQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<DoctorCompleteDetailsQueryResult> Handle(DoctorDetailsQuery request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.Doctors.GetDoctorDetailsAsync(request.Id);
            var finalResult = _mapper.Map<DoctorCompleteDetailsQueryResult>(result);

            finalResult.Languages = await _unitOfWork.Doctors.GetDoctorLanguagesAsync(request.Id);

            finalResult.Specialities = await _unitOfWork.Doctors.GetDoctorSpecialitiesAsync(request.Id);

            finalResult.Education = await _unitOfWork.Doctors.GetDoctorEducationsAsync(request.Id);

            finalResult.Awards = await _unitOfWork.Doctors.GetDoctorAwardsAsync(request.Id);

            finalResult.PatientFeedback = await _unitOfWork.Doctors.GetDoctorPatientFeedbackAsync(request.Id);

            finalResult.Hospitals = await _unitOfWork.Doctors.GetDoctorHospitalsAsync(request.Id);

            finalResult.Experiance = await _unitOfWork.Doctors.GetDoctorExperiancesAsync(request.Id);

            return finalResult;
        }
    }
}
