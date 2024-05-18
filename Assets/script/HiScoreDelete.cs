using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class HiScoreDelete : MonoBehaviour
{
    public GameObject panel;
    public Button GameStartbutton;
    public Button Deletetbutton;
    // Start is called before the first frame update
    void Start()
    {
        Deletetbutton.enabled = false;
        GameStartbutton.enabled = false;
        var button = gameObject.GetComponent<Button>();
        button.enabled = true;
        button.onClick.AddListener(() =>
        {
            PlayerPrefs.DeleteAll();
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
