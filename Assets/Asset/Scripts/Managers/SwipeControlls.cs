using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeControlls : MonoBehaviour
{
    Touch touch;

    Vector2 touchPosition;

    private Transform transformX;

    public float moveSpeed = 1.3f;



    private void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if(touch.phase == TouchPhase.Moved)
            {
                if(touch.deltaPosition.x > 0)
                {

                transform.localPosition -= new Vector3(moveSpeed * Time.deltaTime, 0, 0);
                }
                else
                {
                    transform.localPosition += new Vector3(moveSpeed * Time.deltaTime, 0, 0);

                Debug.Log("Hell yes");
                }
               
            }
        }
    }






}
