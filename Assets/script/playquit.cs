using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playquit : MonoBehaviour
{
   //public GameObject playerManager;
    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if (collision.transform.tag == "enemy") 
        {
            manager.GameOver = true;
            gameObject.SetActive(false);
        }
    }
}
