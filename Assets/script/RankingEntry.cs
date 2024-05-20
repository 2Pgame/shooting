using System;

[Serializable]
public class RankingEntry
{
    public string name;
    public int score;
    public string mode;

    public RankingEntry(string name, int score, string mode)
    {
        this.name = name;
        this.score = score;
        this.mode = mode;
    }
}