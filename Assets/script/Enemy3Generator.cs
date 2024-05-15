using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3Generator : MonoBehaviour
{
    public GameObject Enemy3;
    float span = 1.0f;
    float delta = 0;
    // Start is called before the first frame update
    void Start()
    {

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
            // 指定されたプレハブを使用して新しい敵オブジェクトを生成し、一意の名前を割り当てます。
            Instantiate(Enemy3);
            Enemy3.transform.position = new Vector3(-10, -24.0f, 0);
        }
    }

    
}
