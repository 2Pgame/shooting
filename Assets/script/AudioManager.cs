using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AudioManager : MonoBehaviour
{

    [SerializeField] GameObject space;
    private static AudioManager instance;
    [SerializeField] private AudioSource aud;
    private readonly Dictionary<string,AudioClip> _clips = new Dictionary<string,AudioClip>();

    public static AudioManager Instance
    {
        get { return instance; }
    }
    private void Awake()
    {
        if (null != instance)
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
        instance = this;
        var audioClips = Resources.LoadAll<AudioClip>("SE BGM");
        foreach (var clip in audioClips)
        {
            _clips.Add(clip.name, clip);
        }
    }

    public void Play(string clipName)
    {
        if (!_clips.ContainsKey(clipName))
        {
            throw new System.Exception("sound" + clipName + "is not defined");
        }
        aud.clip = _clips[clipName];
        aud.Play();
    }
    public void Stop()
    {
        aud.Stop();
    }


    // Start is called before the first frame update
    void Start()
    {
        //aud = GetComponent<AudioSource>();
        //Invoke("BGM", 3);
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
        //aud.PlayOneShot(audio1);
    }
}
