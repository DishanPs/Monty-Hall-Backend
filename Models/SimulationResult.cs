namespace MontyHallProblem.Models
{
    public class SimulationResult
    {
        public int TotalGames { get; set; }

        public int WinsWhenChanged { get; set; }   // Number of wins when the contestant changed their initial choice.

        public int WinsWhenStayed { get; set; }   // Number of wins when the contestant stayed with their initial choice.
    }
}
