using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBulletController : MonoBehaviour
{
    float DieTime = 5;
    //public Transform player; // �v���C���[�I�u�W�F�N�g��Transform
    public float moveSpeed = -5.0f; // �G�̈ړ����x
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(0, moveSpeed * Time.deltaTime, 0);
        StartCoroutine(DestroyCoroutine());
    }
    private IEnumerator DestroyCoroutine()
    {
        yield return new WaitForSeconds(DieTime);
        Destroy(gameObject);
    }
}