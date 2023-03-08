using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoinsManager : MonoBehaviour
{

    public TMP_Text scoreText;

    int score = 100;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = score.ToString() + " Νομίσματα";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
