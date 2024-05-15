using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy4Generator : MonoBehaviour
{
    [SerializeField] GameObject Enemy4prefab;
    public int Number;
    float time;
    float span = 4.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Exist()
    {
        time += Time.deltaTime;
        if (time > span)
        {
            time = 0;
            Number++;
            Instantiate(Enemy4prefab);
        }
    }
}
