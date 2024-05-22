using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraController : MonoBehaviour
{
    float cameraMove = -0.2f;
    [SerializeField]
    GameObject Boss;
    [SerializeField]
    GameSharedData gameSharedData;
    bool a;
    bool b;
    bool c;
    bool d;
    bool e;
    // Start is called before the first frame update
    void Start()
    {
        a = true;
        b = true;
        c = true;
        d = true;
        e = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > -34.0)
        {
            cameraMove = -0.2f;
        }
        else
        {
            cameraMove = -0.1f;
        }
        transform.Translate(0, cameraMove * Time.deltaTime, 0);
        if (transform.position.y < -7f  && a)
        {
            AudioManager.Instance.Stop();
            Debug.Log("最初");
            Invoke("Opening", 3f);
            a = false;
        }
        if (transform.position.y<-34.4f && b)
        {
            Debug.Log("次");
            AudioManager.Instance.Stop_loop();
            AudioManager.Instance.Play("警報・アラート音");
            b = false;
        }
        if (transform.position.y < -34.8f && c)
        {
            Debug.Log("次");
            AudioManager.Instance.Play("Incandescent");
            c = false;
        }
        if (Boss == null && d)
        {
            AudioManager.Instance.Play("We&#039re_gonna_do_it!");
            d = false;
        }
        if (gameSharedData.myFighter<0&& e)
        {
            AudioManager.Instance.Stop();
            AudioManager.Instance.Stop_loop();
            AudioManager.Instance.Play_end("game-over1");
            e = false;
            Invoke("HiScore", 15f);
        }
    }
    void HiScore()
    {
        SceneManager.LoadScene("HiScore");
    }
    void Title()
    {
        SceneManager.LoadScene("Title");
    }
    void Opening() 
    {
        AudioManager.Instance.Play_loop("Gunner_Queen");
    }
}
