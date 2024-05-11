using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpController : MonoBehaviour
{


 
    GameObject bulletController;

    // Start is called before the first frame update
    void Start()
    {
        bulletController = GameObject.Find("bulletController");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -0.1f * Time.deltaTime, 0);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
        bulletController.GetComponent<C_bulletGenerator>().pow++;
        Destroy(gameObject);
        }
    }
}
