using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    bool isDead;
    
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
        if (isDead){
            gameObject.SetActive(true);
        }
       
    }


}
