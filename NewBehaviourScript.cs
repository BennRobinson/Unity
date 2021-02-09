using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
     public float movementSpeed = 10;
  
     void Update(){
  
        transform.Translate(Vector3.right * movementSpeed * Time.deltaTime);
  
     }
 }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
