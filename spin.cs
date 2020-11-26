using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    //Переменные с плавающей точкой, в которых хранятся начальные скорости вращения
    public float speedx = 1.0f;
    public float speedy = 2.0f;
    public float speedz = 3.0f;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(speedx, speedy, speedz);   //Функция вращение вокруг своей оси
    }
}
