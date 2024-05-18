using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoButton : MonoBehaviour
{
    public Button GameStartbutton;
    public Button Deletetbutton;
    public GameObject panel;

    // Start is called before the first frame update
    void Start()
    {
        Deletetbutton.enabled = false;
        GameStartbutton.enabled = false;
        var button = gameObject.GetComponent<Button>();
        button.onClick.AddListener(() =>
        {
            Deletetbutton.enabled = true;
            GameStartbutton.enabled = true;
            panel.SetActive(false);

        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
