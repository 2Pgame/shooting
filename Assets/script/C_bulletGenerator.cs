using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class C_bulletGenerator : MonoBehaviour
{
    [SerializeField]
    public float span = 0.5f;
    float delta = 0;
    public int pow = 2;
    [SerializeField]GameSharedData sharedData;
    [SerializeField]AudioMixer audioMixer;
    // publicでクラスのインスタンスを作成
    public GameObject bulletPrefab;
    GameObject fighter;
    Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        fighter = GameObject.Find("fighterprefab");
    }

    // Update is called once per frame
    void Update()
    {
        pow = sharedData.pow;
        if (pow == 1&& Input.GetButton("Fire1"))
        {
            delta += Time.deltaTime;
            if (delta > span)
                    {
                delta = 0;
            audioMixer.SetFloat("SEVolume", -20);
            var volume = audioMixer.GetFloat("SEVolume", out float vol);
            GetComponent<AudioSource>().Play();
            }
        }
        else if (pow >= 2)
        {
            if (Input.GetButton("Fire1"))
            {

                delta += Time.deltaTime;
                pos = fighter.transform.position;
                if (delta > span)
                {
                    delta = 0;
                    audioMixer.SetFloat("SEVolume", -20);
                    var volume = audioMixer.GetFloat("SEVolume",out float vol);
                    GetComponent<AudioSource>().Play();
                    GameObject go = Instantiate(bulletPrefab);
                    go.transform.position = new Vector3(pos.x, pos.y, 0);

                }
            }
        }
    }
}
