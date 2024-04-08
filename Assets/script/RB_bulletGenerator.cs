using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RB_bulletGenerator : MonoBehaviour
{

    float span;
    float delta = 0;

    public GameObject bulletPrefab225;
    GameObject fighter;
    Vector3 pos;
    int pow;
    [SerializeField]
    C_bulletGenerator bullet;
    // Start is called before the first frame update
    void Start()
    {
        fighter = GameObject.Find("fighter");

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
                    GameObject go = Instantiate(bulletPrefab225);
                    go.transform.position = new Vector3(pos.x + 0.25f, pos.y - 0.25f, 0);

                }
            }
        }
    }

}
