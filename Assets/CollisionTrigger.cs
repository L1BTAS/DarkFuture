using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTrigger : MonoBehaviour
{
    Rigidbody2D rb;
    private bool IsTreeGrown;
    public GameObject Tree;
    public GameObject TriggerObject;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

   private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Object"))
        {
            if (Swap.isFuture == false)
            {
                IsTreeGrown = true;
            }
            if(IsTreeGrown == true&& Swap.isFuture == true)
            {
                Tree.SetActive(true);
                TriggerObject.SetActive(false);
            }
            
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (Swap.isFuture == false)
        {
            if (collision.gameObject.name.Equals("Object"))
            {

                Tree.SetActive(false);
                IsTreeGrown = false;
            }
        }
    }
    private void Update()
    {
        if (Swap.isFuture == false)
        {
            Tree.SetActive(false);
            TriggerObject.SetActive(true);

        }

       
       
    }
}
