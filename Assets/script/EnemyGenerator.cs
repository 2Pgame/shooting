using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject Enemyprefab;
    [SerializeField]GameSharedData gameSharedData;
    float span = 1.0f;
    float delta = 0;
    // Start is called before the first frame update
    void Start()
    {
        if (gameSharedData.game == "Normal")
        {
        }
        else
        {
            span = 0.5f;
        }
    }

    // Update is called once per frame
    void Update()
    {



    }
    public void EnemyExist()
    {
        this.delta += Time.deltaTime;
        if (delta > span)
        {
            delta = 0;
            GameObject Enemy = Instantiate(Enemyprefab);
            int px = Random.Range(-10, 10);
            Enemy.transform.position = new Vector3(px, -20.0f, 0);
        }
    }
}
