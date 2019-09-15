using AutoMapper;
using CoreCodeCamp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCodeCamp.Data
{
    public class MappingProfle:Profile
    {
        public MappingProfle()
        {
            CreateMap<Camp, CampModel>();


            CreateMap<CampModel, Camp>();
            

            CreateMap<Talk, TalkModel>();
            CreateMap<Speaker, SpeakerModel>();

            CreateMap<LocationModel, Location>();
        }
    }
}
