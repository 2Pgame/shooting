using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public int point = 100;
    public float rotSpeed = 360;
    public float fallSpeed = -5;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, fallSpeed*Time.deltaTime, 0,Space.World);
        transform.Rotate(0, 0, rotSpeed*Time.deltaTime);
        //transform.Translate(0, fallSpeed * Time.deltaTime, 0);
    }
}
