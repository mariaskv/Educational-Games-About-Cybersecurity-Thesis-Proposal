using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerScript : MonoBehaviour
{

    public bool isCorrect = false;

    public QuizManager quizManager;

    public void Answer(){
        print("VALUE" + isCorrect);
        if(isCorrect == true){
            print("Correct");
            quizManager.correct();
        }
        else{
            print("False");
            quizManager.correct();
        }
    }



}
