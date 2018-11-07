using UnityEngine;
using System.Collections;

public class MainAnimation : MonoBehaviour 
{
    Animator anim;
    int movimientoLateral = Animator.StringToHash("Movimiento Lateral");
    int salto = Animator.StringToHash("Salto");


    void Start ()
    {
        anim = GetComponent<Animator>();
    }


    void Update ()
    {
        float move = Input.GetAxis ("Horizontal");
        anim.SetFloat("Speed", move);

        if(Input.GetKey(KeyCode.W))
        {
            anim.SetTrigger (salto);
        }
	if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
	{
	    anim.SetTrigger (movimientoLateral);
	}
    }
}