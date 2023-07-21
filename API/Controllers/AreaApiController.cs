using Infrastructure.Data;

namespace API.Controllers;

    public class AreaApiController : BaseApiController
    {
        private readonly IncidenciaContext _context;
        
        public AreaApiController(IncidenciaContext context)
        {
            _context = context;
        }
    }
