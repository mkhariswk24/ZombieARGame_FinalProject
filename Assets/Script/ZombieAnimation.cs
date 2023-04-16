using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAnimation : MonoBehaviour
{
    private Animator Anim;
    // Start is called before the first frame update
    void Start()
    {
        Anim = GetComponent<Animator>();
        Anim.speed = 0f;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AnimAttack()
    {
        Anim.Play("Z_Attack", -1, 0f);
        Anim.speed = 1f;
    }

    public void AnimRun()
    {
        Anim.Play("Z_Run", -1, 0f);
        Anim.speed = 1f;
    }

    public void AnimWalk()
    {
        Anim.Play("Z_Walk", -1, 0f);
        Anim.speed = 1f;
    }

    public void AnimIdle()
    {
        Anim.Play("Z_Idle", -1, 0f);
        Anim.speed = 1f;
    }
}
