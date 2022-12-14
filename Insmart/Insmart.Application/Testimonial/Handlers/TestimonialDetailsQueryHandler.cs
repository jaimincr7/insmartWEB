using AutoMapper;
using MediatR;
using Insmart.Application.Interfaces;
using Insmart.Application.Testimonials.Queries;

namespace Insmart.Application.Testimonials.Handlers
{
    public class TestimonialDetailsQueryHandler : IRequestHandler<TestimonialDetailsQuery, TestimonialDetailsQueryResult>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TestimonialDetailsQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<TestimonialDetailsQueryResult> Handle(TestimonialDetailsQuery request, CancellationToken cancellationToken)
        {
            //var result = await _unitOfWork.REPO_CLASS_PROP_NAME.Add(_mapper.Map<Insmart.Core.Entities.Task>(request));
            //return result;
            throw new NotImplementedException();
        }
    }
}
