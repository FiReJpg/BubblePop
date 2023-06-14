using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoppingControlls : MonoBehaviour
{
    public GameObject balloonPopSfx;
    public GameObject isTheCorrectOne;

    [HideInInspector]
    public bool canPlay;
    public bool isGuessRight;

    private void Start()
    {
        if (GameManager.Instance.isRestart)
        {
            canPlay = true;
        }
    }


    private void Update()
    {
        if (!canPlay)
            return;

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("yes");
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.collider.name);
                if (hit.collider.gameObject != null && hit.collider.tag == "Balloon")
                {
                    hit.collider.gameObject.transform.parent.gameObject.SetActive(false);
                    hit.collider.gameObject.transform.parent.gameObject.transform.parent.gameObject.transform.GetChild(1).gameObject.SetActive(true);
                    balloonPopSfx.SetActive(false);
                    balloonPopSfx.SetActive(true);

                    if (isTheCorrectOne != hit.collider.gameObject.transform.parent.gameObject.transform.parent.gameObject)
                    {
                        canPlay = false;
                        isGuessRight = false;
                        GameManager.Instance.isRestart = true;
                        UIManager.Instance.TurnWinLoseUION();
                    }
                    else
                    {
                        GameManager.Instance.isRestart = true;
                        isGuessRight = true;
                        UIManager.Instance.TurnWinLoseUION();

                    }

                }
            }
        }
    }

    public void Play()
    {
        canPlay = true;
    }


}
