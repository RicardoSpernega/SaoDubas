using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace SaoDubas.Application.AutoMapper
{
    class AutomapperConfig
    {
        private MapperConfiguration _config;

        public AutomapperConfig()
        {
            Configure();
        }

        private void Configure()
        {
            //_config = new MapperConfiguration(ctg =>
            //{
            //    ctg.AddProfile<>();
            //})
                
        }
    }
}
