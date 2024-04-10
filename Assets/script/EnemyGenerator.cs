using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject Enemyprefab;
    GameObject star;
    float span = 1.0f;
    float delta = 0;
    // Start is called before the first frame update
    void Start()
    {
        star = GameObject.Find("starlight");
    }

    // Update is called once per frame
    void Update()
    {
        if (star.transform.position.y <= -7 && -9 <= star.transform.position.y)
        {
            EnemyExist();
        }

    }
    void EnemyExist()
    {
        this.delta += Time.deltaTime;
        if (delta > span)
        {
            delta = 0;
            GameObject Enemy = Instantiate(Enemyprefab);
            int px = Random.Range(-10, 10);
            Enemy.transform.position = new Vector3(px, 18.4f, 0);
        }
    }
}
