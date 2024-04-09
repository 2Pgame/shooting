using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LB_bulletGenerator : MonoBehaviour
{
    float span;
    float delta = 0;
    public GameObject bulletPrefab135;
    GameObject fighter;
    Vector3 pos;
    [SerializeField]
    C_bulletGenerator bullet;
    int pow;
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

        if (pow >= 3)
        {
            if (Input.GetKey(KeyCode.V))
            {
                delta += Time.deltaTime;
                pos = fighter.transform.position;
                if (delta > span)
                {
                    delta = 0;
                    GameObject go = Instantiate(bulletPrefab135);
                    go.transform.position = new Vector3(pos.x - 0.25f, pos.y - 0.25f, 0);

                }
            }
        }
    }

}
