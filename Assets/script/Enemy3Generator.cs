using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3Generator : MonoBehaviour
{
    public GameObject Enemy3;
    float span = 1.0f;
    float delta = 0;
    GameObject star;
    // Start is called before the first frame update
    void Start()
    {
        star = GameObject.Find("starlight");
        // �Q�[���J�n���ɁA�G�𑦍��ɐ������n�߁A���̌�1�b���ƂɌJ��Ԃ��������܂��B
        //InvokeRepeating(nameof(SpawnEnemy), 0f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        if (star.transform.position.y <= -10 && -10.5 <= star.transform.position.y)
        {
            EnemyExist();
        }

    }
    void EnemyExist()
    {
        this.delta += Time.deltaTime;
        if (delta > span)
        {
            delta = 0;
                // �w�肳�ꂽ�v���n�u���g�p���ĐV�����G�I�u�W�F�N�g�𐶐����A��ӂ̖��O�����蓖�Ă܂��B
                var enemy = Instantiate(Enemy3);
                enemy.name = $"Enemy3prefab"; // �G�I�u�W�F�N�g�̖��O�ɘA�Ԃ����āA��ӂɎ��ʂł���悤�ɂ��܂��B
            Enemy3.transform.position = new Vector3(-10, -24.0f, 0);
        }
    }

    
}
