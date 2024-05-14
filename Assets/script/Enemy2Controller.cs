using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Controller : MonoBehaviour
{
    public GameObject explosionPrefab;
    public GameObject powerupPrefab;
    public int score = 100;
    [SerializeField]
    AudioClip audio1;
    [SerializeField]GameSharedData gameSharedData;
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

            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            Instantiate(powerupPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
            AudioSource.PlayClipAtPoint(audio1, transform.position,20f);
            gameSharedData.playerScore += score;
            Destroy(collision.gameObject);
        }
    }
}
