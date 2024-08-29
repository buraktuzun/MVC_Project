using BtkAkademi.Models;

public static class Repository
{
    private static List<Candidate> _candidates = new();
    public static IEnumerable<Candidate> Candidates => _candidates;

    public static void AddCandidate(Candidate candidate)
    {
        _candidates.Add(candidate);
    }
    
}