using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickShotController : MonoBehaviour
{
    [SerializeField]GameSharedData gameSharedData;
     
 
    GameObject bulletController;

    // Start is called before the first frame update
    void Start()
    {
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
        gameSharedData.span -= 0.05f;
        Destroy(gameObject);
        }
    }
}
