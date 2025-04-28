using System;
using System.Collections.Generic;

namespace CGaffney206Lab5.Models;

public partial class SoccerPlayer
{
    public int PlayerId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string Name { get; set; } = null!;

    public int? LastSeason { get; set; }

    public int? CurrentClubId { get; set; }

    public string? PlayerCode { get; set; }

    public string? CountryOfCitizenship { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public string? SubPosition { get; set; }

    public string? Position { get; set; }

    public string? Foot { get; set; }

    public int? HeightInCm { get; set; }

    public string? CurrentClubName { get; set; }

    public decimal? MarketValueInEur { get; set; }

    public decimal? HighestMarketValueInEur { get; set; }
}
