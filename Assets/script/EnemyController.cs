using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public int point = 100;
    public float rotSpeed = 360;
    public float fallSpeed = -5;
    float DieTime = 5;
    public GameObject explosionPrefab;   //爆発エフェクトのPrefab
    // Start is called before the first frame update
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, fallSpeed * Time.deltaTime, 0, Space.World);
        transform.Rotate(0, 0, rotSpeed * Time.deltaTime);
        //transform.Translate(0, fallSpeed * Time.deltaTime, 0);
        StartCoroutine(DestroyCoroutine());
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("bullet"))
        {
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }


    private IEnumerator DestroyCoroutine()
    {
        yield return new WaitForSeconds(DieTime);
        Destroy(gameObject);
    }
}


