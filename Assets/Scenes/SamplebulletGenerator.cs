using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SamplebulletGenerator : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    [SerializeField]
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(nameof(Generate));
    }


    private IEnumerator Generate()
    {
        while (true) { 
        yield return new WaitForSeconds(2);
        GameObject EnemyBullet = Instantiate(enemy,transform.position, Quaternion.identity);
        }
    }
}
