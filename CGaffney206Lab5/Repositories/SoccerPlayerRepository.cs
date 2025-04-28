using Microsoft.EntityFrameworkCore.ChangeTracking;
using CGaffney206Lab5.Models;
using System.Collections.Concurrent;

namespace CGaffney206Lab5.Repositories
{
    public class SoccerPlayerRepository : ISoccerPlayerRepository
    {
        private static ConcurrentDictionary<int, SoccerPlayer>? playerCache;
        private SportsLeaguesContext db;

        public SoccerPlayerRepository(SportsLeaguesContext injectedContext)
        {
            db = injectedContext;
            if (playerCache == null)
            {
                playerCache = new ConcurrentDictionary<int, SoccerPlayer>(
                    db.SoccerPlayers.ToDictionary(c => c.PlayerId));
            }
        }
        public async Task<SoccerPlayer> CreateAsync(SoccerPlayer c)
        {
            EntityEntry<SoccerPlayer> addedCustomer = await db.SoccerPlayers.AddAsync(c);
            int affected = await db.SaveChangesAsync();
            if (affected == 1)
            {
                if (playerCache == null) return c;
                //if customer is new, add to cache else call update
                return playerCache.AddOrUpdate(c.PlayerId, c, UpdateCache);
            }
            else
            {
                return null;
            }
        }
        public Task<IEnumerable<SoccerPlayer>> RetrieveAllAsync()
        {
            return Task.FromResult(playerCache is null ? Enumerable.Empty<SoccerPlayer>() : playerCache.Values);
        }
        public Task<SoccerPlayer?> RetrieveAsync(int id)
        {
            if (playerCache == null) return null!;
            playerCache.TryGetValue(id, out SoccerPlayer? player);
            return Task.FromResult(player);
        }
        private SoccerPlayer UpdateCache(int id, SoccerPlayer player)
        {
            SoccerPlayer? old;
            if (playerCache is not null)
            {
                if (playerCache.TryGetValue(id, out old))
                {
                    if (playerCache.TryUpdate(id, player, old)) return player;
                }
            }
            return null!;
        }
        public async Task<SoccerPlayer?> UpdateAsync(int id, SoccerPlayer player)
        {
            //update the database
            db.SoccerPlayers.Update(player);
            int affected = await db.SaveChangesAsync();
            if (affected == 1)
            {
                //update the cache
                return UpdateCache(id, player);
            }
            return null!;
        }
        public async Task<bool?> DeleteAsync(int id)
        {
            //remove from db
            SoccerPlayer? player = db.SoccerPlayers.Find(id);
            if (player == null)
            {
                return null; //nothing to delete
            }
            db.SoccerPlayers.Remove(player);
            int affected = await db.SaveChangesAsync();
            if (affected == 1)
            {
                if (playerCache is null) return null;
                //else remove
                return playerCache.TryRemove(id, out player);
            }
            else return null;
        }
    }
}
