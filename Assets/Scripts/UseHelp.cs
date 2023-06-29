using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UseHelp : MonoBehaviour
{

    string help1 = "";
    bool h1 = true;

    string help2 = "";
    bool h2 = true;

    public TMP_Text HelpResult;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Help(){

         HelpResult.text = "";

        if(h1){
            HelpResult.text += help1;
        }
        if(h2){
            HelpResult.text += help2;
        }

    }
}
