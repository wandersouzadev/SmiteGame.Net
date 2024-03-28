namespace SmiteGame.Net.Models.Enums
{
    /// <summary>
    /// queue_id’s 423, 426, 430, 433, 435, 440, 445, 448, 451, 452, 459, 466, 450, 502, 503, 504, 10189, 10193, 10195, 10197 are the only ones considered for player win/loss stats from /getplayer.
    /// NOTE: at some time previous to 2020-05-05 matches were no longer played on these queues to the fact that they are in the query is extraneous:  423(Conquest 5v5), 430(Conquest Solo Ranked), 433(Domination Queue), 452(Arena Ranked).
    /// </summary>
    public enum QueueId
    {
        Under30Conquest = 10193,
        Conquest = 426,
        RankedConquest = 451,
        RankedConquestController = 504,
        Under30Joust = 10197,
        Joust = 448,
        RankedJoust = 450,
        RankedJoustController = 503,
        RankedDuel = 440,
        RankedDuelController = 502,
        Under30Arena = 10195,
        Arena = 435,
        Assault = 445,
        Slash = 10189,
        MOTD = 434
    }
}
