using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotationaround : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform rotateObj; //Объектная перменная для хранения ссылки на объект, который мы вращаем
    public Transform aroundObj; //Объектная перменная для хранения ссылки на объект, вокруг которого мы вращаем
    //Переменные с плавающей запятой для хранения начальных скоростей вращения
    public float rotSpeedx = 0f;
    public float rotSpeedy = 1f;
    public float rotSpeedz = 0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Функции вращения по различным осям
        rotateObj.RotateAround(aroundObj.position, new Vector3(1, 0, 0), rotSpeedx);
        rotateObj.RotateAround(aroundObj.position, new Vector3(0, 0, 1), rotSpeedy);
        rotateObj.RotateAround(aroundObj.position, new Vector3(1, 1, 1), rotSpeedz);
    }
}
