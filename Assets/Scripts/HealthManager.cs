using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public float maximumHealth;
    public float currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maximumHealth;
        Debug.Log("The players starting health is: " + currentHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if(currentHealth <= 0)
        {
            Debug.LogError("The player has reached " + currentHealth + " and has died!!"); 
        }
    }
}
