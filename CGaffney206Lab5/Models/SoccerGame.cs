using System;
using System.Collections.Generic;

namespace CGaffney206Lab5.Models;

public partial class SoccerGame
{
    public int GameId { get; set; }

    public string CompetitionId { get; set; } = null!;

    public int Season { get; set; }

    public string Round { get; set; } = null!;

    public DateOnly Date { get; set; }

    public int? HomeClubId { get; set; }

    public int? AwayClubId { get; set; }

    public byte? HomeClubGoals { get; set; }

    public byte? AwayClubGoals { get; set; }

    public string? Stadium { get; set; }

    public int? Attendance { get; set; }

    public string? HomeClubName { get; set; }

    public string? AwayClubName { get; set; }

    public TimeOnly? Aggregate { get; set; }
}
