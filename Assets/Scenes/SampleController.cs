using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleController : MonoBehaviour
{
    Vector3 pos1;
    float Speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal;
        float vertical;
        horizontal = Input.GetAxis("Horizontal");
        //�c�����͂�l�ŕԂ��ϐ��uy�v�Ɋi�[
        vertical = Input.GetAxis("Vertical");
        pos1 = transform.position;


        pos1.x += horizontal * Time.deltaTime * Speed;
        pos1.y += vertical * Time.deltaTime * Speed;

        transform.position = pos1;
    }
}
