using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    

    void Awake()
    {
        //Make Collider2D as trigger 
        GetComponent<Collider2D>().isTrigger = true;
    }

    void OnTriggerEnter2D(Collider2D Coin)
    {
        //Destroy the coin if Object tagged Player comes in contact with it
        if (Coin.CompareTag("Player"))
        {
            
           
            //Destroy coin
            Destroy(gameObject);
        }
    }
}