using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemybulletGenerator : MonoBehaviour
{
    public GameObject enemybullet;

    GameObject fighter;
    float span = 1.0f;
    float delta = 0;
    // Start is called before the first frame update
    void Start()
    {
        fighter = GameObject.Find("fighterprefab");

            StartCoroutine(nameof(Generate));

    }

    // Update is called once per frame


    [System.Obsolete]
    void Update()
    {
        //if (fighter.active == false)
        //{
        //    return;
        //}
        //else if(fighter.active&& enemybullet)
        //{

        //}
    }
    private IEnumerator Generate()
    {
        while (true)
        {
            yield return new WaitForSeconds(2);
            GameObject EnemyBullet = Instantiate(enemybullet, transform.position, Quaternion.identity);
            enemybullet.GetComponent<EnemybulletController>().initialize(transform.position);
            Debug.Log(transform.position);
        }
    }
}
