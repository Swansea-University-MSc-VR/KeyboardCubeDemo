using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public float playerMaxHealth;
    public float playerCurrentHealth;

    public Material deadMaterial;

    public float playerScore;

    public TMP_Text gameOverText;
    public TMP_Text scoreText;
    public TMP_Text healthText;

    // Start is called before the first frame update
    void Start()
    {
        playerCurrentHealth = playerMaxHealth;
        playerScore = 0;
        gameOverText.text = "";
        scoreText.text = "Player Score:" + playerScore.ToString();
        healthText.text = "Player Health: " + playerCurrentHealth.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Player Score:" + playerScore.ToString();
        healthText.text = "Player Health: " + playerCurrentHealth.ToString();

        if (playerCurrentHealth <= 0)
        {
            gameOverText.text = "Game Over!";

            SceneManager.LoadScene("BlueCubeScene");

            this.GetComponent<Renderer>().material = deadMaterial;
            Debug.LogError("The player has reached " + playerCurrentHealth + " health.");

        }
    }
}
