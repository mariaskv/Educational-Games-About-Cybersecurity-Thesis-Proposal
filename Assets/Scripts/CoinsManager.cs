using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoinsManager : MonoBehaviour
{

    public TMP_Text scoreText;

    public int score;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = score.ToString() + " Νομίσματα";
    }

    // Update is called once per frame
    void Update()
    {
        // scoreText.text = score.ToString() + " Νομίσματα";
    }

    public void show(){
        print(score.ToString() + " Νομίσματα");
    }

    public void lose20(){ //for attack 2, 3 and easy password
        score = score - 20;
        scoreText.text = score.ToString() + " Νομίσματα";
    }

    public void lose15(){ //for 0 correct answers
        score = score - 15;
         scoreText.text = score.ToString() + " Νομίσματα";
    }

    public void lose5(){ //for 1 correct answer
        score = score - 5;
         scoreText.text = score.ToString() + " Νομίσματα";
    }

    public void win5(){ //for 2 correct answers
        score = score + 5;
         scoreText.text = score.ToString() + " Νομίσματα";
    }

    public void win10(){ //for 3 correct answers
        score = score + 10;
         scoreText.text = score.ToString() + " Νομίσματα";
    }

    public void win15(){ //attack 1 and strong password
        score = score + 15;
         scoreText.text = score.ToString() + " Νομίσματα";
    }

    public void win20(){ //for attack 2, 3 and strong password
        score = score + 20;
         scoreText.text = score.ToString() + " Νομίσματα";
    }

}


