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
        if (Swap.isFuture == true)
        {
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
