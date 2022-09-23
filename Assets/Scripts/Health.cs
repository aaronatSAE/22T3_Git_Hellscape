using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float health;
    // Start is called before the first frame update
    void Start()
    {
     health =100;   
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            health -= 1;
            print("Health Decreasing");
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            health += 1;
            print("Health Increasing");
        }*/
    }
    
}
