using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class fighterController : MonoBehaviour
{
    //���W�̕ϐ���`
    Vector3 pos1;
    [SerializeField]
    float Speed = 2.0f;
    [SerializeField]
    float SP = 0.025f;
    // Start is called before the first frame update
    void Start()
    {
        //�I�u�W�F�N�g�̌��݂̍��W�����
        //pos1.y = 0;
    }
    // Update is called once per frame
    void Update()
    {
        float horizontal;
        float vertical;

        //if (transform.position.x > 8.0f)
        //{
        //    //�������͂�l�ŕԂ��ϐ��ux�v�Ɋi�[
        //    horizontal = Input.GetAxis("Horizontal");
        //    //�c�����͂�l�ŕԂ��ϐ��uy�v�Ɋi�[
        //    vertical = Input.GetAxis("Vertical");
        //    if (horizontal > 0)
        //    {
        //        horizontal = 0;
        //        transform.Translate(horizontal * Time.deltaTime * Speed, vertical * Time.deltaTime * Speed, 0);
        //    }
        //    else
        //    {
        //        transform.Translate(horizontal * Time.deltaTime * Speed, vertical * Time.deltaTime * Speed, 0);
        //    }

        //}
        //else if (transform.position.x < -8.0f)
        //{
        //    //�������͂�l�ŕԂ��ϐ��ux�v�Ɋi�[
        //    horizontal = Input.GetAxis("Horizontal");
        //    //�c�����͂�l�ŕԂ��ϐ��uy�v�Ɋi�[
        //    vertical = Input.GetAxis("Vertical");
        //    if (horizontal < 0)
        //    {
        //        horizontal = 0;
        //        transform.Translate(horizontal * Time.deltaTime * Speed, vertical * Time.deltaTime * Speed, 0);
        //    }
        //    else
        //    {
        //        transform.Translate(horizontal * Time.deltaTime * Speed, vertical * Time.deltaTime * Speed, 0);
        //    }
        //}
        //else if (transform.position.y > 4.0f)
        //{
        //    //�������͂�l�ŕԂ��ϐ��ux�v�Ɋi�[
        //    horizontal = Input.GetAxis("Horizontal");
        //    //�c�����͂�l�ŕԂ��ϐ��uy�v�Ɋi�[
        //    vertical = Input.GetAxis("Vertical");
        //    if (vertical > 0)
        //    {
        //        vertical = 0;
        //        transform.Translate(horizontal * Time.deltaTime * Speed, vertical * Time.deltaTime * Speed, 0);
        //    }
        //    else
        //    {
        //        transform.Translate(horizontal * Time.deltaTime * Speed, vertical * Time.deltaTime * Speed, 0);

        //    }
        //}



        //else
        //{
        //�������͂�l�ŕԂ��ϐ��ux�v�Ɋi�[
        horizontal = Input.GetAxis("Horizontal");
        //�c�����͂�l�ŕԂ��ϐ��uy�v�Ɋi�[
        vertical = Input.GetAxis("Vertical");
        ////�ϐ��upos�v��x���ɂ�������W�𖈃t���[�����Ɂux�v�̕���������
        //transform.Translate(horizontal * Time.deltaTime * Speed, vertical * Time.deltaTime * Speed, 0);
        //}
        pos1 = transform.position;


        pos1.x += horizontal * Time.deltaTime * Speed;

        //vector3�̓��[�v�̂��߃R���W������˂�������
        //- 3����3�܂ł��������Ȃ��悤�ɔ���
        pos1.x = Mathf.Clamp(pos1.x, -8.0f, 8.0f);

        //�ϐ��upos�v��y���ɂ�������W�𖈃t���[�����Ɂuy�v�̕���������
        pos1.y += vertical * Time.deltaTime * Speed + 0.1f*Time.deltaTime;
        pos1.y = Mathf.Clamp(pos1.y, -4.4f+Camera.main.transform.position.y, 4.0f + Camera.main.transform.position.y);

        transform.position = pos1;


    }
}
