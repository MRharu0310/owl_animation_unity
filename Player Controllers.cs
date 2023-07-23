using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllers : MonoBehaviour
{
    private Animator animator;
  
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            animator.SetBool("blink",true);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            animator.SetBool("blink",false);
        }
        if (Input.GetKey(KeyCode.R))
        {
            animator.SetBool("reaction",true);
        }
        if (Input.GetKeyUp(KeyCode.R))
        {
            animator.SetBool("reaction",false);
        }
        if (Input.GetKey(KeyCode.F))
        {
            animator.SetBool("smile",true);
        }
        if (Input.GetKeyUp(KeyCode.F))
        {
            animator.SetBool("smile",false);
        }
        if (Input.GetKey(KeyCode.X))
        {
            animator.SetBool("ask",true);
        }
        if (Input.GetKeyUp(KeyCode.X))
        {
            animator.SetBool("ask",false);
        }



        if (Input.GetKey(KeyCode.A))
        {
            animator.SetBool("right hand",true);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            animator.SetBool("right hand",false);
        }
         if (Input.GetKey(KeyCode.Q))
        {
            animator.SetBool("right wave",true);
        }
        if (Input.GetKeyUp(KeyCode.Q))
        {
            animator.SetBool("right wave",false);
        }


        if (Input.GetKey(KeyCode.S))
        {
            animator.SetBool("both hand",true);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            animator.SetBool("both hand",false);
        }
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("both wave",true);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            animator.SetBool("both wave",false);
        }


        if (Input.GetKey(KeyCode.D))
        {
            animator.SetBool("left hand",true);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            animator.SetBool("left hand",false);
        }
        if (Input.GetKey(KeyCode.E))
        {
            animator.SetBool("left wave",true);
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            animator.SetBool("left wave",false);
        }


        if (Input.GetKey(KeyCode.DownArrow))
        {
            animator.SetBool("head down",true);
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            animator.SetBool("head down",false);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            animator.SetBool("head up",true);
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            animator.SetBool("head up",false);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            animator.SetBool("look right",true);
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            animator.SetBool("look right",false);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            animator.SetBool("look left",true);
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            animator.SetBool("look left",false);
        }


        if (Input.GetKey(KeyCode.Z))
        {
            animator.SetBool("what right",true);
        }
        if (Input.GetKeyUp(KeyCode.Z))
        {
            animator.SetBool("what right",false);
        }
        if (Input.GetKey(KeyCode.C))
        {
            animator.SetBool("what left",true);
        }
        if (Input.GetKeyUp(KeyCode.C))
        {
            animator.SetBool("what left",false);
        }


        if (Input.GetKey(KeyCode.V))
        {
            animator.SetBool("clap",true);
        }
        if (Input.GetKeyUp(KeyCode.V))
        {
            animator.SetBool("clap",false);
        }
       
        
    }
}
