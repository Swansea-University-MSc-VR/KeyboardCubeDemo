using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public PlayerHealth playerHealthScript;         //creates a new reference to the player health script we made

    public float turnSpeed;                         //creates a floating point variable to control turn speed
    public float movementSpeed;                     //creates a floating point variable to control movement speed



    // Start is called before the first frame update  
    void Start()
    {

    }

    // Update is called once per frame  
    void Update()
    {
        if(playerHealthScript.playerCurrentHealth <= 0)                 //if the player current health variable which is on the player health script is equal to or less than zero...
        {
            Debug.LogError("Player movement disabled");                 //statement to say movement is disabeled
        }
        else
        {
            if (Input.GetKey(KeyCode.UpArrow))                                                  //when up key os pressed...
            {
                this.transform.Translate(Vector3.forward * Time.deltaTime * movementSpeed);     //this object move forward
            }

            if (Input.GetKey(KeyCode.DownArrow))                                                //when down key is pressed...
            {
                this.transform.Translate(Vector3.back * Time.deltaTime * movementSpeed);        //this object move back
            }

            if (Input.GetKey(KeyCode.LeftArrow))                                                //when left key is pressed...
            {
                this.transform.Rotate(Vector3.up, -turnSpeed);                                  //rotate left
            }

            if (Input.GetKey(KeyCode.RightArrow))                                               //when right key is pressed...
            {
                this.transform.Rotate(Vector3.up, turnSpeed);                                   //rotate to the right
            }
        }
    }
}
