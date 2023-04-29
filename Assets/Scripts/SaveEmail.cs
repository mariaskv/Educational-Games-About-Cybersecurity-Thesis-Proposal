using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using System.Text.RegularExpressions;
using TMPro;
using UnityEngine.UI;

public class SaveEmail : MonoBehaviour
{

    CoinsManager c;

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
    public InputField NewPasswordEmail;
    public InputField NewPasswordBank;

    public GameObject popup;
    public GameObject popup1;
    public GameObject popup2;


    public string ResSocial;
    public string ResEmail;
    public string ResBank;

    public TMP_Text Social;
    public TMP_Text EmailRes;
    public TMP_Text BankRes;

    // public PrintResults a;

    public int Max;

    void Start(){
        c = GameObject.FindGameObjectWithTag("Coins").GetComponent<CoinsManager>();
    }

    public void SaveThis(){
        TempEmail = Email.text;
        PlayerPrefs.SetString("tutorialTextKeyName", TempEmail);

        TempPassword = Password.text;
        PlayerPrefs.SetString("emailpass", TempPassword);
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
        PlayerPrefs.SetString("bankpass", TempPasswordBank);
        popup2.SetActive(true);

    }

    public void ChangePasswordSocial(){

        TempPasswordSocial = NewPasswordSocial.text;
        PlayerPrefs.SetString("socialpass", TempPasswordSocial);
        PlayerPrefs.Save();

        // a.Start()
        // print(TempPasswordSocial);
        // print(CheckPasswordSocial());

    }

    public void ChangePasswordEmail(){

        TempPassword = NewPasswordEmail.text;
        PlayerPrefs.SetString("emailpass", TempPassword);
        PlayerPrefs.Save();

        // a.Start()
        // print(TempPasswordSocial);
        // print(CheckPasswordSocial());

    }

    public void ChangePasswordBank(){

        TempPasswordBank = NewPasswordBank .text;
        PlayerPrefs.SetString("bankpass", TempPasswordBank);
        PlayerPrefs.Save();

        // a.Start()
        // print(TempPasswordBank);
        // print(CheckPasswordSocial());

    }


    public void CheckPasswordSocial(){


        string pass = PlayerPrefs.GetString("socialpass");
        // print("Change Pass:" + pass);
        bool result = Regex.IsMatch(pass, "^[a-zA-Z0-9]+$" );
        bool result1 = Regex.IsMatch(pass, "^[a-zA-Z]+$");
        bool result2 = Regex.IsMatch(pass, "^[0-9]+$");
        if(pass.Length == 0){
            ResSocial = "Ο κωδικός σας είναι πολύ αδυναμος, δεν μπορείτε να λύσετε το κουιζ";
            Max = -10;
        }
        else if(result1 && !result2){
            ResSocial = "Ο κωδικός σας είναι απλός. Μπορείτε να λύσετε το κουιζ αλλά με μέγιστη ανταμοιβή τις 2 σωστές απαντήσεις";
            Max = 2;
        }
        else if(result2 && !result1){
            ResSocial = "Ο κωδικός σας είναι απλός. Μπορείτε να λύσετε το κουιζ αλλά με μέγιστη ανταμοιβή τις 2 σωστές απαντήσεις";
            Max = 2;
        }
        else if(result){
            ResSocial = "Ο κωδικός σας είναι μέτριος. Μπορείτε να λύσετε το κουιζ με μέγιστη ανταμοιβή τις 3 σωστές απαντήσεις";
            Max = 3;
        }
        else {
            ResSocial = "Ο κωδικός σας είναι ισχυρός. Δεν χρειάζετα να λύσετε το κουιζ";
            Max = -1;
        }
        Social.text = ResSocial;
    }

    public static bool hasSpecialChar(string input){
        string specialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";
        foreach (var item in specialChar)
        {
            if (input.Contains(item)) return true;
        }

        return false;
    }


    public void CheckPasswordEmail(){
        string pass = PlayerPrefs.GetString("emailpass");
        string pass_social = PlayerPrefs.GetString("socialpass");
        // print("Change Pass:" + pass);
        int pass_length = pass.Length;
        bool same = (pass == pass_social);
        bool result = Regex.IsMatch(pass, "^[a-zA-Z0-9]+$" );
        bool result1 = Regex.IsMatch(pass, "^[a-zA-Z]+$");
        bool result2 = Regex.IsMatch(pass, "^[0-9]+$");
        bool result3 = Regex.IsMatch(pass, "^[a-zA-Z0-9!@#$&()\\-`.+,/\"]*$");


        if (same || pass_length < 8){
            ResSocial = "Ο κωδικός σας είναι πολύ αδυναμος, δεν μπορείτε να λύσετε το κουιζ";
            Max = -10;
        }
        else if((result1 && !result2 && pass_length >= 8) || (!result1 && result2 && pass_length >= 8)){
            ResSocial = "Ο κωδικός σας είναι απλός. Μπορείτε να λύσετε το κουιζ αλλά με μέγιστη ανταμοιβή τις 2 σωστές απαντήσεις";
            Max = 2;
        }
        else if(result && pass_length >= 8){
            ResSocial = "Ο κωδικός σας είναι μέτριος. Μπορείτε να λύσετε το κουιζ με μέγιστη ανταμοιβή τις 3 σωστές απαντήσεις";
            Max = 3;
        }
        else if(result3 && pass_length >= 8 && !same){
            ResSocial = "Ο κωδικός σας είναι ισχυρός. Δεν χρειάζετα να λύσετε το κουιζ";
            Max = -2;
        }
        else{
            ResSocial = "Συνέβη κάτι μη αναμενόμενο. Μπορείτε να λύσετε το κουιζ με μέγιστη ανταμοιβή τη 1 σωστή απάντηση";
            Max = 1;
        }

        EmailRes.text = ResSocial;
    }

    public void CheckPasswordBank(){
        string pass = PlayerPrefs.GetString("bankpass");
        string pass_email = PlayerPrefs.GetString("emailpass");
        string pass_social = PlayerPrefs.GetString("socialpass");
        // print("Change Pass:" + pass);
        int pass_length = pass.Length;
        bool same = (pass == pass_social);
        bool same1 = (pass == pass_email);
        bool result = Regex.IsMatch(pass, "^[a-zA-Z0-9]+$" );
        bool result1 = Regex.IsMatch(pass, "^[a-zA-Z]+$");
        bool result2 = Regex.IsMatch(pass, "^[0-9]+$");
        bool result3 = Regex.IsMatch(pass, "^[a-zA-Z0-9!@#$&()\\-`.+,/\"]*$");

        string last_char = pass.Substring(pass_length - 1);

        string rest = pass.Substring(0, (pass_length - 1));

        bool result4 = hasSpecialChar(last_char);
        bool result5 = Regex.IsMatch(rest, "^[a-zA-Z0-9]+$" );

        bool result6 = Regex.IsMatch(rest, "^[a-zA-Z0-9!@#$&()\\-`.+,/\"]*$");

        if (same || same1 || result || result1 || result2 || pass_length < 8){
            ResBank = "Ο κωδικός σας είναι πολύ αδυναμος, δεν μπορείτε να λύσετε το κουιζ";
            Max = -10;
        }
        else if(result4 && result5 && pass_length >= 8){
            ResBank = "Ο κωδικός σας είναι απλός. Μπορείτε να λύσετε το κουιζ αλλά με μέγιστη ανταμοιβή τις 2 σωστές απαντήσεις";
            Max = 2;
        }
        else if(result6 && pass_length >= 8){
            ResBank = "Ο κωδικός σας είναι μέτριος. Μπορείτε να λύσετε το κουιζ με μέγιστη ανταμοιβή τις 3 σωστές απαντήσεις";
            Max = 3;
        }
        // else if(result3 && pass_length >= 8 && !same){
        //     ResBank = "Ο κωδικός σας είναι ισχυρός. Δεν χρειάζετα να λύσετε το κουιζ";
        // }
        else{
            ResBank = "Συνέβη κάτι μη αναμενόμενο. Μπορείτε να λύσετε το κουιζ με μέγιστη ανταμοιβή τη 1 σωστή απάντηση";
            Max = 1;
        }

        BankRes.text = ResBank;
    }

}
