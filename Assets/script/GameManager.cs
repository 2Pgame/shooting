using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]GameSharedData gameSharedData;
    [SerializeField]TextMeshProUGUI textMeshProUGUI;
    [SerializeField] TextMeshProUGUI textMeshProUGUI2;
    [SerializeField] GameObject fighter1;
    [SerializeField] GameObject fighter2;
    [SerializeField] GameObject fighter3;
    [SerializeField] GameObject fighter4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textMeshProUGUI.text = gameSharedData.playerScore.ToString();
        if (gameSharedData.myFighter == 4)
        {
            fighter4.SetActive(true);
        }
        else if (gameSharedData.myFighter == 3)
        {
            fighter4.SetActive(false);
        }
        else if (gameSharedData.myFighter == 2)
        {
            fighter3.SetActive(false);
        }
        else if (gameSharedData.myFighter == 1)
        {
            fighter2.SetActive(false);
        }
        else if (gameSharedData.myFighter == 0)
        {
            fighter1.SetActive(false);
        }
        else if (gameSharedData.myFighter < 0)
        {
            textMeshProUGUI2.text = gameSharedData.gameover;
        }
    }
}
