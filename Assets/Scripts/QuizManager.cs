using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuizManager : MonoBehaviour
{
    public List<QuestionAndAnswers> QnA;

    public GameObject[] options;

    public int currentQuestion;

    public TMP_Text QuestionTxT;

    public GameObject QuizPanel;
    public GameObject QuizEnd;

    public GameObject Feedback;
    public TMP_Text Feedbacktxt;

    public TMP_Text ScoreTxt;
    public int score = -1;

    public int Max;

    public SaveEmail system;

    public CoinsManager coinsManager;

    int TotalQuestions = 0;

    private void Start(){

        Max = system.Max;
        if(Max < 0){
            GameOver();
        }
        TotalQuestions = QnA.Count;
        generateQuestion();

    }

    public void GameOver(){
        QuizPanel.SetActive(false);
        QuizEnd.SetActive(true);
        if(Max < 0){
            ScoreTxt.text = "Δεν χρειάζεται να λύσεις το κουιζ συνέχισε παρακάτω";
        }
        else{
            ScoreTxt.text = "Το σκορ σας είναι: " + score + "/" + TotalQuestions;
        }

        //win -> score * 5

        // 0/0 -> lose 15

        //extra week psw -> lose 20

        //very strong psw -> win 20

        if(score == 1 && Max >= 1){
            coinsManager.win5(); 
            ScoreTxt.text += "\n Κέρδισες 5 νομίσματα";
        }
        else if(score == 2 && Max >= 2){
            coinsManager.win10();
            ScoreTxt.text += "\n Κέρδισες 10 νομίσματα";
        }
        else if(score == 3 && Max >= 3){
            coinsManager.win15();
            ScoreTxt.text += "\n Κέρδισες 15 νομίσματα";
        }
        else if(Max == -10){
            coinsManager.lose20();
            ScoreTxt.text += "\n Χάνεις 20 νομίσματα";
        }
        else if(Max == -2){
            coinsManager.win20();
            ScoreTxt.text += "\n Κέρδισες 20 νομίσματα";
        }
        else if(score == 0){
            coinsManager.lose15(); //0 correct answers
            ScoreTxt.text += "\n Χάνεις 15 νομίσματα";
        }
        // print(coinsManager.score);
    }

    public void Next(){
        Feedback.SetActive(false);
        generateQuestion();
    }

    public void correct(){
        Feedback.SetActive(true);
        Feedbacktxt.text = "Η απάντηση σας ήταν σωστή";
        score += 1;
        QnA.RemoveAt(currentQuestion);
        // generateQuestion();
    }

    public void wrong(){
        Feedback.SetActive(true);
        Feedbacktxt.text = "Η απάντηση σας ήταν λάθος. Η σωστή απάντηση στην ερώτηση: " + QnA[currentQuestion].Question + " είναι: " + QnA[currentQuestion].Answers[QnA[currentQuestion].CorrectAnswer - 1];
        QnA.RemoveAt(currentQuestion);
        // generateQuestion();
    }

    void SetAnswers(){

        for(int i = 0; i < options.Length; i++){
            options[i].GetComponent<AnswerScript>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<TMP_Text>().text = QnA[currentQuestion].Answers[i];

            if(QnA[currentQuestion].CorrectAnswer == i + 1){
               options[i].GetComponent<AnswerScript>().isCorrect = true; 
            }

        }

    }

    void generateQuestion(){
        if(QnA.Count > 0){
            currentQuestion = Random.Range(0, QnA.Count);
            QuestionTxT.text = QnA[currentQuestion].Question;
            SetAnswers();
        }
        else{
            print("Out of Questions");
            GameOver();
        }

    }
}
