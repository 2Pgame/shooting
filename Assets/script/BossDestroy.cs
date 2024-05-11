using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossDestroy : MonoBehaviour
{

    public GameObject explosionPrefab;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("BossExplosion", 0f, 0.3f);
        // 3�b��ɑS�Ă�Invoke���L�����Z���i�~�߂�j
        Invoke("StopRepeating", 3.0f);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void BossExplosion()
    {
        float randomX = Random.Range(-5, 5);
        float randomY = Random.Range(-3, 3);

        Instantiate(explosionPrefab, transform.position - new Vector3(randomX, randomY, 0), Quaternion.identity);
    }
    void StopRepeating()
    {
        // �S�Ă�InvokeRepeating���L�����Z��
        CancelInvoke("BossExplosion");
    }
}