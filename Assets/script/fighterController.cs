using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class fighterController : MonoBehaviour
{
    //座標の変数定義
    Vector3 pos1;
    [SerializeField]
    float Speed = 2.0f;
    [SerializeField]
    float SP = 0.025f;
    // Start is called before the first frame update
    void Start()
    {
        //オブジェクトの現在の座標を入手
        //pos1.y = 0;
    }
    // Update is called once per frame
    void Update()
    {
        float horizontal;
        float vertical;

        //if (transform.position.x > 8.0f)
        //{
        //    //横矢印入力を値で返し変数「x」に格納
        //    horizontal = Input.GetAxis("Horizontal");
        //    //縦矢印入力を値で返し変数「y」に格納
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
        //    //横矢印入力を値で返し変数「x」に格納
        //    horizontal = Input.GetAxis("Horizontal");
        //    //縦矢印入力を値で返し変数「y」に格納
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
        //    //横矢印入力を値で返し変数「x」に格納
        //    horizontal = Input.GetAxis("Horizontal");
        //    //縦矢印入力を値で返し変数「y」に格納
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
        //横矢印入力を値で返し変数「x」に格納
        horizontal = Input.GetAxis("Horizontal");
        //縦矢印入力を値で返し変数「y」に格納
        vertical = Input.GetAxis("Vertical");
        ////変数「pos」のx軸における座標を毎フレーム毎に「x」の分だけ増加
        //transform.Translate(horizontal * Time.deltaTime * Speed, vertical * Time.deltaTime * Speed, 0);
        //}
        pos1 = transform.position;


        pos1.x += horizontal * Time.deltaTime * Speed;

        //vector3はワープのためコリジョンを突き抜ける
        //- 3から3までしか動けないように縛る
        pos1.x = Mathf.Clamp(pos1.x, -8.0f, 8.0f);

        //変数「pos」のy軸における座標を毎フレーム毎に「y」の分だけ増加
        pos1.y += vertical * Time.deltaTime * Speed + 0.1f*Time.deltaTime;
        pos1.y = Mathf.Clamp(pos1.y, -4.4f+Camera.main.transform.position.y, 4.0f + Camera.main.transform.position.y);

        transform.position = pos1;


    }
}
