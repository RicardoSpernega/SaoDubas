using Microsoft.Extensions.Configuration;
using SaoDubas.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace SaoDubas.Infrastructure.Repositories
{
    public abstract class BaseRepository
    {
        protected readonly SaoDubasContext _context;

        public BaseRepository(IConfiguration configuration)
        {
            _context = new SaoDubasContext(configuration);
        }
    }
}
