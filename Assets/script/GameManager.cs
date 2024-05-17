using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]GameSharedData gameSharedData;
    [SerializeField]TextMeshProUGUI textMeshProUGUI;
    [SerializeField] TextMeshProUGUI textMeshProUGUI2;
    [SerializeField] TextMeshProUGUI textMeshProUGUI3;
    [SerializeField] GameObject button;
    [SerializeField] GameObject pausePanel;
    [SerializeField] GameObject fighter1;
    [SerializeField] GameObject fighter2;
    [SerializeField] GameObject fighter3;
    [SerializeField] GameObject fighter4;
    
    // Start is called before the first frame update
    void Start()
    {
        textMeshProUGUI3.enabled = false;
        pausePanel.SetActive(false);
        button.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        textMeshProUGUI.text = gameSharedData.playerScore.ToString();
        if (gameSharedData.myFighter <= 4)
        {
            fighter4.SetActive(true);
        }
        if (gameSharedData.myFighter <= 3 && fighter4)
        {
            fighter4.SetActive(false);
        }
        if (gameSharedData.myFighter <= 2 && fighter3)
        {
            fighter3.SetActive(false);
        }
        if (gameSharedData.myFighter <= 1 && fighter2)
        {
            fighter2.SetActive(false);
        }
        if (gameSharedData.myFighter == 0)
        {
            fighter1.SetActive(false);
        }
        if (gameSharedData.myFighter < 0)
        {
            textMeshProUGUI2.text = gameSharedData.gameover;
            gameSharedData.GameOverScore = gameSharedData.playerScore;
        }
        if (gameSharedData.stageClear)
        {
            Invoke("Text", 8f);
            Invoke("Clear", 15f);
        }
        if (gameSharedData.isCheck)
        {
            pausePanel.SetActive(true);
            button.SetActive(true);
        }
        else 
        {
            pausePanel.SetActive(false);
            button.SetActive(false);
        }
        
    }
    void Clear()
    {
        SceneManager.LoadScene("Title");
    }
    void Text()
    {
        textMeshProUGUI3.enabled = true;
    }
    class HiScore
    {
        public int HiScore1;
        public string Name1;
        public HiScore(int HiScore1, string Name1)
        {
            this.HiScore1 = HiScore1;
            this.Name1 = Name1;
        }

    }
}
