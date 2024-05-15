using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager2 : MonoBehaviour
{
    [SerializeField] GameSharedData gameSharedData;
    // Start is called before the first frame update
    void Start()
    {
        gameSharedData.pow = 1;
        gameSharedData.myFighter = 4;
        gameSharedData.playerScore = 0;
        gameSharedData.stageClear = false;
        gameSharedData.isCheck = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
