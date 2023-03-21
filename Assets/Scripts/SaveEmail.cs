using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class SaveEmail : MonoBehaviour
{

    public InputField Email;
    public InputField Password;
    string TempEmail;
    string TempPassword;
    public GameObject popup;
    // public GameObject image;

    // Start is called before the first frame update
    // void Start()

    // {
    //     TempEmail = PlayerPrefs.GetString("tutorialTextKeyName");
    //     Email.text = TempEmail;
    // }

    public void SaveThis(){
        TempEmail = Email.text;
        PlayerPrefs.SetString("tutorialTextKeyName", TempEmail);

        TempPassword = Password.text;
        PlayerPrefs.SetString("tutorialTextKeyName", TempPassword);
        // image.SetActive(false);
        popup.SetActive(true);

    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
