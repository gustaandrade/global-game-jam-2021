using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController : MonoBehaviour
{
    public RequestCrush script;
    BoxCollider2D npcCollider;
    public GameObject target;
    public float speed;
    public bool hasArrived;
    int idleHash;
    Animator anim;

    private void Start()
    {
        script = FindObjectOfType<RequestCrush>();
        npcCollider = gameObject.GetComponent<BoxCollider2D>();
        anim = gameObject.GetComponent<Animator>();
        idleHash = Animator.StringToHash("hasArrived");
    }
    void Update()
    {
        if (!hasArrived)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, step);
        }
        if(transform.position == target.transform.position)
        {
            hasArrived = true;
            anim.SetBool(idleHash, true);
            npcCollider.enabled = true;
        }
        
    }

    private void OnMouseDown()
    {
        script.RequestMyCrush();
    }
}
