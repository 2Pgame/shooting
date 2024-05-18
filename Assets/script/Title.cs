using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    [SerializeField]GameSharedData gameSharedData;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(gameSharedData.GameOverName);
        Debug.Log(gameSharedData.playerScore);
    }

    // Update is called once per frame
    void Update()
    {

    }

}
