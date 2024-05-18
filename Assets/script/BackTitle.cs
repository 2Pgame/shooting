using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackTitle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Title", 10f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") || Input.GetButtonDown("Fire2") || Input.GetButtonDown("Fire3"))
        {
            SceneManager.LoadScene("Title");
        }
    }
    void Title()
    {
        SceneManager.LoadScene("Title");
    }
}
