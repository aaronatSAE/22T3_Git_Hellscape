using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeansScript : MonoBehaviour
{
    float doubleJumpLimit = 0.8f;
    float jumpTimer;


    // Start is called before the first frame update
    void Start()
    {
        jumpTimer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            jumpTimer += Time.deltaTime;
            Debug.Log(jumpTimer);
            while(jumpTimer < doubleJumpLimit)
            {
                Debug.Log("DoubleJump Happened");
            }
            if (jumpTimer > doubleJumpLimit)
            {
                jumpTimer = 0f;
            }
        }
    }
}
