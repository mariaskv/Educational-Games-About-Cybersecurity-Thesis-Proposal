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
       textLabel.text = "Hello\n This is my second line"; 
    }

}
