using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBulletGenerator1 : MonoBehaviour
{

    [SerializeField]
    GameObject subCore1;
    [SerializeField]
    GameObject subCore2;
    [SerializeField]
    GameSharedData gameSharedData;
    [SerializeField]
    GameObject enemybullet2;
    int Number;
    int Angle;
    float time;
    float span = 0.3f;
    // Start is called before the first frame update
    void Start()
    {
        if(gameSharedData.game == "normal")
        { }
        else
        {
            span = 0.2f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (subCore1 == null && subCore2 == null && time > span)
        {
            time = 0;
            Instantiate(enemybullet2,transform.position, Quaternion.identity);
            //Angle = 
            //int angle = Angle * 10;
            //enemybullet.transform.Rotate(0, 0, Random.Range(0, 360));
        }
    }
}