using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Controller : MonoBehaviour
{
    public GameObject explosionPrefab;
    public GameObject powerupPrefab;
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
            Destroy(collision.gameObject);
        }
    }
}