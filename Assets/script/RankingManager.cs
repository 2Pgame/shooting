using System;
using System.Collections.Generic;
using UnityEngine;

public class RankingManager : MonoBehaviour
{
    private List<RankingEntry> rankingEntries;
    [SerializeField]GameSharedData gameSharedData;

    void Awake()
    {
        LoadRanking();
    }

    public void AddRankingEntry(string name, int score,string mode)
    {
        RankingEntry newEntry = new RankingEntry(name, score,mode);
        rankingEntries.Add(newEntry);
        SaveRanking();
    }

    public List<RankingEntry> GetRankingEntries()
    {
        rankingEntries.Sort((x, y) => y.score.CompareTo(x.score));
        return rankingEntries;
    }

    private void LoadRanking()
    {
        string json = PlayerPrefs.GetString("RankingData", "");
        if (!string.IsNullOrEmpty(json))
        {
            RankingList rankingList = JsonUtility.FromJson<RankingList>(json);
            rankingEntries = rankingList.rankingEntries;
        }
        else
        {
            rankingEntries = new List<RankingEntry>();
        }
    }

    private void SaveRanking()
    {
        rankingEntries.Sort((x, y) => y.score.CompareTo(x.score)); // �X�R�A�Ń\�[�g
        RankingList rankingList = new RankingList { rankingEntries = rankingEntries };
        string json = JsonUtility.ToJson(rankingList);
        PlayerPrefs.SetString("RankingData", json);
        PlayerPrefs.Save();
    }

    [Serializable]
    private class RankingList
    {
        public List<RankingEntry> rankingEntries;
    }
}