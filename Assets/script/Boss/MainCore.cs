using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCore : MonoBehaviour
{
    int score = 5000;
    [SerializeField] int Hp = 2;
    [SerializeField] AudioClip audio1;
    [SerializeField] AudioClip audio2;
    [SerializeField]GameSharedData gameSharedData;
    public GameObject explosionPrefab;   //爆発エフェクトのPrefab
    public GameObject damage;
    public GameObject subCore1;
    public GameObject subCore2;
    public GameObject Boss;
    public float time;
  
    // Start is called before the first frame update
    void Start()
    {
        Boss.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameSharedData.myFighter >= 0)
        {
            time += Time.deltaTime;
        }
        else 
        {
        }
        if (time > 60)
        {
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            Boss.SetActive(true);
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("bullet") && subCore1 == null&& subCore2 == null)
        {
            if (Hp > 0)
            {
                Debug.Log("当たった");
                Hp--;
                AudioSource.PlayClipAtPoint(audio1, transform.position);
                Destroy(collision.gameObject);
                GameObject DamageEffect = Instantiate(damage, collision.transform.position, Quaternion.identity) as GameObject;
                Destroy(DamageEffect, 0.1f);
            }
            else
            {
                Instantiate(explosionPrefab, transform.position, Quaternion.identity);
                Boss.SetActive(true);
                AudioSource.PlayClipAtPoint(audio2, transform.position,20f);
                gameSharedData.playerScore += score;
                Destroy(gameObject);
                Destroy(collision.gameObject);
            }
        }
        else
        {
            if (collision.CompareTag("bullet"))
            {
                AudioSource.PlayClipAtPoint(audio1, transform.position);
                Destroy(collision.gameObject);
            }
        }

    }

}
