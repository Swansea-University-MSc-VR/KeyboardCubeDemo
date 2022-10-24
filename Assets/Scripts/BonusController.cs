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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)                                                  //when an object collides with the trigger....
    {
        playerHealthScript.playerScore = playerHealthScript.playerScore + scoreValue;           //update the player score on the player health script
        Debug.LogWarning("The players current score is " + playerHealthScript.playerScore);     //debug log out the current player score
    }
}
