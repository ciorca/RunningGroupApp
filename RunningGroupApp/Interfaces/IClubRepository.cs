using RunningGroupApp.Models;

namespace RunningGroupApp.Interfaces
{
    public interface IClubRepository
    {
        Task<IEnumerable<Club>> GetAll();
        Task<Club> GetByIdAsync(int id);
        Task<IEnumerable<Club>> GetByClubCity(string city);
        bool Add(Club club);
        bool Update(Club club); 
        bool Delete(Club club);
        bool Save();


    }
}
