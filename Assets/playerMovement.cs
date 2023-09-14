using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    private Animator anim;
    public float speed = 3.5f;  // basic moving speed
    private Vector2 movement;   // movement on 2D

    private bool isDiagonal = false;
    private bool noDelayStarted = false;
    public float delay = 0.05f; // starting speed
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxisRaw("Horizontal");  
        float inputY = Input.GetAxisRaw("Vertical");
        movement = new Vector2(inputX, inputY); // takes players input and makes it a direction

        ResetAnimations();

        if (inputX == 0 && inputY == 0)
        {
            anim.SetBool("idle", true);
        }

        else if (movement.y == -1)
        {
            anim.SetBool("down", true);
        }

        else if (movement.y == 1)
        {
            anim.SetBool("up", true);
        }

        transform.Translate(movement * speed * Time.deltaTime); // adds together movement direction, speed and a continuous/smooth reaction
    }

    void ResetAnimations()
    {
        anim.SetBool("idle", false);
        anim.SetBool("up", false);
        anim.SetBool("down", false);

    }
}
