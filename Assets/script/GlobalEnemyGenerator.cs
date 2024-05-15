using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GlobalEnemyGenerator : MonoBehaviour
{
    GameObject star;
    [SerializeField] EnemyGenerator enemy;
    [SerializeField]Enemy3Generator enemy3;
    [SerializeField]Enemy4Generator enemy4;
    float enemyGeneratorStart = -8;
    float enemyGeneratorExit = -14;

    // Start is called before the first frame update
    void Start()
    {
        star = GameObject.Find("starlight");
    }

    // Update is called once per frame
    void Update()
    {
        if (star.transform.position.y <= enemyGeneratorStart && enemyGeneratorExit <= star.transform.position.y)
        {
            enemy.EnemyExist();
        }
        if (star.transform.position.y <= -14 && -16.0 <= star.transform.position.y)
        {
            enemy3.EnemyExist();
        }
        if (star.transform.position.y <= -22.5 && -24.0 <= star.transform.position.y)
        {
            enemy3.EnemyExist();
        }
        if (star.transform.position.y <= -18.5 && -22.5 <= star.transform.position.y)
        {
            enemy4.Exist();
        }
        if (star.transform.position.y <= -22.5f && -28.5f <= star.transform.position.y)
        {
            enemy.EnemyExist();
        }
        if (star.transform.position.y <= -28.5 && -33.5 <= star.transform.position.y)
        {
            enemy4.Exist();
        }
    }
}
