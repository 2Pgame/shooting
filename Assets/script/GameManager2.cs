using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameManager2 : MonoBehaviour
{
    [SerializeField] GameSharedData gameSharedData;
    bool a = true;
    int hiscore1;
    int hiscore2;
    int hiscore3;
    int hiscore4;
    // Start is called before the first frame update
    void Start()
    {
        gameSharedData.pow = 1;
        gameSharedData.myFighter = 0;
        gameSharedData.playerScore = 0;
        gameSharedData.stageClear = false;
        gameSharedData.isCheck = false;
        a = true;

        HiScore.Instance.Add(10000, "fukuda");
        HiScore.Instance.Add(8000, "fukuda");
        HiScore.Instance.Add(6000, "fukuda");
        HiScore.Instance.Add(1000, "fukuda");
    }
    // Update is called once per frame
    void Update()
    {
        if ((gameSharedData.myFighter < 0 && a) || (gameSharedData.stageClear && a))
        {
            HiScore.Instance.RankClips(hiscore1, hiscore2, hiscore3, hiscore4);
            if (gameSharedData.GameOverScore > hiscore4)
            {
                
            }
           

            a = false;
        }
        HiScore.Instance.Add(gameSharedData.GameOverScore, gameSharedData.GameOverName);
        HiScore.Instance.Sorts();
    }

}