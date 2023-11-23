using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
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
            // Increase score
            GameManager.Instance.score++;
            Debug.Log("Score " + GameManager.Instance.score );
            // Destroy ball
            Destroy(other.gameObject);
           
        }
        //Destroy(other);
    }
}
