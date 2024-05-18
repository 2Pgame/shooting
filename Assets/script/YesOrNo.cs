using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YesOrNo : MonoBehaviour
{
    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
        var button = GetComponent<Button>();
        button.enabled = true;
        button.onClick.AddListener(() =>
        {
            panel.SetActive(true);
        });

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
