using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MDS.Entities;
using MDS.Models;
using MDS.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MDS.Controllers
{
    public class ShopController
    {
        private readonly MdsDbContext context;
        private readonly IMapper mapper;
        public ShopController(MdsDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet("/api/shops")]
        public async Task<IEnumerable<ShopModel>> GetShops()
        {
            var shops = await context.Shops.ToListAsync();
            return mapper.Map<IEnumerable<Shop>, IEnumerable<ShopModel>>(shops);

        }
    }
}