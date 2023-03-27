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

    public void SaveThis(){
        TempEmail = Email.text;
        PlayerPrefs.SetString("tutorialTextKeyName", TempEmail);

        TempPassword = Password.text;
        PlayerPrefs.SetString("tutorialTextKeyName", TempPassword);
        popup.SetActive(true);

    }

    public void SaveSocial(){
        TempEmailSocial = EmailSocial.text;
        PlayerPrefs.SetString("tutorialTextKeyName", TempEmailSocial);

        TempPasswordSocial = PasswordSocial.text;
        PlayerPrefs.SetString("tutorialTextKeyName", TempPasswordSocial);
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
        PlayerPrefs.SetString("tutorialTextKeyName", TempPasswordSocial);
        PasswordSocial = NewPasswordSocial;
    }


}
