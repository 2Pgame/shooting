using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Audio", 3f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Audio()
    {
        //AudioManager.Instance.Play("Gunner_Queen");
    }
}
