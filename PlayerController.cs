using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float speed;
    private Animator animator;
    private Rigidbody rb;
    private int vida;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate ()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");
	
	if (Input.GetKey(KeyCode.W)) // Hago que cuando pulse la W la esfera (Player) suba x coordenadas.
	{
            	rb.AddForce(Vector3.up * 10.0f);
        }

	Vector3 movement = new Vector3 (moveHorizontal, moveVertical, 0.0f);

        rb.AddForce (movement * speed);
    }

    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag ( "Enemy"))
        {
            vida = vida -1;
        }
    }
}
