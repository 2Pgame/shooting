using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class HiScore
{
    private const string PlayerPrefsKey = "HiScore";
    public static HiScore Instance
    {
        get
        {
            if (null == instance)
            {
                instance = PlayerPrefs.HasKey(PlayerPrefsKey)
                    ? JsonUtility.FromJson<HiScore>(PlayerPrefs.
                    GetString(PlayerPrefsKey))
                    : new HiScore();
            }
            return instance;
        }

    }
    private static HiScore instance;

    public HiScoreClear[] HiScores
    {
        get { return hiScores.ToArray(); }
    }
    [SerializeField]
    private List<HiScoreClear> hiScores = new List<HiScoreClear>();
    public List<HiScoreClear> his = new List<HiScoreClear>();


    private HiScore()
    {
    }
    public void Save()
    {
        var jsonString = JsonUtility.ToJson(this);
        PlayerPrefs.SetString(PlayerPrefsKey, jsonString);
        PlayerPrefs.Save();
    }
    public void Add(int score, string name)
    {
        hiScores.Add(new HiScoreClear(score, name));
    }
    public void Sorts()
    {
        hiScores = hiScores.OrderByDescending(h => h.Score).ToList();
        foreach (HiScoreClear h in hiScores)
        {
            Debug.Log($"{h.Score}{h.Name}");
        }    
    }
    public void RankClips(int hiscore1,int hiscore2,int hiscore3,int hiscore4)
    {
        hiscore1 = hiScores[0].Score;
        hiscore2 = hiScores[1].Score;
        hiscore3 = hiScores[2].Score;
        hiscore4 = hiScores[3].Score;
    }
    public void Rank1()
    {
        //hiScores[0].Score
    }
    [Serializable]
    public class HiScoreClear
    {
        public int Score
        {
            get { return score; }
        }
        public string Name
        {
            get { return name; }
        }
        [SerializeField] private int score;
        [SerializeField] private string name;
        public HiScoreClear(int score, string name)
        {
            this.score = score;
            this.name = name;
        }
    }
}
