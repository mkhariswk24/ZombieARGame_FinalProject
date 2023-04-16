using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssasinAnimation : MonoBehaviour
{
    private Animator Mator;
    // Start is called before the first frame update
    void Start()
    {
        Mator = GetComponent<Animator>();
        Mator.speed = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MatorDeath() 
    {
        Mator.Play("death2", -1, 0f);
        Mator.speed = 1f;
    }

    public void MatorWalk() 
    {
        Mator.Play("sneakwalk (2)", -1, 0f);
        Mator.speed = 1f;
    }

    public void MatorRun() 
    {
        Mator.Play("run", -1, 0f);
        Mator.speed = 1f;
    }

    public void MatorIdle()
    {
        Mator.Play("idle2", -1, 0f);
        Mator.speed = 1f;
    }
}
