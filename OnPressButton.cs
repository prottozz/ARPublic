using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnPressButton : MonoBehaviour
{
    public bool HideActive = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Logging(){
        Debug.Log("ButtonPressed");
    }
    public void Reveal(){  
        HideActive =  Hide(HideActive);
    }
    bool Hide(bool flag){
        if (flag)
        {
            gameObject.SetActive(false);
            return flag = false;
        }
        if (!flag)
        {
            gameObject.SetActive(true);
            return flag = true;
        }
        return flag;
    }
}
