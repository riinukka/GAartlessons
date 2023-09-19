using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collection : MonoBehaviour
{
    //Particle used
    public GameObject particle;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Test if trigger works
        Debug.Log("Trigger works!");
        Instantiate(particle,transform.position,transform.rotation);
        Destroy(gameObject);
    }
}
