using CGaffney206Lab5.Models;

namespace CGaffney206Lab5.Repositories
{
    public interface ISoccerPlayerRepository
    {
        Task<SoccerPlayer?> CreateAsync(SoccerPlayer? player);
        Task<IEnumerable<SoccerPlayer>> RetrieveAllAsync();
        Task<SoccerPlayer?> RetrieveAsync(int id);
        Task<SoccerPlayer?> UpdateAsync(int id, SoccerPlayer player);
        Task<bool?> DeleteAsync(int id);
    }
}
