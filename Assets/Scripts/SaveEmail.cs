using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using System.Text.RegularExpressions;
using TMPro;
using UnityEngine.UI;

public class SaveEmail : MonoBehaviour
{

    public InputField Email;
    public InputField Password;
    string TempEmail;
    string TempPassword;

    public InputField EmailSocial;
    public InputField PasswordSocial;
    string TempEmailSocial;
    string TempPasswordSocial;

    public InputField EmailBank;
    public InputField PasswordBank;
    string TempEmailBank;
    string TempPasswordBank;

    public InputField NewPasswordSocial;

    public GameObject popup;
    public GameObject popup1;
    public GameObject popup2;


    public string ResSocial;
    public string ResEmail;
    public string ResBank;

    public TMP_Text Social;

    // public PrintResults a;

    public void SaveThis(){
        TempEmail = Email.text;
        PlayerPrefs.SetString("tutorialTextKeyName", TempEmail);

        TempPassword = Password.text;
        PlayerPrefs.SetString("tutorialTextKeyName", TempPassword);
        popup.SetActive(true);

    }

    public void SaveSocial(){
        TempEmailSocial = EmailSocial.text;
        PlayerPrefs.SetString("socialemail", TempEmailSocial);

        TempPasswordSocial = PasswordSocial.text;
        PlayerPrefs.SetString("socialpass", TempPasswordSocial);
        PlayerPrefs.Save();
        popup1.SetActive(true);

    }

    public void SaveBank(){
        TempEmailBank = EmailBank.text;
        PlayerPrefs.SetString("tutorialTextKeyName", TempEmailBank);

        TempPasswordBank = PasswordBank.text;
        PlayerPrefs.SetString("tutorialTextKeyName", TempPasswordBank);
        popup2.SetActive(true);

    }

    public void ChangePasswordSocial(){

        TempPasswordSocial = NewPasswordSocial.text;
        PlayerPrefs.SetString("socialpass", TempPasswordSocial);
        PlayerPrefs.Save();

        // a.Start()
        print(TempPasswordSocial);
        // print(CheckPasswordSocial());

    }


    public void CheckPasswordSocial(){
        string pass = PlayerPrefs.GetString("socialpass");
        print("Change Pass:" + pass);
        bool result = Regex.IsMatch(pass, "^[a-zA-Z0-9]+$" );
        bool result1 = Regex.IsMatch(pass, "^[a-zA-Z]+$");
        bool result2 = Regex.IsMatch(pass, "^[0-9]+$");
        if(result1 && !result2){
            ResSocial = "Your password is simple";
        }
        else if(result2 && !result1){
            ResSocial = "Your password is simple";
        }
        else if(result){
            ResSocial = "Your password is average";
        }
        else {
            ResSocial = "Your password is strong";
        }
        Social.text = ResSocial;
    }

}
