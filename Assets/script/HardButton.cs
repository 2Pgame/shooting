using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HardButton : MonoBehaviour
{
    public Button GameStartbutton;
    public Button Deletetbutton;
    public GameObject panel;
    [SerializeField]GameSharedData gameSharedData;
    [SerializeField]GameMode gameMode;
    public string hard;
    

    // Start is called before the first frame update
    void Start()
    {
        Deletetbutton.enabled = false;
        GameStartbutton.enabled = false;
        var button = gameObject.GetComponent<Button>();
        button.onClick.AddListener(() =>
        {

            gameMode = GameMode.Hard;
            if (gameMode == GameMode.Hard)
            {
                gameSharedData.game = "Hard";
            }
            SceneManager.LoadScene("InputField");
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
