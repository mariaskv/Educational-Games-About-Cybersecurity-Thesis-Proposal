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

    void Update(){
        if(Input.GetKeyDown(KeyCode.Escape)){
            Time.timeScale = 1 - Time.timeScale;
            if(Time.timeScale == 0){
                AudioListener.pause = true;
            }
            else{
                AudioListener.pause = false;
            }
        }
        if(Input.GetKeyDown(KeyCode.Space)){
            AudioListener.pause = true;
        }
    }

    public void On(){
        AudioListener.volume = 0;
        on.SetActive(false);
        off.SetActive(true);
        
    }

    public void Off(){
        AudioListener.volume = 1.5f;
        off.SetActive(false);
        on.SetActive(true);
        
    }

}
