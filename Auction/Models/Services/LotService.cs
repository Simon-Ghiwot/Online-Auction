using Auction.Models.Base;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Auction.Models.Services
{
    public class LotService : EnityBaseRepository<Lot>, ILotService
    {
        public LotService(AuctionDbContext context) : base(context)
        {
            
        }
        public async Task<IEnumerable<Lot>> GetAllActiveAsync()
        {
            return await _context.Lots.Where(temp => temp.AvailabilityStatus == 0).ToListAsync();
        }
    }
}
