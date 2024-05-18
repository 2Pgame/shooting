using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class GameStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var button = GetComponent<Button>();
        button.enabled = true;
        button.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("InputField");
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
