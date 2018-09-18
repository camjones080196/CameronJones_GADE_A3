using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opendoor : MonoBehaviour {

    Animator anim;
    BoxCollider2D door;

    void Start()
    {
        anim = GameObject.FindGameObjectWithTag("Door1").GetComponent<Animator>();
        door = GameObject.FindGameObjectWithTag("Door1").GetComponent<BoxCollider2D>();
    }

    
    void Update () {
		
	}

    private void OnTriggerStay2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "Player")
        {

            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Opening");
                anim.SetBool("Closed", false);
                anim.SetBool("Opened", true);
                door.enabled = false;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
            Debug.Log("Closing");
            anim.SetBool("Opened", false);
            anim.SetBool("Closed", true);
            door.enabled = true;
        }
    }
}
