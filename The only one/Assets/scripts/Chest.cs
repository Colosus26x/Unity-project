using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    Animator myAnin;


    // Start is called before the first frame update
    void Start()
    {
        myAnin = GetComponent<Animator>();

    }
    private void OnTriggerStay2D(Collider2D col)

    {
        if (col.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                myAnin.Play("chest_open");
            }
        }
        
        {
           
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
