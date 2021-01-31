using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController : MonoBehaviour
{
    AudioSource audioSrc;
    RequestCrush script;
    BoxCollider2D npcCollider;
    public GameObject target;
    public float speed;
    public bool hasArrived;
    int idleHash;
    Animator anim;

    private void Start()
    {
        audioSrc = GetComponent<AudioSource>();
        script = FindObjectOfType<RequestCrush>();
        npcCollider = gameObject.GetComponent<BoxCollider2D>();
        anim = gameObject.GetComponent<Animator>();
        idleHash = Animator.StringToHash("hasArrived");
    }
    void Update()
    {
        if (!hasArrived)
        {
            if (!audioSrc.isPlaying)
            {
                audioSrc.Play();
            }
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, step);
        }
        if(transform.position == target.transform.position)
        {
            hasArrived = true;
            anim.SetBool(idleHash, true);
            npcCollider.enabled = true;
            audioSrc.Stop();
        }
        
    }

    private void OnMouseDown()
    {
        script.RequestMyCrush();
    }
}
