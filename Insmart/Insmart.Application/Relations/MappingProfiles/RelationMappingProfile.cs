using AutoMapper;
using Insmart.Core.DTOs;
using Insmart.Application.Relations;

namespace Insmart.Application.Tasks.MappingProfiles
{
    public class RelationMappingProfile: Profile
    {
        public RelationMappingProfile()
        {
            CreateMap<Relation, RelationDetailsQueryResult>();
        }
    }
}
