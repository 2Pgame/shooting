using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class R_bulletGenerator : MonoBehaviour
{

    float span;
    float delta = 0;

    public GameObject bulletPrefab;
    public GameObject bulletPrefab45;
    GameObject fighter;
    Vector3 pos;
    int pow;
    [SerializeField]
    C_bulletGenerator bullet;
    // Start is called before the first frame update
    void Start()
    {
        fighter = GameObject.Find("fighterprefab");

    }

    // Update is called once per frame
    void Update()
    {
        span = bullet.span;
        pow = bullet.pow;
        if (pow == 1)
        {
            if (Input.GetButton("Fire1"))
            {
                delta += Time.deltaTime;
                pos = fighter.transform.position;
                if (delta > span)
                {
                    delta = 0;
                    GameObject go = Instantiate(bulletPrefab);
                    go.transform.position = new Vector3(pos.x + 0.25f, pos.y + 0.25f, 0);

                }
            }
        }
        else if (pow >= 2)
        {
            if (Input.GetButton("Fire1"))
            {
                delta += Time.deltaTime;
                pos = fighter.transform.position;
                if (delta > span)
                {
                    delta = 0;
                    GameObject go = Instantiate(bulletPrefab45);
                    go.transform.position = new Vector3(pos.x + 0.25f, pos.y + 0.25f, 0);

                }
            }
        }
    }

}

