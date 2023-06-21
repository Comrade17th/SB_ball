using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstrucleMoving : MonoBehaviour
{
    // Start is called before the first frame update
    //Создаем переменную для точки назначения
    public Transform leftPoint;
    public Transform rightPoint;
    public float movingSpeed;
    Vector3 _targetPoint;

    //Создаем переменную для обозначения скорости движения
    float _speed;

    void Start()
    {
        _targetPoint = rightPoint.transform.position; // Указываешь нужные координаты
        
    }

    void FixedUpdate()
    {
        
        MoveObj(); // Вызываем метод для движения, вызов происходит каждый фрейм или что то вроде того
        if( gameObject.transform.position == leftPoint.position)
            _targetPoint = rightPoint.transform.position;
        if (gameObject.transform.position == rightPoint.position)
            _targetPoint = leftPoint.transform.position;
              

    }

    void MoveObj()
    {
        transform.position = Vector3.MoveTowards(transform.position, _targetPoint, movingSpeed*Time.deltaTime);
        //Двигаем объект с помощью метода MoveTowards, в скобках слева на право
        //1. Текущее положение, 2. Точка назначения, 3. скорость
    }
}
