using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_bulletGenerator : MonoBehaviour
{
    [SerializeField]
    public float span = 0.5f;
    float delta = 0;
    public int pow = 2;
    // publicでクラスのインスタンスを作成
    public GameObject bulletPrefab;
    GameObject fighter;
    Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        fighter = GameObject.Find("fighter");
    }

    // Update is called once per frame
    void Update()
    {
        if (pow == 1)
        {

        }
        else if (pow >= 2)
        {
            if (Input.GetKey(KeyCode.V))
            {
                delta += Time.deltaTime;
                pos = fighter.transform.position;
                if (delta > span)
                {
                    delta = 0;
                    GameObject go = Instantiate(bulletPrefab);
                    go.transform.position = new Vector3(pos.x, pos.y, 0);

                }
            }
        }
    }
}
