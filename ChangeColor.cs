using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColorFirst : MonoBehaviour
{
    public int flagNumber; //Целочисленная переменная для хранения номера флага
    float SaveAlpha;    //Переменная с плавающей точкой для хранения прозрачности фигуры
    public GameObject ChangingColor;    //Объектная переменная для изменения цвета фигуры
    public Color ColorInput;    //Цветовая переменная для того, чтобы забрать из соответсвующего поля для ввода
    GameObject[] InputCapture = new GameObject[3];  //Массив объектных переменных для обращения к полям ввода
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Функция, которая вызывается по нажатию кнопки применения
    public void OnPressButton()
    {
        //Сохраняется прозрачность фигуры
        SaveAlpha = gameObject.GetComponent<Renderer>().material.color.a;
        //Выбор по флагу номер фигуры
        switch(flagNumber)
        {
            case 1:
                //Нахождение объектов - полей для ввода, по названию
                InputCapture[0] = GameObject.Find("InputFieldForFirstR");
                InputCapture[1] = GameObject.Find("InputFieldForFirstG");
                InputCapture[2] = GameObject.Find("InputFieldForFirstB");
                //Взятие значения из поля для ввода и конвертирование его в float
                float.TryParse(InputCapture[0].GetComponent<InputField>().text, System.Globalization.NumberStyles.Any, new System.Globalization.CultureInfo("en-US"), out ColorInput.r);
                float.TryParse(InputCapture[1].GetComponent<InputField>().text, System.Globalization.NumberStyles.Any, new System.Globalization.CultureInfo("en-US"), out ColorInput.g);
                float.TryParse(InputCapture[2].GetComponent<InputField>().text, System.Globalization.NumberStyles.Any, new System.Globalization.CultureInfo("en-US"), out ColorInput.b);
                //Сохранение нового цвета по введённым значениям и сохраненной прозрачности
                Color NewColorFirst = new Vector4(ColorInput.r,ColorInput.g,ColorInput.b, SaveAlpha);
                //Применение нового цвета к фигуре
                gameObject.GetComponent<Renderer>().material.color = NewColorFirst;
                break;

            case 2:
                InputCapture[0] = GameObject.Find("InputFieldForSecondR");
                InputCapture[1] = GameObject.Find("InputFieldForSecondG");
                InputCapture[2] = GameObject.Find("InputFieldForSecondB");
                float.TryParse(InputCapture[0].GetComponent<InputField>().text, System.Globalization.NumberStyles.Any, new System.Globalization.CultureInfo("en-US"), out ColorInput.r);
                float.TryParse(InputCapture[1].GetComponent<InputField>().text, System.Globalization.NumberStyles.Any, new System.Globalization.CultureInfo("en-US"), out ColorInput.g);
                float.TryParse(InputCapture[2].GetComponent<InputField>().text, System.Globalization.NumberStyles.Any, new System.Globalization.CultureInfo("en-US"), out ColorInput.b);
                Color NewColorSecond = new Vector4(ColorInput.r, ColorInput.g, ColorInput.b, SaveAlpha);
                gameObject.GetComponent<Renderer>().material.color = NewColorSecond;
                break;

            case 3:
                InputCapture[0] = GameObject.Find("InputFieldForThirdR");
                InputCapture[1] = GameObject.Find("InputFieldForThirdG");
                InputCapture[2] = GameObject.Find("InputFieldForThirdB");
                float.TryParse(InputCapture[0].GetComponent<InputField>().text, System.Globalization.NumberStyles.Any, new System.Globalization.CultureInfo("en-US"), out ColorInput.r);
                float.TryParse(InputCapture[1].GetComponent<InputField>().text, System.Globalization.NumberStyles.Any, new System.Globalization.CultureInfo("en-US"), out ColorInput.g);
                float.TryParse(InputCapture[2].GetComponent<InputField>().text, System.Globalization.NumberStyles.Any, new System.Globalization.CultureInfo("en-US"), out ColorInput.b);
                Color NewColorThird = new Vector4(ColorInput.r, ColorInput.g, ColorInput.b, SaveAlpha);
                gameObject.GetComponent<Renderer>().material.color = NewColorThird;
                break;
        }
    }
}