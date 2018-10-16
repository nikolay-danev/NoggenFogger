using NoggenFogger.Data.Entities;
using NoggenFogger.Models;

namespace NoggenFogger.Profile
{
    public class NoggenFoggerProfile : AutoMapper.Profile
    {
        public NoggenFoggerProfile()
        {
            CreateMap<Game, GameViewModel>();
        }
    }
}
