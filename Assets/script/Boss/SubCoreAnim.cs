using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubCoreAnim : MonoBehaviour
{
    Animator animator;
    [SerializeField] GameObject space;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (space.transform.position.y < -35.0f)
        {
            Debug.Log("ƒRƒA");
            animator.SetTrigger("SubCore");
        }
    }
}
