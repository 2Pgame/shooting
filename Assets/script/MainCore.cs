using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCore : MonoBehaviour
{
    [SerializeField] int Hp = 2;
    public GameObject explosionPrefab;   //�����G�t�F�N�g��Prefab
    public GameObject damage;
    public GameObject subCore1;
    public GameObject Boss;
    // Start is called before the first frame update
    void Start()
    {
        Boss.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("bullet") && subCore1 == null)
        {
            if (Hp > 0)
            {
                Debug.Log("��������");
                Hp--;
                Destroy(collision.gameObject);
                GameObject DamageEffect = Instantiate(damage, collision.transform.position, Quaternion.identity) as GameObject;
                Destroy(DamageEffect, 0.1f);
            }
            else
            {
                Instantiate(explosionPrefab, transform.position, Quaternion.identity);
                Boss.SetActive(true);
                Destroy(gameObject);
                Destroy(collision.gameObject);
            }
        }
        else 
        {
            Destroy(collision.gameObject);
        }

    }

}
