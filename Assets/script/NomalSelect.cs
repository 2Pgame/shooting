using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class NomalSelect : MonoBehaviour
{
    public GameObject panel;
    public Button GameStartbutton;
    public Button Deletebutton;
    [SerializeField] GameMode gameMode;
    [SerializeField]GameSharedData gameSharedData;
    // Start is called before the first frame update
    void Start()
    {
        Deletebutton.enabled = false;
        GameStartbutton.enabled = false;
        var button = gameObject.GetComponent<Button>();
        button.enabled = true;
        button.onClick.AddListener(() =>
        {
    
            gameMode = GameMode.Normal;
            if ( gameMode == GameMode.Normal ) 
            {
                gameSharedData.game = "Normal";
            }
            SceneManager.LoadScene("InputField");
        });
    }

    // Update is called once per frame
    void Update()
    {

    }
}
