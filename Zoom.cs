using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Zoom : MonoBehaviour {
    public GameObject Self; //Объектная переменная для обращения к самой фигуре
    GameObject InputZoom; //Объектная переменная для того, чтобы забрать модификатор зума из поля для ввода
    Vector3 FirstScale; //Векторная переменная для хранения первоначального значения для сброса
    // Start is called before the first frame update
    void Start () {
        //Сохранение начального значения при старте
        FirstScale = Self.transform.localScale;
    }

    // Update is called once per frame
    void Update () {

    }
    //Функция, которая вызывается по нажатию кнопки применения
    public void OnButtonPressedZoom () {
        //Находим поле для ввода
        InputZoom = GameObject.Find ("InputFieldZoom");
        //Взятие значения из поля для ввода и конвертирование его в float
        float.TryParse (InputZoom.GetComponent<InputField> ().text, System.Globalization.NumberStyles.Any, new System.Globalization.CultureInfo ("en-US"), out float Mod);
        //Если объект активен, то изменить размер
        if ((Mod > 0) && (Self.activeSelf == true)) {
            Self.transform.localScale = FirstScale * Mod;
        }
    }
    //Функция, которая вызывается по нажатию кнопки сброса
    public void OnButtonPressedReset () {
        if (Self.activeSelf == true)
            Self.gameObject.transform.localScale = FirstScale;
    }
}