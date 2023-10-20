using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour
{
    public TMP_Text scoreText, healthText;

    // Start is called before the first frame update
    void Start()
    {
        if(scoreText == null || healthText == null)
        {
            Debug.LogError("Check your Text Mesh Pro assignments!!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
