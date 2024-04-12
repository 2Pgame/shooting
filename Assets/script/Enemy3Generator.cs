using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3Generator : MonoBehaviour
{
    public GameObject Enemy3;
    float span = 1.0f;
    float delta = 0;
    GameObject star;
    // Start is called before the first frame update
    void Start()
    {
        star = GameObject.Find("starlight");
        // ゲーム開始時に、敵を即座に生成し始め、その後1秒ごとに繰り返し生成します。
        //InvokeRepeating(nameof(SpawnEnemy), 0f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        if (star.transform.position.y <= -10 && -10.5 <= star.transform.position.y)
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
                // 指定されたプレハブを使用して新しい敵オブジェクトを生成し、一意の名前を割り当てます。
                var enemy = Instantiate(Enemy3);
                enemy.name = $"Enemy3prefab"; // 敵オブジェクトの名前に連番をつけて、一意に識別できるようにします。
            Enemy3.transform.position = new Vector3(-10, -24.0f, 0);
        }
    }

    
}
