using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPosition : MonoBehaviour
{
    public float currentPositionX;
    public float currentPositionY;
    private int currentPositionIndex = 0;


    public void Update()
    {
        Debug.Log(transform.parent);
       

        if (Swap.isFuture == true)
        {
            if (transform.parent != null)
            {
                currentPositionX = GameObject.Find("HoldSpot").transform.position.x;
                currentPositionY = GameObject.Find("HoldSpot").transform.position.y;
            }
            currentPositionIndex = 0;
        }
        else if(Swap.isFuture==false)
        {
            
            if (currentPositionIndex==0) 
            {
                this.transform.position = new Vector3(currentPositionX, currentPositionY, 0);
                currentPositionIndex++;
            }
            
            currentPositionX = this.transform.position.x;
            currentPositionY = this.transform.position.y;
          

        } 
    }

   
    
}
