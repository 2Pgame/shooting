using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemybulletGenerator : MonoBehaviour
{
    public GameObject enemybullet;
    [SerializeField] GameSharedData gameSharedData;
    GameObject fighter;
    float span = 1.0f;
    float delta = 0;
    // Start is called before the first frame update
    void Start()
    {
        fighter = GameObject.Find("fighterprefab");
        if (gameSharedData.game == "Normal")
        { }
        else
        {
            span = 0.7f;
        }
            //StartCoroutine(nameof(Generate));

    }

    // Update is called once per frame


    [System.Obsolete]
    void Update()
    {
        this.delta += Time.deltaTime;
        if (!fighter)
        {
            return;
        }
        else if (fighter.active == true && enemybullet)
        {
            if (delta > span)
            {
                delta = 0;
                GameObject EnemyBullet = Instantiate(enemybullet, transform.position, Quaternion.identity);
                enemybullet.GetComponent<EnemybulletController>().initialize(transform.position);
                Debug.Log(transform.position);
            }
        }
    }
    //private IEnumerator Generate()
    //{
    //    while (true)
    //    {
    //        yield return new WaitForSeconds(2);
            
    //    }
    //}
}
