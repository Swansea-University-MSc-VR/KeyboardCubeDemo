using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerScoreCounter : MonoBehaviour
{
    public float playerScore;                   //creates a variable to carry the players score

    public TMP_Text scoreText;                  //a reference to the text mesh pro we will use for the score display


    // Start is called before the first frame update
    void Start()
    {
        playerScore = 0;                                                            //make sure player score is zero at the start
        scoreText.text = "Player Score:" + playerScore.ToString();                  //set the player score message
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Player Score:" + playerScore.ToString();                  //updates the player score message
    }
}
