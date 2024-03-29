﻿using RunningGroupApp.Models;

namespace RunningGroupApp.Interfaces
{
    public interface IRaceRepository
    {
        Task<IEnumerable<Race>> GetAll();
        Task<Race> GetByIdAsync(int id);
        public  Task<Race> GetByIdAsyncNoTracking(int id);
        Task<IEnumerable<Race>> GetAllRacesByCity(string city);
       
        bool Add(Race race);
        bool Update(Race race);
        bool Delete(Race race);
        bool Save();

    }
}
