using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZoomModifie : MonoBehaviour {
    // Start is called before the first frame update
    void Start () {

    }

    // Update is called once per frame
    void Update () {

    }
    //Функция, которая вызывается по нажатию кнопки увеличения значения модификатора масштабирвоания
    public void ButtonIncrease () {
        //Взятие значения из поля для ввода, конвертирование его в float и запись в новую переменную Mod
        float.TryParse (this.gameObject.GetComponent<InputField> ().text, System.Globalization.NumberStyles.Any, new System.Globalization.CultureInfo ("en-US"), out float Mod);
        //Увеличение значения переменной Mod на единицу
        Mod++;
        //Конвертирование значения переменной Mod в String и запись обратно в поле для ввода
        this.gameObject.GetComponent<InputField> ().text = Mod.ToString ();
    }

    //Функция, которая вызывается по нажатию кнопки уменьшения значения модификатора масштабирвоания
    public void ButtonDecrease () {
        //Взятие значения из поля для ввода, конвертирование его в float и запись в новую переменную Mod
        float.TryParse (this.gameObject.GetComponent<InputField> ().text, System.Globalization.NumberStyles.Any, new System.Globalization.CultureInfo ("en-US"), out float Mod);
        //Если значение переменной Mod больше 0, то уменьшение значения переменной Mod на единицу и конвертирование значения переменной Mod в String и запись обратно в поле для ввода
        if (Mod > 0) {
            Mod--;
            this.gameObject.GetComponent<InputField> ().text = Mod.ToString ();
        }
    }
}