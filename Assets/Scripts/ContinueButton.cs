using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueButton : MonoBehaviour
{
    public string nextLevel;

    public void ContinueGame(){

      SceneManager.LoadScene(nextLevel);

    }
}
