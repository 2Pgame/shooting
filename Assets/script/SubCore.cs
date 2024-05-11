using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubCore : MonoBehaviour
{
    [SerializeField] int Hp = 2;
    public GameObject explosionPrefab;   //爆発エフェクトのPrefab
    public GameObject damage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("bullet"))
        {
            if (Hp > 0)
            {
                Hp--;
                Destroy(collision.gameObject);
                GameObject DamageEffect = Instantiate(damage, collision.transform.position, Quaternion.identity) as GameObject;
                Destroy(DamageEffect, 0.1f);
            }
            else
            {
                Instantiate(explosionPrefab, transform.position, Quaternion.identity);
                Destroy(gameObject);
                Destroy(collision.gameObject);
            }
        }
    }
}
