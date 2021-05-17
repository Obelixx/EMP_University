using Microsoft.EntityFrameworkCore;

using System.Linq;
using System.Threading.Tasks;

namespace Services.Paging
{
    public class Pager<T>
    {
        public async Task<PaginatedList<T>> UseQuery(IQueryable<T> query, int? page = 0, int pageSize = 10)
        {
            if (page.HasValue && page.Value > 0)
            {
                return await PaginatedList<T>.CreateAsync(query, page.Value, pageSize);
            }
            else
            {
                var allElementsCount = await query.CountAsync();
                return new PaginatedList<T>(await query.ToListAsync(), allElementsCount, 0, allElementsCount);
            }
        }
    }
}
