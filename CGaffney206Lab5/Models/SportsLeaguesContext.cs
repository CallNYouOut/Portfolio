using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CGaffney206Lab5.Models;

public partial class SportsLeaguesContext : DbContext
{
    public SportsLeaguesContext()
    {
    }

    public SportsLeaguesContext(DbContextOptions<SportsLeaguesContext> options)
        : base(options)
    {
    }

    public virtual DbSet<SoccerGame> SoccerGames { get; set; }

    public virtual DbSet<SoccerPlayer> SoccerPlayers { get; set; }

    public virtual DbSet<SoccerPlayersValuation> SoccerPlayersValuations { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=COLIN-GOODPC\\SQLEXPRESS;Initial Catalog=SportsLeagues;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SoccerGame>(entity =>
        {
            entity.HasKey(e => e.GameId);

            entity.Property(e => e.GameId)
                .ValueGeneratedNever()
                .HasColumnName("game_id");
            entity.Property(e => e.Aggregate).HasColumnName("aggregate");
            entity.Property(e => e.Attendance).HasColumnName("attendance");
            entity.Property(e => e.AwayClubGoals).HasColumnName("away_club_goals");
            entity.Property(e => e.AwayClubId).HasColumnName("away_club_id");
            entity.Property(e => e.AwayClubName)
                .HasMaxLength(100)
                .HasColumnName("away_club_name");
            entity.Property(e => e.CompetitionId)
                .HasMaxLength(50)
                .HasColumnName("competition_id");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.HomeClubGoals).HasColumnName("home_club_goals");
            entity.Property(e => e.HomeClubId).HasColumnName("home_club_id");
            entity.Property(e => e.HomeClubName)
                .HasMaxLength(100)
                .HasColumnName("home_club_name");
            entity.Property(e => e.Round)
                .HasMaxLength(50)
                .HasColumnName("round");
            entity.Property(e => e.Season).HasColumnName("season");
            entity.Property(e => e.Stadium)
                .HasMaxLength(100)
                .HasColumnName("stadium");
        });

        modelBuilder.Entity<SoccerPlayer>(entity =>
        {
            entity.HasKey(e => e.PlayerId);

            entity.Property(e => e.PlayerId)
                .ValueGeneratedNever()
                .HasColumnName("player_id");
            entity.Property(e => e.CountryOfCitizenship)
                .HasMaxLength(50)
                .HasColumnName("country_of_citizenship");
            entity.Property(e => e.CurrentClubId).HasColumnName("current_club_id");
            entity.Property(e => e.CurrentClubName)
                .HasMaxLength(100)
                .HasColumnName("current_club_name");
            entity.Property(e => e.DateOfBirth).HasColumnName("date_of_birth");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("first_name");
            entity.Property(e => e.Foot)
                .HasMaxLength(50)
                .HasColumnName("foot");
            entity.Property(e => e.HeightInCm).HasColumnName("height_in_cm");
            entity.Property(e => e.HighestMarketValueInEur)
                .HasColumnType("money")
                .HasColumnName("highest_market_value_in_eur");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("last_name");
            entity.Property(e => e.LastSeason).HasColumnName("last_season");
            entity.Property(e => e.MarketValueInEur)
                .HasColumnType("money")
                .HasColumnName("market_value_in_eur");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.PlayerCode)
                .HasMaxLength(50)
                .HasColumnName("player_code");
            entity.Property(e => e.Position)
                .HasMaxLength(50)
                .HasColumnName("position");
            entity.Property(e => e.SubPosition)
                .HasMaxLength(50)
                .HasColumnName("sub_position");
        });

        modelBuilder.Entity<SoccerPlayersValuation>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CurrentClubId).HasColumnName("current_club_id");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.MarketValueInEur).HasColumnName("market_value_in_eur");
            entity.Property(e => e.PlayerClubDomesticCompetitionId)
                .HasMaxLength(50)
                .HasColumnName("player_club_domestic_competition_id");
            entity.Property(e => e.PlayerId).HasColumnName("player_id");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
