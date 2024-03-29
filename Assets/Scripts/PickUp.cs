using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PickUp : MonoBehaviour
{
    public Transform holdSpot;
    public LayerMask pickUpMask;
    public Vector3 Direction { get; set; }

    private GameObject itemHolding;

    public void pickUp(InputAction.CallbackContext context)
    {
        if (itemHolding)
        {
            itemHolding.transform.parent = null;
            if (itemHolding.GetComponent<Rigidbody2D>())
                itemHolding.GetComponent<Rigidbody2D>().simulated = true;
            itemHolding = null;
        }
        else
        {
            Collider2D pickUpItem = Physics2D.OverlapCircle(transform.position + Direction, .9f, pickUpMask);
            if (pickUpItem)
            {
                itemHolding = pickUpItem.gameObject;
                itemHolding.transform.position = holdSpot.position;
                itemHolding.transform.parent = transform;
                if (itemHolding.GetComponent<Rigidbody2D>())
                    itemHolding.GetComponent<Rigidbody2D>().simulated = false;
                    
            }
        }
    }
}
