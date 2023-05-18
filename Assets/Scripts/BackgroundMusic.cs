using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{

    private static BackgroundMusic backgroundMusic;

    public GameObject on;
    public GameObject off;

    void Awake(){
        if(backgroundMusic == null){
            backgroundMusic = this;
            // DontDestroyOnLoad(backgroundMusic);
        }
        else{
             Destroy(gameObject);
        }
    }

    public void On(){
        AudioListener.pause = true;
        on.SetActive(false);
        off.SetActive(true);
        
    }

    public void Off(){
        AudioListener.pause = false;
        off.SetActive(false);
        on.SetActive(true);
        
    }

}
