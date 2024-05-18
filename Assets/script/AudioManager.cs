using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AudioManager : MonoBehaviour
{

    [SerializeField] GameObject space;
    private static AudioManager instance;
    [SerializeField] private AudioSource aud;
    [SerializeField] private AudioSource aud_loop;
    [SerializeField] private AudioSource aud_end;
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
    public void Play_loop(string clipName)
    {
        if (!_clips.ContainsKey(clipName))
        {
            throw new System.Exception("sound" + clipName + "is not defined");
        }
        aud_loop.clip = _clips[clipName];
        aud_loop.Play();
    }
    public void Play_end(string clipName)
    {
        if (!_clips.ContainsKey(clipName))
        {
            throw new System.Exception("sound" + clipName + "is not defined");
        }
        aud_end.clip = _clips[clipName];
        aud_end.Play();
    }
    public void Stop()
    {
        aud.Stop();
    }
    public void Stop_loop()
    {
        aud_loop.Stop();
    }
    public void Stop_end()
    {
        aud_end.Stop();
    }
}
