using CartaSur.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CartaSur.Application.Queries
{
    public class GetFechaMaxVentasQueryHandler : IRequestHandler<GetFechaMaxVentasQuery, DateTime>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetFechaMaxVentasQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<DateTime> Handle(GetFechaMaxVentasQuery request, CancellationToken cancellationToken)
        {
            return await _dbContext.Ventas
                    .GroupBy(v => v.Fecha_venta.Date)
                    .Select(g => new
                    {
                        Fecha = g.Key,
                        MaxVentas = g.Sum(x => x.Cantidad)
                    })
                    .OrderByDescending(x => x.MaxVentas)
                    .Select(x => x.Fecha)
                    .FirstOrDefaultAsync(cancellationToken);
        }
    }
}
