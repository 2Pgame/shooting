using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleGenerator : MonoBehaviour
{
    [SerializeField] GameObject circle;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = circle.transform.position;
        InvokeRepeating(nameof(Generate),1, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Generate()
    {
        Instantiate(circle,transform.position,Quaternion.identity);
    }
}
