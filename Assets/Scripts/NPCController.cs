using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController : MonoBehaviour
{
    public GameObject target;
    public float speed;
    public bool hasArrived;
    int idleHash;
    Animator anim;

    private void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        idleHash = Animator.StringToHash("hasArrived");
    }
    void Update()
    {
        if (!hasArrived)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, step);
            print(transform.position);
        }
        if(transform.position == target.transform.position)
        {
            hasArrived = true;
            anim.SetBool(idleHash, true);
        }
        
    }
}
