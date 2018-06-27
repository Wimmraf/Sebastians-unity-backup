using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    public Animator anim;

    //Use this for intialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    //Update is called once per frama
    void Update()
    {
        if (Input.GetButtonUp("Fire1"))
        {
            anim.SetTrigger("Attacking");
        }
    }
}