using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class Swap : MonoBehaviour
{
    public GameObject FutureGround;
    public GameObject PastGround;
   static public bool isFuture = true;

    void Update()
    {
        if (isFuture == true)
        {
            FutureGround.SetActive(true);
            PastGround.SetActive(false);
        }
        else
        {
            FutureGround.SetActive(false);
            PastGround.SetActive(true);

        }

    }
    public void TimeSwap(InputAction.CallbackContext context)
    {
        
        isFuture = !isFuture;
        
    }

}   
    
   
 