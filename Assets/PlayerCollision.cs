using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D other)
   {
        if (other.gameObject.tag == "Anker")
        {
            SceneManager.LoadScene("Main");
        }
        


       



   }
}
