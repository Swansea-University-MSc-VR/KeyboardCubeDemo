using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusController : MonoBehaviour
{
    public PlayerHealth playerHealthScript;

    public float scoreValue;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        playerHealthScript.playerScore = playerHealthScript.playerScore + scoreValue;
        Debug.LogWarning("The players current score is " + playerHealthScript.playerScore);
    }
}
