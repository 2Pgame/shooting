using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubCore : MonoBehaviour
{
    int score = 2000;
    [SerializeField]GameSharedData gameSharedData;
    [SerializeField] int Hp = 2;
    [SerializeField] AudioClip audio1;
    [SerializeField] AudioClip audio2;
    [SerializeField] GameObject space;
    public GameObject explosionPrefab;   //爆発エフェクトのPrefab
    public GameObject damage;
    public GameObject canonfound;

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
        if (collision.CompareTag("bullet") && space.transform.position.y < -36.0f)
        {
            if (Hp > 0)
            {
                Hp--;
                AudioSource.PlayClipAtPoint(audio1, transform.position);
                Destroy(collision.gameObject);
                GameObject DamageEffect = Instantiate(damage, collision.transform.position, Quaternion.identity) as GameObject;
                Destroy(DamageEffect, 0.1f);
            }
            else
            {
                Instantiate(explosionPrefab, transform.position, Quaternion.identity);
                AudioSource.PlayClipAtPoint(audio2, transform.position, 20f);
                gameSharedData.playerScore += score;
                Destroy(gameObject);
                Destroy(canonfound);
                Destroy(collision.gameObject);
            }
        }
        else 
        {
            AudioSource.PlayClipAtPoint(audio1, transform.position);
        }
    }
}
