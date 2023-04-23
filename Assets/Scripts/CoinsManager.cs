using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoinsManager : MonoBehaviour
{

    public TMP_Text scoreText;

    public int score = 100;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = score.ToString() + " Νομίσματα";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void show(){
        print(score.ToString() + " Νομίσματα");
    }

    public void lose20(){
        score = score - 20;
    }

    public void lose15(){
        score = score - 15;
    }

    public void lose5(){
        score = score - 5;
    }

    public void win5(){
        score = score + 5;
    }

    public void wind10(){
        score = score + 10;
    }

    public void win15(){
        score = score + 15;
    }

    public void win20(){
        score = score + 20;
    }

}


