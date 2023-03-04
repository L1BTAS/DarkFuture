using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPosition : MonoBehaviour
{
    private float currentPositionX;
    private float currentPositionY;
    public bool CurrentTime;
    public void Update()
    {
        if (Swap.isFuture == false)
        {
            CurrentTime = Swap.isFuture;
            currentPositionX = this.transform.position.x;
            currentPositionY = this.transform.position.y;
        }
        else if(CurrentTime!= Swap.isFuture)
        {

            this.transform.position = new Vector3(currentPositionX, currentPositionY, 0);
            CurrentTime = Swap.isFuture;
        }
        Debug.Log(currentPositionX);
    }
    
}
