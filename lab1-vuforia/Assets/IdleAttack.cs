using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleAttack : MonoBehaviour
{
    private Animator animZelda;
    private Animator animMario;
    private GameObject mario;
    private GameObject zelda;

    // Start is called before the first frame update
    void Start()
    {
        zelda = GameObject.Find("/ImageTargetZelda");
        mario = GameObject.Find("/ImageTargetMario");
        animZelda = zelda.GetComponentInChildren<Animator>();
        animMario = mario.GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (animZelda != null && animMario != null)
        {
            // if the distance between zelda and mario is less than 0.2m we attack
            if (Vector3.Distance(zelda.transform.position, mario.transform.position) < 0.2f)
            {
                animZelda.SetTrigger("Attack");
                animMario.SetTrigger("Attack");
            }
            else
            {
                animZelda.SetTrigger("Idle");
                animMario.SetTrigger("Idle");
            }
        }
    }
}

