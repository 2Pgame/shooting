using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3Generator : MonoBehaviour
{
    public GameObject Enemy3;
    float span = 1.0f;
    float delta = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if (delta > span)
        {
            delta = 0;
            GameObject Enemy3prefab = Instantiate(Enemy3);

        }
    }
}
