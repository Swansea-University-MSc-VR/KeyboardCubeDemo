using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public PlayerHealth playerHealthScript;

    public float turnSpeed;
    public float movementSpeed;



    // Start is called before the first frame update  
    void Start()
    {

    }

    // Update is called once per frame  
    void Update()
    {
        if(playerHealthScript.playerCurrentHealth <= 0)
        {
            Debug.LogError("Player movement disabled");
        }
        else
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                this.transform.Translate(Vector3.forward * Time.deltaTime * movementSpeed);
            }

            if (Input.GetKey(KeyCode.DownArrow))
            {
                this.transform.Translate(Vector3.back * Time.deltaTime * movementSpeed);
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                this.transform.Rotate(Vector3.up, -turnSpeed);
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                this.transform.Rotate(Vector3.up, turnSpeed);
            }
        }
    }
}
