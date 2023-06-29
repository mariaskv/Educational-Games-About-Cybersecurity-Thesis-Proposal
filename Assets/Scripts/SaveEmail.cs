using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using System.Text.RegularExpressions;
using TMPro;
using UnityEngine.UI;
using System;

public class SaveEmail : MonoBehaviour
{

    CoinsManager c;
    
    public CoinsManager coinsManager;

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

    public TMP_InputField Pin;
    string TempPin;

    public InputField NewPasswordSocial;
    public InputField NewPasswordEmail;
    public InputField NewPasswordBank;

    public GameObject popup;
    public GameObject popup1;
    public GameObject popup2;
    public GameObject popupWrongEmail;
    public GameObject popupWrongSocial;
    public GameObject popupWrongBank;
    public GameObject popupEmptyPin;
    public GameObject Box2;

    public string ResSocial;
    public string ResEmail;
    public string ResBank;
    public string ResPin;

    public TMP_Text Social;
    public TMP_Text EmailRes;
    public TMP_Text BankRes;
    public TMP_Text PinRes;

    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    
    public GameObject button4;
    public GameObject button5;
    public GameObject button6;

    public GameObject button7;
    public GameObject button8;
    public GameObject button9;

    public GameObject continueButton;
    public GameObject continueButton1;
    public GameObject continueButton2;


    // public PrintResults a;

    public void Update(){
        if(coinsManager.getCoins() <= 0){
            print("Game Over");
        }
    }

    public int Max;

    void Start(){
        c = GameObject.FindGameObjectWithTag("Coins").GetComponent<CoinsManager>();
    }

    public void UnderstandMistake(){
        button1.SetActive(false);
        button2.SetActive(false);
        button3.SetActive(false);

        if(Max > 0){
            Social.text = "Τέλεια. Χαίρομαι που κατάλαβες το λάθος σου ευτυχώς υπάρχει χρόνος να λύσεις ακόμα το κουιζ όμως η μέγιστη ανταμοιβή που μπορείς να πάρεις είναι στις 2 σωστές απαντήσεις.\nΤρέχα να προλάβεις.\n\n\n Και να θυμάσαι καλό είναι οι κωδικοί μας να έχουν τουλάχιστον 8-10 χαρακτήρες μέγεθος.";
        }
        else
            Social.text = "Τέλεια. Χαίρομαι που κατάλαβες το λάθος σου\nΔυστυχώς όμως δεν προλαβαίνεις να λύσεις το κουιζ, ο χάκερ έχει ήδη εισβάλει στον λογαριασμό σου. Τρέχα να τον προλάβεις πρωτού παραβιάσει το ηλεκτρονικό σου ταχυδρομείο.\n\n\n Και να θυμάσαι καλό είναι οι κωδικοί μας να έχουν τουλάχιστον 8-10 χαρακτήρες μέγεθος.";

        continueButton.SetActive(true);

    }

    public void DoesNotUnderstandMistake(){
        Social.text = "Έλα όυτε τώρα; Προσπάθησε ξανά! Θυμήσου τι περιείχε ο κωδικός σου!";
        Max = -1;
    }

    public void UnderstandMistake1(){
        button4.SetActive(false);
        button5.SetActive(false);
        button6.SetActive(false);

        if(Max > 0){
            EmailRes.text = "Τέλεια. Χαίρομαι που κατάλαβες το λάθος σου ευτυχώς υπάρχει χρόνος να λύσεις ακόμα το κουιζ όμως η μέγιστη ανταμοιβή που μπορείς να πάρεις είναι στις 2 σωστές απαντήσεις.\nΤρέχα να προλάβεις.\n\n\n Και να θυμάσαι καλό είναι οι κωδικοί μας να περιέχουν χαρακτήρες από όσο το δυνατόν περισσότερες κατηγορίες γίνεται καθώς και να έχουν μέγεθος τουλάχιστον 12 χαρακτήρες.";
        }
        else
            EmailRes.text = "Τέλεια. Χαίρομαι που κατάλαβες το λάθος σου\nΔυστυχώς όμως δεν προλαβαίνεις να λύσεις το κουιζ, ο χάκερ μπορεί να επιτεθεί εκ νέου από στιγμή σε στιγμή.\n\n\nΚαι να θυμάσαι καλό είναι οι κωδικοί μας να περιέχουν χαρακτήρες από όσο το δυνατόν περισσότερες κατηγορίες γίνεται και να έχουν μέγεθος τουλάχιστον 12 χαρακτήρες.";

        continueButton2.SetActive(true);

    }

    public void DoesNotUnderstandMistake1(){
        EmailRes.text = "Έλα όυτε τώρα; Προσπάθησε ξανά! Θυμήσου τι περιείχε ο κωδικός σου!";
        Max = -1;
    }

    public void UnderstandMistake2(){
        button7.SetActive(false);
        button8.SetActive(false);
        button9.SetActive(false);

        if(Max > 0){
            BankRes.text = "Τέλεια. Χαίρομαι που κατάλαβες το λάθος σου ευτυχώς υπάρχει χρόνος να λύσεις ακόμα το κουιζ όμως η μέγιστη ανταμοιβή που μπορείς να πάρεις είναι στις 2 σωστές απαντήσεις.\nΤρέχα να προλάβεις.";
        }
        else
            BankRes.text = "Τέλεια. Χαίρομαι που κατάλαβες το λάθος σου\nΔυστυχώς όμως δεν προλαβαίνεις να λύσεις το κουιζ, ο χάκερ μπορεί να επιτεθεί εκ νέου από στιγμή σε στιγμή.";

        continueButton1.SetActive(true);

    }

    public void DoesNotUnderstandMistake2(){
        BankRes.text = "Έλα όυτε τώρα; Προσπάθησε ξανά! Θυμήσου τι περιείχε ο κωδικός σου!";
        Max = -1;
    }

    public void SaveThis(){
        if(String.IsNullOrEmpty(Email.text) == true){
            popupWrongEmail.SetActive(true);
        }
        else if(String.IsNullOrEmpty(Password.text) == true){
            popupWrongEmail.SetActive(true);
        }
        else{
            TempEmail = Email.text;
            PlayerPrefs.SetString("tutorialTextKeyName", TempEmail);

            TempPassword = Password.text;
            PlayerPrefs.SetString("emailpass", TempPassword);
            popup.SetActive(true);
        }
    }

    public void SaveSocial(){
        if(String.IsNullOrEmpty(EmailSocial.text) == true){
            popupWrongSocial.SetActive(true);
        }
        else if(String.IsNullOrEmpty(PasswordSocial.text) == true){
            popupWrongSocial.SetActive(true);
        }
        else{
            TempEmailSocial = EmailSocial.text;
            PlayerPrefs.SetString("socialemail", TempEmailSocial);

            TempPasswordSocial = PasswordSocial.text;
            PlayerPrefs.SetString("socialpass", TempPasswordSocial);
            PlayerPrefs.Save();
            popup1.SetActive(true);
        }

    }

    public void SaveBank(){
        if(String.IsNullOrEmpty(EmailBank.text) == true){
            popupWrongBank.SetActive(true);
        }
        else if(String.IsNullOrEmpty(PasswordBank.text) == true){
            popupWrongBank.SetActive(true);
        }
        else{
            TempEmailBank = EmailBank.text;
            PlayerPrefs.SetString("tutorialTextKeyName", TempEmailBank);

            TempPasswordBank = PasswordBank.text;
            PlayerPrefs.SetString("bankpass", TempPasswordBank);
            popup2.SetActive(true);
        }
    }

    public void SavePin(){
        string pass = Pin.text;
        bool flag = Regex.IsMatch(pass, "^[0-9]+$");
        if(String.IsNullOrEmpty(Pin.text) == true){
            popupEmptyPin.SetActive(true);
        }
        else if(!flag){
            popupEmptyPin.SetActive(true);
        }
        else{
            TempPin = Pin.text;
            PlayerPrefs.SetString("pin", TempPin);
            CheckPin();
        }
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

    public void CheckPin(){
        string pass = PlayerPrefs.GetString("pin");
        bool result = (pass.Length < 4);

        string theYear = System.DateTime.UtcNow.ToLocalTime().ToString("yyyy");
        bool result1 = (pass == theYear);

        // int pass_int = int.Parse(pass);

        List<int> digits = new List<int>();
        for(int i = 0; i < pass.Length; i++){
            digits.Add(int.Parse(Char.ToString(pass[i])));
        }

        bool follow = true;
        int before = digits[0];
        for(int i = 1; i < pass.Length; i++){
            int current = digits[i];
            if(current != before + 1){
                follow = false;
                break;
            }
            before = current;
        }

        bool follow1 = true;
        before = digits[0];
        for(int i = 1; i < pass.Length; i++){
            int current = digits[i];
            if(current != before - 1){
                follow1 = false;
                break;
            }
            before = current;
        }

        if(result){
            ResPin = "Το pin σας είναι πολύ μικρό σε μέγεθος και όχι αρκετά ασφαλές. Δεν μπορείτε να λάβετε την επιδότηση και πληρώνετε ένα παράβολο αξίας 20ε.";
            coinsManager.lose20();
        }
        else if(result1){
            ResPin = "Το pin σας είναι το τρέχον έτος και αυτό το καθιστά μη ασφαλές. Δεν μπορείτε να λάβετε την επιδότηση και πληρώνετε ένα παράβολο αξίας 20ε.";
            coinsManager.lose20();
        }
        else if(follow || follow1){
            ResPin = "Το pin σας αποτελείται από διαδοχικά ψηφία και αυτό το καθιστά μη ασφαλές. Δεν μπορείτε να λάβετε την επιδότηση και πληρώνετε ένα παράβολο αξίας 20ε.";
            coinsManager.lose20();
        }
        else{
            ResPin = "Το pin σας είναι ασφαλές. Λαμβάνετε την επιδότηση για την προστασία των ψηφιακών μέσων και επιπλέον κερδίζετε 15 νομίσματα.";
            coinsManager.win15();
        }
        PinRes.text = ResPin;
        Box2.SetActive(true);
    }


    public void CheckPasswordSocial(){


        string pass = PlayerPrefs.GetString("socialpass");
        // print("Change Pass:" + pass);
        bool result = Regex.IsMatch(pass, "^[a-zA-Z0-9]+$" );
        bool result1 = Regex.IsMatch(pass, "^[a-zA-Z]+$");
        bool result2 = Regex.IsMatch(pass, "^[0-9]+$");
        if(pass.Length == 0){
            Max = -10;
            ResSocial = "Δυστυχώς ο κωδικός σου είναι πολύ απλός. \n Μπορείς μήπως να σκεφτείς γιατί;";
            button1.SetActive(true);
            button2.SetActive(true);
            button3.SetActive(true);

        }
        else if(result1 && !result2){
            ResSocial = "Δυστυχώς ο κωδικός σου είναι πολύ απλός. \n Μπορείς μήπως να σκεφτείς γιατί;";
            Max = 2;
            button1.SetActive(true);
            button2.SetActive(true);
            button3.SetActive(true);

        }
        else if(result2 && !result1){
            ResSocial = "Δυστυχώς ο κωδικός σου είναι πολύ απλός. \n Μπορείς μήπως να σκεφτείς γιατί;";
            button1.SetActive(true);
            button2.SetActive(true);
            button3.SetActive(true);
            Max = 2;
        }
        else if(result){
            ResSocial = "Ο κωδικός σας είναι μέτριος. Μπορείτε να λύσετε το κουιζ με μέγιστη ανταμοιβή τις 3 σωστές απαντήσεις. Μπορείς να σκεφτείς τι θα έπρεπε ακόμα να βελτιωθεί προκειμένου να γίνει πλήρως ισχυρός;";
            continueButton.SetActive(true);
            Max = 3;
        }
        else {
            ResSocial = "Ο κωδικός σου είναι ισχυρός καθότι περιέχει τόσο γράμματα του λατινικού αλφαβήτου, όσο ψηφία και ειδικούς χαρακτήρες. Δεν χρειάζεται να λύσεις το κουιζ. Ωστόσο να θυμάσαι πως οι κωδικοί μας είναι καλό να έχουν τουλάχιστον 8 χαρακτήρες μέγεθος.";
            continueButton.SetActive(true);
            Max = -2;
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
        bool result4 = Regex.IsMatch(pass, "^[!@#$&()\\-`.+,/\"]*$");
        bool result5 = Regex.IsMatch(pass, "^[0-9!@#$&()\\-`.+,/\"]*$");
        bool result6 = Regex.IsMatch(pass, "^[a-zA-Z!@#$&()\\-`.+,/\"]*$");

        if (same || pass_length < 8){
            ResSocial = "Δυστυχώς ο κωδικός σου είναι πολύ αδύναμος. \nΜπορείς μήπως να σκεφτείς γιατί;";
            button4.SetActive(true);
            button5.SetActive(true);
            button6.SetActive(true);
            Max = -10;
        }
        else if((result1 && !result2 && !result4 && pass_length >= 8) || (!result1 && result2 && !result4 && pass_length >= 8) || (!result1 && !result2 && result4 && pass_length >= 8)){
            ResSocial = "Ο κωδικός σου είναι απλός. \nΜπορείς μήπως να σκεφτείς γιατί;";
            button4.SetActive(true);
            button5.SetActive(true);
            button6.SetActive(true);
            Max = 2;
        }
        else if((result && !result1 && !result2 && pass_length >= 8) || (result5 && !result4 && !result2 && pass_length >= 8) || (result6 && !result4 && !result1 && pass_length >= 8)){
            ResSocial = "Ο κωδικός σου είναι μέτριος. Αυτό σημαίνει πως μπορείς να λύσεις το κουιζ με μέγιστη ανταμοιβή στις 3 σωστές απαντήσεις.\nΓια να τον κάνεις πιο δυνατό θα μπορούσες να χρησιμοποιήσεις και κάποιον ειδικό χαρακτήρα.";
            Max = 3;
            continueButton2.SetActive(true);
        }
        else if(result3 && pass_length >= 8 && !same){
            ResSocial = "Ο κωδικός σου είναι ισχυρός. Δεν χρειάζεται να λύσεις το κουιζ";
            Max = -2;
            continueButton2.SetActive(true);
        }
        else{
            ResSocial = "Συνέβη κάτι μη αναμενόμενο. Μπορείς να λύσεις το κουιζ με μέγιστη ανταμοιβή τη 1 σωστή απάντηση";
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
        bool result10 = Regex.IsMatch(pass, "^[a-z]+$");
        bool result11 = Regex.IsMatch(pass, "^[A-Z]+$");
        bool result2 = Regex.IsMatch(pass, "^[0-9]+$");
        bool result3 = Regex.IsMatch(pass, "^[a-zA-Z0-9!@#$&()\\-`.+,/\"]*$");

        bool result7 = Regex.IsMatch(pass, "^[0-9!@#$&()\\-`.+,/\"]*$");
        bool result8 = Regex.IsMatch(pass, "^[a-zA-Z!@#$&()\\-`.+,/\"]*$");

        string last_char = pass.Substring(pass_length - 1);

        string rest = pass.Substring(0, (pass_length - 1));

        bool result4 = hasSpecialChar(last_char);
        bool result5 = Regex.IsMatch(rest, "^[a-zA-Z0-9]+$" );

        bool result6 = Regex.IsMatch(rest, "^[a-zA-Z0-9!@#$&()\\-`.+,/\"]*$");

        if (same || same1 || result || result1 || result2 || pass_length < 12){
            
            button7.SetActive(true);
            button8.SetActive(true);
            button9.SetActive(true);

            ResBank = "Ο κωδικός σου είναι πολύ αδυναμος.\nΜπορείς μήπως να σκεφτείς γιατί;";
            Max = -10;
        }
        else if((result7 || result8) && pass_length >= 12){

            button7.SetActive(true);
            button8.SetActive(true);
            button9.SetActive(true);

            ResBank = "Ο κωδικός σου είναι απλός.\nΜπορείς μήπως να σκεφτείς γιατί;";
            Max = 2;
        }
        else if(result3 && pass_length >= 12 && pass_length <= 16){
            ResBank = "Ο κωδικός σου είναι μέτριος. Μπορείς να λύσεις το κουιζ με μέγιστη ανταμοιβή τις 3 σωστές απαντήσεις";
            Max = 3;
            continueButton1.SetActive(true);
        }
        else if(result3 && pass_length > 17){
            ResBank = "Ο κωδικός σου είναι ισχυρός. Δεν χρειάζεται να λύσεις το κουιζ";
            Max = -2;
            continueButton1.SetActive(true);
        }
        else{
            ResBank = "Συνέβη κάτι μη αναμενόμενο. Μπορείς να λύσεις το κουιζ με μέγιστη ανταμοιβή τη 1 σωστή απάντηση";
            Max = 1;
            continueButton1.SetActive(true);
        }

        BankRes.text = ResBank;
    }

}
