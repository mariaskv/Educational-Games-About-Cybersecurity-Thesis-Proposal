using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueUI : MonoBehaviour
{

    [SerializeField] private TMP_Text textLabel;
    
    // Start is called before the first frame update
    void Start()
    {
        textLabel.text = "Καλησπέρα, καλωσήρθατε στο παιχνίδι της κυβερνοασφάλειας, \n το όνομα μου είναι Στέλιος και είμαι εδώ για να σας καθοδηγήσω " ; 

        // sleep(1);

        // textLabel.text = "Καλησπέρα" ; 
    }

}
