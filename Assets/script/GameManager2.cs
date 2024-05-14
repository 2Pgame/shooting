using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager2 : MonoBehaviour
{
    [SerializeField]GameSharedData gameSharedData;
    // Start is called before the first frame update
    void Start()
    {
        gameSharedData.pow = 1;
        gameSharedData.myFighter = 4;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
