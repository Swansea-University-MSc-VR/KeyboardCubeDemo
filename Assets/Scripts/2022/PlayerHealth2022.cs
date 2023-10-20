using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth2022 : MonoBehaviour
{
    public float playerMaxHealth;               //creates a variable to carry the player max health value
    public float playerCurrentHealth;           //creates a variable to carry the players current health value

    public Slider healthSlider;                 //reference to health slider

    public Material deadMaterial;               //a reference to the material we will use when player has died


    public TMP_Text gameOverText;               //a reference to the text mesh pro we will use for the game over message
    public TMP_Text healthText;                 //a reference to the text mesh pro we will use for the health display

    // Start is called before the first frame update
    void Start()
    {
        playerCurrentHealth = playerMaxHealth;                                      //set the player current health to equal the max health value
        gameOverText.text = "";                                                     //keeps ganme over text blank
        healthText.text = "Player Health: " + playerCurrentHealth.ToString();       //set the player health message
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = "Player Health: " + playerCurrentHealth.ToString();       //updates the player health message

        healthSlider.value = playerCurrentHealth;                                   //set the slider value to the value of player health

        if (playerCurrentHealth <= 0)                                                       //if the player health is less than or equal to zero....
        {
            gameOverText.text = "Game Over!";                                               //update the game over text

            SceneManager.LoadScene("BlueCubeScene");                                        //load the new scene

            this.GetComponent<Renderer>().material = deadMaterial;                          //set the player material to the dead material
            Debug.LogError("The player has reached " + playerCurrentHealth + " health.");   //debug log message the player hrealth value

        }
    }
}
