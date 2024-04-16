using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy4Move : MonoBehaviour
{
    [SerializeField] private float moveAngle;
    [SerializeField] private float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (moveAngle >= 0)
        {
            moveAngle++;
        }
        else if (moveAngle < 30) { }
    }
}
