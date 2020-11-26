using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    float SaveAlpha;
    public GameObject ChangingColor;
    public Color[] ColorInput = new Color[3];
    GameObject[] InputCapture = new GameObject[3];
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnPressButton()
    {
        SaveAlpha = gameObject.GetComponent<Renderer>().material.color.a;
        InputCapture[0] = GameObject.Find("InputFieldForFirstR");
        InputCapture[1] = GameObject.Find("InputFieldForFirstG");
        InputCapture[2] = GameObject.Find("InputFieldForFirstB");
        float.TryParse(InputCapture[0].GetComponent<InputField>().text, System.Globalization.NumberStyles.Any, new System.Globalization.CultureInfo("en-US"), out ColorInput[0].r);
        float.TryParse(InputCapture[1].GetComponent<InputField>().text, System.Globalization.NumberStyles.Any, new System.Globalization.CultureInfo("en-US"), out ColorInput[0].g);
        float.TryParse(InputCapture[2].GetComponent<InputField>().text, System.Globalization.NumberStyles.Any, new System.Globalization.CultureInfo("en-US"), out ColorInput[0].b);
        Color NewColor = new Vector4(ColorInput[0].r,ColorInput[0].g,ColorInput[0].b, SaveAlpha);
        gameObject.GetComponent<Renderer>().material.color = NewColor;
        Debug.Log("Button for central figure was pressed");
        Debug.Log(NewColor);
    }
}
