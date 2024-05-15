using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Enemy3Move : MonoBehaviour
{
    public int score = 400;
    public float fallSpeed = 5;
    float DieTime = 5;
    public GameObject explosionPrefab;   //爆発エフェクトのPrefab
    [SerializeField]
    AudioClip audio1;
    [SerializeField]
    GameSharedData gameSharedData;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(fallSpeed * Time.deltaTime, 0, 0, Space.World);
        //transform.Translate(0, fallSpeed * Time.deltaTime, 0);
        StartCoroutine(DestroyCoroutine());
    }
    private IEnumerator DestroyCoroutine()
    {
        yield return new WaitForSeconds(DieTime);
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("bullet"))
        {
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            gameSharedData.playerScore += score;
            Destroy(gameObject);
            AudioSource.PlayClipAtPoint(audio1, transform.position, 20f);
            Destroy(collision.gameObject);
        }
    }
}
