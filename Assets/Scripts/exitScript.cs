using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class exitScript : MonoBehaviour
{
    public TMP_Text exitText;
    private GameObject toDestroy;

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.name.Equals("Player_")){
            toDestroy = collision.gameObject;
            exitText.gameObject.SetActive(true);
            Destroy(toDestroy);
        }
    }
}
