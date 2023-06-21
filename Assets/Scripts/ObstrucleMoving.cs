using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstrucleMoving : MonoBehaviour
{
    // Start is called before the first frame update
    //������� ���������� ��� ����� ����������
    public Transform leftPoint;
    public Transform rightPoint;
    public float movingSpeed;
    Vector3 _targetPoint;

    //������� ���������� ��� ����������� �������� ��������
    float _speed;

    void Start()
    {
        _targetPoint = rightPoint.transform.position; // ���������� ������ ����������
        
    }

    void FixedUpdate()
    {
        
        MoveObj(); // �������� ����� ��� ��������, ����� ���������� ������ ����� ��� ��� �� ����� ����
        if( gameObject.transform.position == leftPoint.position)
            _targetPoint = rightPoint.transform.position;
        if (gameObject.transform.position == rightPoint.position)
            _targetPoint = leftPoint.transform.position;
              

    }

    void MoveObj()
    {
        transform.position = Vector3.MoveTowards(transform.position, _targetPoint, movingSpeed*Time.deltaTime);
        //������� ������ � ������� ������ MoveTowards, � ������� ����� �� �����
        //1. ������� ���������, 2. ����� ����������, 3. ��������
    }
}
