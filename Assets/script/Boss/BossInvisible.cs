using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossInvisible : MonoBehaviour
{
    public GameObject star;
    public GameObject boss;
    // Start is called before the first frame update
    void Start()
    {
        boss.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (star.transform.position.y < -35f)
        {

            boss.SetActive(true);
            if (boss.transform.position.y > -23.2f) 
            { 
            boss.transform.Translate(0,-1 * Time.deltaTime, 0);
            }
        }
    }
}
