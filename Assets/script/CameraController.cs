using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    float cameraMove = -0.1f;
    [SerializeField]
    GameObject Boss;
    bool a　=true;
    bool b = true;
    bool c = true;
    bool d = true;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, cameraMove * Time.deltaTime, 0);
        if (transform.position.y < -7f  && a)
        {
            Debug.Log("最初");
            AudioManager.Instance.Play("Gunner_Queen");
            a = false;
        }
        if (transform.position.y<-34.4f && b)
        {
            Debug.Log("次");
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
    }
}
