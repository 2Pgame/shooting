using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip audio1;
    public AudioClip audio2;
    public AudioClip audio3;
    [SerializeField] GameObject space;
    AudioSource aud;
    // Start is called before the first frame update
    void Start()
    {
        aud = GetComponent<AudioSource>();
        Invoke("BGM", 3);
    }

    // Update is called once per frame
    void Update()
    {
        //if (space.transform.position.y < -34)
        //{
        //    aud.PlayOneShot(audio2);
        //}
    }
    void BGM()
    {
        aud.PlayOneShot(audio1);
    }
}
