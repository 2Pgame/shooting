using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy4Move : MonoBehaviour
{
    [SerializeField] float MoveSpeed = 1.0f;
    [SerializeField] int Hp = 5;
    public GameObject explosionPrefab;   //�����G�t�F�N�g��Prefab
    GameObject Enemy4Generator;
    // Start is called before the first frame update
    void Start()
    {

        Enemy4Generator = GameObject.Find("enemy4Generator");
        if (Enemy4Generator.GetComponent<Enemy4Generator>().Number == 1)
        {
            transform.position = new Vector3(-5, -20, 0);
        }
        else 
        {
            Enemy4Generator.GetComponent<Enemy4Generator>().Number = 0;
            transform.position = new Vector3(5, -20, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y >= -24)
        {
            transform.Translate(0, MoveSpeed * Time.deltaTime, 0);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("bullet")) {
            if (Hp > 0)
            {
                Hp--;
                Destroy(collision.gameObject);
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
