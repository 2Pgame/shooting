using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using YourCompany.Utilities;

public class fighterController : MonoBehaviour
{
    //���W�̕ϐ���`
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
        //�I�u�W�F�N�g�̌��݂̍��W�����
        //pos1.y = 0;
    }
    // Update is called once per frame
    void Update()
    {
        float horizontal;
        float vertical;

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
            Debug.Log("�I���");
            //�����Ɩ��G�ŏI���
            invincibility.SetInvincibility2();
        }
        if (fighterPrefab.transform.position.y > -20.0f)
        {
            Debug.Log("�N���A");
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
            //3�b��ɕ����U�b�ԓ_�ŃR���C�_�[����
            Invoke("Dead", 3);
        }
        if (coll.CompareTag("EnemyBullet"))
        {
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            fighterPrefab.SetActive(false);
            Destroy(coll.gameObject);
            //3�b��ɕ����U�b�ԓ_�ŃR���C�_�[����
            Invoke("Dead", 3);
        }
        if (coll.CompareTag("Boss"))
        {
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            fighterPrefab.SetActive(false);
            //3�b��ɕ����U�b�ԓ_�ŃR���C�_�[����
            Invoke("Dead", 3);
        }
    }
    //�������j�󂳂ꂽ���̋���
    private void Dead()
    {
        fighterPrefab.SetActive(true);
        //���G���\�b�h
        invincibility.SetInvincibility();
    }
    //�p���[�A�b�v���Ƃ������̋���
    void PowerUp()
    {
        PowerUpPrefab.SetActive(false);
    }
    //�N���A���̎��@�̋����������ǂ郁�\�b�h
    void LastMove()
    {
        transform.Translate(0, 3 * Time.deltaTime, 0);
    }
    //�ŏ��̎��@�̋����������ǂ郁�\�b�h
    void FirstMove()
    {
        transform.Translate(0, 2 * Time.deltaTime, 0);
    }
}
