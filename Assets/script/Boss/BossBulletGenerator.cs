using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBulletGenerator : MonoBehaviour
{
    [SerializeField]
    GameObject enemybullet;
    [SerializeField]
    GameObject foundation;
    [SerializeField]
    Transform bulletPoint;
    [SerializeField]
    Transform bulletPoint2;
    GameObject EnemyBullet;
    GameObject EnemyBullet2;
    [SerializeField]GameSharedData gameSharedData;
    [SerializeField]
    GameObject boss;
    float span = 1.0f;
    float delta = 0;
    // Start is called before the first frame update
    void Start()
    {
        if (gameSharedData.game == "normal")
        { }
        else 
        {
            span = 0.7f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (boss != null && boss.transform.position.y < -20.2f)
        {
            this.delta += Time.deltaTime;
            if (delta > span)
            {
                delta = 0;

                EnemyBullet = Instantiate(enemybullet, bulletPoint.transform.position, bulletPoint.transform.rotation);
                EnemyBullet2 = Instantiate(enemybullet, bulletPoint2.transform.position, bulletPoint2.transform.rotation);
                Debug.Log(transform.position);
            }
        }
    }
}
