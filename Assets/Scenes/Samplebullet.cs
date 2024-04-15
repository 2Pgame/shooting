using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Samplebullet : MonoBehaviour
{
    [SerializeField] GameObject capsle;
    [SerializeField] GameObject enemy;
    public float moveSpeed = 5.0f; // 敵の移動速度
    // Start is called before the first frame update
    void Start()
    {
        transform.position = enemy.transform.position;
        // 対象物へのベクトルを算出
        Vector3 toDirection = capsle.transform.position - enemy.transform.position;
        // 対象物へ回転する
        transform.rotation = Quaternion.FromToRotation(Vector3.up, toDirection);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);
    }
}
