using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PopUp : MonoBehaviour
{
    
    public GameObject popup;
    public GameObject toHide;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Hide(){
        toHide.SetActive(false);
    }

    public void Show(){
        popup.SetActive(true);
    }
}
