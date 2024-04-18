using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet2Controller : MonoBehaviour
{

    float DieTime = 5;
    //public Transform player; // プレイヤーオブジェクトのTransform
    public float moveSpeed = 5.0f; // 敵の移動速度
                                   // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(0, 0, Random.Range(0, 360));
    }

    // Update is called once per frame
    void Update()
    {

        // プレイヤーに向かって移動
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);
        StartCoroutine(DestroyCoroutine());
    }
    private IEnumerator DestroyCoroutine()
    {
        yield return new WaitForSeconds(DieTime);
        Destroy(gameObject);
    }
}
