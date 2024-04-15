using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SamplebulletGenerator : MonoBehaviour
{
    [SerializeField] GameObject enemybullet;
    [SerializeField] GameObject fighter;
    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(nameof(Generate));
    }


    private IEnumerator Generate()
    {
        while (true)
        {
            yield return new WaitForSeconds(2);
            GameObject EnemyBullet = Instantiate(enemybullet, transform.position, Quaternion.identity);
            enemybullet.GetComponent<Samplebullet>().initialize(transform.position);
            Debug.Log(transform.position);
        }
    }
}
