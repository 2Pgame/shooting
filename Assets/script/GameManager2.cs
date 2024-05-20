using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameManager2 : MonoBehaviour
{
    [SerializeField] GameSharedData gameSharedData;
    //bool a = true;
    //int hiscore1;
    //int hiscore2;
    //int hiscore3;
    //int hiscore4;
    // Start is called before the first frame update
    void Start()
    {
        gameSharedData.pow = 1;
        gameSharedData.myFighter = 4;
        gameSharedData.playerScore = 0;
        gameSharedData.Speed = 2;
        gameSharedData.stageClear = false;
        gameSharedData.isPause = false;
        gameSharedData.span = 0.3f;
        gameSharedData.barrier = 0;
    

    }
    // Update is called once per frame
    void Update()
    {

    }

}