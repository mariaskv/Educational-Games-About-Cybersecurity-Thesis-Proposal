using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{

    private static BackgroundMusic backgroundMusic;

    public GameObject on;
    public GameObject off;

    void Start(){
        // if(backgroundMusic == null){
            backgroundMusic = this;
            DontDestroyOnLoad(backgroundMusic);
        // }
        // else{
        //      Destroy(gameObject);
        // }
    }

    public void On(){
        AudioListener.volume = 0;
        on.SetActive(false);
        off.SetActive(true);
        
    }

    public void Off(){
        AudioListener.volume = 0.8f;
        off.SetActive(false);
        on.SetActive(true);
        
    }

}
