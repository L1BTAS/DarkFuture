using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPosition : MonoBehaviour
{
    public float futureCurrentPositionX;
    public float futureCurrentPositionY;
    private float pastCurrentPositionX;
    private float pastCurrentPositionY;
    private int pastCurrentPositionIndex = 0;
    private int futureCurrentPositionIndex = 0;
    private Vector3 holdPosition;
    private bool IsTransported = false;

    public void Update()
    {
      
       

        if (Swap.isFuture == true)
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = true;
            gameObject.GetComponent<BoxCollider2D>().enabled = true;
            gameObject.GetComponent<Rigidbody2D>().gravityScale = 1;
            if (futureCurrentPositionIndex == 0)
            {
                this.transform.position = new Vector3(futureCurrentPositionX, futureCurrentPositionY, 0);
                futureCurrentPositionIndex++;
            }
            futureCurrentPositionX = this.transform.position.x;
            futureCurrentPositionY = this.transform.position.y;
            
            pastCurrentPositionIndex = 0;
        }
        else if(Swap.isFuture==false)
        {
            if (transform.parent != null)
            {
                IsTransported = true;
                pastCurrentPositionX = GameObject.Find("HoldSpot").transform.position.x;
                pastCurrentPositionY = GameObject.Find("HoldSpot").transform.position.y;
            }

            if (!IsTransported)
            {
                gameObject.GetComponent<SpriteRenderer>().enabled = false;
                gameObject.GetComponent<BoxCollider2D>().enabled = false;
                gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;
            }

            
            futureCurrentPositionIndex = 0;
            if (pastCurrentPositionIndex==0) 
            {
                this.transform.position = new Vector3(pastCurrentPositionX, pastCurrentPositionY, 0);
                holdPosition = this.transform.position;
                pastCurrentPositionIndex++;
            }
            
            pastCurrentPositionX = this.transform.position.x;
            pastCurrentPositionY = this.transform.position.y;
            //если положение кубика изменилось
            if(this.transform.position != holdPosition)
            {
                futureCurrentPositionX = pastCurrentPositionX;
                futureCurrentPositionY = pastCurrentPositionY;
            }
            


        } 
    }

   
    
}
