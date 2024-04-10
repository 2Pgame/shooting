using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class EnemybulletController : MonoBehaviour
{
   GameObject fighter;
   GameObject Enemy3;
    //public Transform player; // �v���C���[�I�u�W�F�N�g��Transform
    public float moveSpeed = 5.0f; // �G�̈ړ����x
    // Start is called before the first frame update
    void Start()
    {
        fighter = GameObject.Find("fighterprefab");
        Enemy3 = GameObject.Find("enemy3prefab");
        transform.position = Enemy3.transform.position;
        // �Ώە��ւ̃x�N�g�����Z�o
        Vector3 toDirection = fighter.transform.position - transform.position;
        // �Ώە��։�]����
        transform.rotation = Quaternion.FromToRotation(Vector3.up, toDirection);
    }

    // Update is called once per frame
    void Update()
    {
        // �v���C���[�Ɍ������Ĉړ�
        transform.Translate(0, moveSpeed * Time.deltaTime,0);
    }
}
