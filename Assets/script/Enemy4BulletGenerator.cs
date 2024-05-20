using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy4BulletGenerator : MonoBehaviour
{
    [SerializeField]
    GameObject enemy4;
    [SerializeField]
    GameObject enemybullet;
    [SerializeField]GameSharedData gameSharedData;
    int Number;
    int Angle;
    float time;
    float span= 0.3f;
    // Start is called before the first frame update
    void Start()
    {
        if (gameSharedData.game == "Normal")
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
        if (enemy4.transform.position.y <= -24  && time> span)
        {
            time = 0;
            Instantiate(enemybullet, enemy4.transform.position, Quaternion.identity);
            //Angle = 
            //int angle = Angle * 10;
            //enemybullet.transform.Rotate(0, 0, Random.Range(0, 360));
        }
    }
}
