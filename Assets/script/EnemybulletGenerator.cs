using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemybulletGenerator : MonoBehaviour
{
    public GameObject enemybullet;
    public GameObject fighter;
    float span = 1.0f;
    float delta = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (fighter.active == false)
        {
            return;
        }
        else if(fighter.active&& enemybullet)
        {
            this.delta += Time.deltaTime;
            if (delta > span)
            {
                delta = 0;
                GameObject EnemyBullet = Instantiate(enemybullet);

            }
        }
    }
}
