using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusController : MonoBehaviour
{
    public PlayerScoreCounter playerScoreCounter;       //references out score counter

    public float scoreValue;                            //create a variable to carry our score value



    // Start is called before the first frame update
    void Start()
    {
        playerScoreCounter = GameObject.FindGameObjectWithTag("PlayerTag").GetComponent<PlayerScoreCounter>();  // ""
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)                                                      //when an object collides with the trigger....
    {
        if (other.tag == "PlayerTag")                                                               //if the other collider has tag == "PlayerTag"...
        {
            playerScoreCounter.playerScore = playerScoreCounter.playerScore + scoreValue;           //update the player score on the player health script
            Debug.LogWarning("The players current score is " + playerScoreCounter.playerScore);     //debug log out the current player score
        }

        else
        {
            Debug.LogError("THIS IS NOT THE PLAYER!!!");
        }


    }
}
