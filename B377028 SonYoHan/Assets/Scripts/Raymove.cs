using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raymove : MonoBehaviour
{

    float MoveSpeed;




    void Start()
    {
        MoveSpeed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            // 마우스 왼쪽 클릭시
            RaycastHit Hit;
            Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out Hit, Mathf.Infinity);
            Debug.Log(Input.mousePosition);
            Debug.Log(Hit.point);
            //마우스 포지션으로 빛을 쏴서 그 값을 hit 에 저장



            //hit 값을 Click 저장

            transform.Translate((Hit.point - transform.position).normalized * MoveSpeed * Time.deltaTime);



            // 클릭좌표로 이동

        }

    }
}
