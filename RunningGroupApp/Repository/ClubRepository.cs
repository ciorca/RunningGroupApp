using RunningGroupApp.Data;
using RunningGroupApp.Interfaces;
using RunningGroupApp.Models;

namespace RunningGroupApp.Repository
{
    public class ClubRepository : IClubRepository
    {
        private readonly AppDbContext _context;

        public ClubRepository(AppDbContext context)
        {
            _context = context;
        }
        public bool Add(Club club)
        {
            _context.Add(club);
            return Save();
        }

        public bool Delete(Club club)
        {
            _context.Remove(club);
          
        }

        public Task<IEnumerable<Club>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Club>> GetByClubCity(string city)
        {
            throw new NotImplementedException();
        }

        public Task<Club> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool Update(Club club)
        {
            throw new NotImplementedException();
        }
    }
}
