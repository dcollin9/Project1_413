using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Group1_7_Project1_IS413.Models
{
    public class EFTourRepository: ITourRepository
    {
        private TourDbContext _context;

        //Constructor for setting the context 
        public EFTourRepository(TourDbContext context)
        {
            _context = context;
        }

        
        public IQueryable<Tour> Tours => _context.Tours;
    }
}
