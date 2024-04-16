using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Samplebullet : MonoBehaviour
{
    [SerializeField] GameObject capsle;
    [SerializeField] GameObject enemy;
    public float moveSpeed = 5.0f; // �G�̈ړ����x
    // Start is called before the first frame update
    public void initialize(Vector3 initialPosition)
    {
        transform.position = initialPosition;
    }
    private void Start()
    {
        
    // �Ώە��ւ̃x�N�g�����Z�o
    Vector3 toDirection = capsle.transform.position - transform.position;
        // �Ώە��։�]����
        transform.rotation = Quaternion.FromToRotation(Vector3.up, toDirection);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);
    }
}
