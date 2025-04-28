using System;
using System.Collections.Generic;

namespace CGaffney206Lab5.Models;

public partial class SoccerPlayersValuation
{
    public int PlayerId { get; set; }

    public DateOnly Date { get; set; }

    public int MarketValueInEur { get; set; }

    public int CurrentClubId { get; set; }

    public string PlayerClubDomesticCompetitionId { get; set; } = null!;
}
