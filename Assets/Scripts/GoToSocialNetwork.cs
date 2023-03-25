using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToSocialNetwork : MonoBehaviour
{

    public GameObject oldbg;
    public GameObject newbg;

    // Start is called before the first frame update

    public void SocialNetwork(){
        oldbg.SetActive(false);
        newbg.SetActive(true);
    }
}
