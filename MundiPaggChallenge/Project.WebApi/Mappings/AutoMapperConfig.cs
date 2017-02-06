using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.WebApi.Mappings
{
    public class AutoMapperConfig
    {
        public static void Register()
        {
            Mapper.Initialize(
                m =>
                {
                    m.AddProfile<EntityToModelMapping>();
                    m.AddProfile<ModelToEntityMapping>();
                }    
            );
        }
    }
}