using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using YourCompany.Utilities;

public class fighterController : MonoBehaviour
{
    //座標の変数定義
    Vector3 pos1;
    [SerializeField]
    float Speed = 2.0f;
    [SerializeField] CircleCollider2D circleCollider;
    [SerializeField] float cooldown = 6.0f;
    [SerializeField] Invincibility invincibility;
    public GameObject PowerUpPrefab;
    public GameObject explosionPrefab;
    public GameObject fighterPrefab;
    public GameObject mainCore;
    public GameObject Boss;


    // Start is called before the first frame update
    void Start()
    {
        PowerUpPrefab.SetActive(false);
        circleCollider = GetComponent<CircleCollider2D>();
        //オブジェクトの現在の座標を入手
        //pos1.y = 0;
    }
    // Update is called once per frame
    void Update()
    {
        float horizontal;
        float vertical;

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
        pos1.y += vertical * Time.deltaTime * Speed;
        if (Boss != null && fighterPrefab.transform.position.y < -32f)
        {
            pos1.y = Mathf.Clamp(pos1.y, -10f + Camera.main.transform.position.y, 10.0f + Camera.main.transform.position.y);
            FirstMove();
        }
        else if (Boss != null)
        {
            pos1.y = Mathf.Clamp(pos1.y, -4.4f + Camera.main.transform.position.y, 4.0f + Camera.main.transform.position.y);
            transform.position = pos1;
        }
        else
        {
            pos1.y = Mathf.Clamp(pos1.y, -6f + Camera.main.transform.position.y, 10.0f + Camera.main.transform.position.y);
            Invoke("Move", 3f);
        }

        if (mainCore == null)
        {
            Debug.Log("終わり");
            //ずっと無敵で終わる
            invincibility.SetInvincibility2();
        }
        if (fighterPrefab.transform.position.y > -20.0f)
        {
            Debug.Log("クリア");
            Destroy(fighterPrefab);
        }

    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.CompareTag("Item"))
        {
            PowerUpPrefab.SetActive(true);
            Invoke("PowerUp", 1.0f);
            Destroy(coll.gameObject);
        }
        if (coll.CompareTag("Enemy"))
        {
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            fighterPrefab.SetActive(false);
            Destroy(coll.gameObject);
            //3秒後に復活６秒間点滅コライダー無効
            Invoke("Dead", 3);
        }
        if (coll.CompareTag("EnemyBullet"))
        {
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            fighterPrefab.SetActive(false);
            Destroy(coll.gameObject);
            //3秒後に復活６秒間点滅コライダー無効
            Invoke("Dead", 3);
        }
        if (coll.CompareTag("Boss"))
        {
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            fighterPrefab.SetActive(false);
            //3秒後に復活６秒間点滅コライダー無効
            Invoke("Dead", 3);
        }
    }
    //時期が破壊された時の挙動
    private void Dead()
    {
        fighterPrefab.SetActive(true);
        //無敵メソッド
        invincibility.SetInvincibility();
    }
    //パワーアップをとった時の挙動
    void PowerUp()
    {
        PowerUpPrefab.SetActive(false);
    }
    //クリア時の自機の挙動をつかさどるメソッド
    void LastMove()
    {
        transform.Translate(0, 3 * Time.deltaTime, 0);
    }
    //最初の自機の挙動をつかさどるメソッド
    void FirstMove()
    {
        transform.Translate(0, 2 * Time.deltaTime, 0);
    }
}
