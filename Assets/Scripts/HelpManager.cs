using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HelpManager : MonoBehaviour
{
    public CoinsManager coinsManager;
    
    public bool available1 = true;
    public bool available2 = true;

    public GameObject button1;
    public GameObject button2;
    public GameObject button3;


    public GameObject Help1_popup;
    public GameObject Help2_popup;

    public TMP_Text Result;
    public GameObject Text1;

    public void DeActivate(){
        Help1_popup.SetActive(false);
        Help2_popup.SetActive(false);
        Text1.SetActive(!true);
        button1.SetActive(!true);
        button2.SetActive(!true);
        button3.SetActive(!true);

    }

    public void init(){
        Help1_popup.SetActive(false);
        Help2_popup.SetActive(false);
        Text1.SetActive(true);
        button1.SetActive(true);
        button2.SetActive(true);
        button3.SetActive(true);

    }

    // Start is called before the first frame update
    void Start()
    {
        // if(available1){
        //     button1.SetActive(true);
        // }
        //     if(available2){
        //     button2.SetActive(true);
        // }
    }

    // Update is called once per frame
    void Update()
    {
        if(!available1){
            button1.SetActive(!true);
            // Help1_popup.SetActive(false);
        }
        if(!available2){
            button2.SetActive(!true);
            // Help2_popup.SetActive(false);
        }
        
    }

    public void Help1(){
        Help1_popup.SetActive(true);
        available1 = false;
    }

    public void Help2(){
        Help2_popup.SetActive(true);
        available2 = false;
        int help = Random.Range(0,9);
        bool flag = true;
        
        if(help <= 3){
            flag = false;
        }

        if(flag){
            Result.text = "Ευτυχώς ο φοιτητής πληροφορικής τα κατάφερε, άλλαξε τον κωδικό ασφαλείας σε έναν πολύ ισχυρό και ο χάκερ δεν κατάφερε να μπει. Η επίθεση αντιμετωπίστηκε και εσύ κερδίζεις 15 νομίσματα.";
            coinsManager.win15();
        }
        else{
            Result.text = "Δυστυχώς φαίνεται πως ο φοιτητής πληροφορικής δεν είχε αρκετές γνώσεις για να αντιμετωπίσει την επίθεση και ο κωδικός που έβαλε δεν ήταν αρκετά δυνατός. Ο χάκερ κατάφερε να κερδίσει και εσύ χάνεις 15 νομίσματα.";
            coinsManager.lose15();
        }
    }
    
}
