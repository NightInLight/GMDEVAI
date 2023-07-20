using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
   
    bool moving;
    int direction;
    float speed = 5;
    
    void Start()
    {
        
    }

   
    void Update()
    {
            if (Input.GetAxisRaw("Horizontal") == 1) 
            direction = 0;
            if (Input.GetAxisRaw("Vertical") == 1) 
            direction = 1;
            if (Input.GetAxisRaw("Horizontal") == -1) 
            direction = 2;
            if (Input.GetAxisRaw("Vertical") == -1) 
            direction = 3;

            switch (direction)
                {
                    case 0:
                        transform.Translate(Vector3.right * Time.deltaTime * speed);
                    break;
                    case 1:
                        transform.Translate(Vector3.forward * Time.deltaTime * speed);
                    break;
                    case 2:
                        transform.Translate(Vector3.left * Time.deltaTime * speed);
                    break;
                    case 3:
                        transform.Translate(Vector3.back * Time.deltaTime * speed);
                    break;
                    
                }
            }
    
}
