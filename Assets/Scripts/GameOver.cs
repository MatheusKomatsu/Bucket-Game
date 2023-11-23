using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Ensure game is active
        if(!GameManager.Instance.isGameActive){
            return;
        }
    }
        void OnCollisionEnter(Collision  other){
        // Check if object is ball
        if (other.gameObject.CompareTag("Ball")){
            
            Debug.Log("GAME OVER!!!");
            // Destroy ball
            Destroy(other.gameObject);
            GameManager.Instance.isGameActive = false;
           
        }
        //Destroy(other);
    }
}
