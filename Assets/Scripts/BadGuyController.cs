using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadGuyController : MonoBehaviour
{
    public HealthManager healthManager;

    public float damage;


    // Start is called before the first frame update
    void Start()
    {
        healthManager = GameObject.FindGameObjectWithTag("Player").GetComponent<HealthManager>();
        if(healthManager == null)
        {
            Debug.LogError("Component not found");
        }
        else
        {
            Debug.Log("Success - found Health Manager component!!!");
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            healthManager.currentHealth = healthManager.currentHealth - damage; 
            Debug.Log(healthManager.currentHealth);
        }
        else
        {
            Debug.Log("Not the Player");
        }
    }
}
