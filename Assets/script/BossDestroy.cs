using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossDestroy : MonoBehaviour
{

    public GameObject explosionPrefab;
    public GameObject Boss;
    [SerializeField] AudioClip audio1;
    [SerializeField]GameSharedData gameSharedData1;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("BossExplosion", 0f, 0.1f);
        // 3秒後に全てのInvokeをキャンセル（止める）
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
        AudioSource.PlayClipAtPoint(audio1, transform.position, 20f);
    }
    void StopRepeating()
    {
        // 全てのInvokeRepeatingをキャンセル
        CancelInvoke("BossExplosion");
        gameSharedData1.stageClear = true;
        Destroy(Boss);

    }
}
