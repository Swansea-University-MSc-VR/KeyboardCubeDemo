using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{
    public Transform[] spawnPoints;             //creates array for spawn points to be referenced

    public GameObject damageGameObject;         //reference for our damage object prefab

    public GameObject bonusScoreObject;         //reference for our score opbject prefab

    public int spawnNumberDamageObject;         //reference for which spawn point in the array we will use for damage object

    public int spawnNumberBonusObject;          //reference for which spawn point in the array for the score/bonus object

    // Start is called before the first frame update
    void Start()
    {

        GenerateRandomNumber();                 //calls the 'generate random number' function
        RandomNumberChecker();                  //calls the 'random number checker' function

        Instantiate(damageGameObject, spawnPoints[spawnNumberDamageObject].transform.position, Quaternion.identity);    //instantiate/creates a gameobject (gameobject (the prefab), position (the position we are using is based on the spawn point from our array), rotation)
        Instantiate(bonusScoreObject, spawnPoints[spawnNumberBonusObject].transform.position, Quaternion.identity);     //instantiate/creates a gameobject (gameobject (the prebab), position (the position we are using is based on the spawn point from our array), rotation)


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RandomNumberChecker()
    {
        if(spawnNumberDamageObject == spawnNumberBonusObject)           //if the spawn numbers are equal to each other...
        {
            Debug.LogWarning("The random numbers were the same - Damage number was " + spawnNumberDamageObject + "; Bonus number was " + spawnNumberBonusObject);
            GenerateRandomNumber();                                     //generate a new number
        }
    }

    public void GenerateRandomNumber()
    {
        Debug.LogWarning("Generating random numbers...");
        spawnNumberDamageObject = Random.Range(0, spawnPoints.Length);      //select a random number between 0 and the length of the array
        spawnNumberBonusObject = Random.Range(0, spawnPoints.Length);       //select a random number between 0 and the length of the array
    }
}
