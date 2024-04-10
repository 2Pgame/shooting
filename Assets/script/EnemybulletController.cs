using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class EnemybulletController : MonoBehaviour
{
   GameObject fighter;
   GameObject Enemy3;
    //public Transform player; // プレイヤーオブジェクトのTransform
    public float moveSpeed = 5.0f; // 敵の移動速度
    // Start is called before the first frame update
    void Start()
    {
        fighter = GameObject.Find("fighterprefab");
        Enemy3 = GameObject.Find("enemy3prefab");
        transform.position = Enemy3.transform.position;
        // 対象物へのベクトルを算出
        Vector3 toDirection = fighter.transform.position - transform.position;
        // 対象物へ回転する
        transform.rotation = Quaternion.FromToRotation(Vector3.up, toDirection);
    }

    // Update is called once per frame
    void Update()
    {
        // プレイヤーに向かって移動
        transform.Translate(0, moveSpeed * Time.deltaTime,0);
    }
}
