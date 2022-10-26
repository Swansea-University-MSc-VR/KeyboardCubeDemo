using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusController : MonoBehaviour
{
    public PlayerHealth playerHealthScript;             //reference to our player health script

    public float scoreValue;                            //create a variable to carry our score value



    // Start is called before the first frame update
    void Start()
    {
        playerHealthScript = GameObject.FindGameObjectWithTag("PlayerTag").GetComponent<PlayerHealth>();        //find the gameobject with the tag ("PlayerTag") and get the component we are looking for

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)                                                      //when an object collides with the trigger....
    {
        if (other.tag == "PlayerTag")                                                               //if the other collider has tag == "PlayerTag"...
        {
            playerHealthScript.playerScore = playerHealthScript.playerScore + scoreValue;           //update the player score on the player health script
            Debug.LogWarning("The players current score is " + playerHealthScript.playerScore);     //debug log out the current player score
        }

        else
        {
            Debug.LogError("THIS IS NOT THE PLAYER!!!");
        }


    }
}
