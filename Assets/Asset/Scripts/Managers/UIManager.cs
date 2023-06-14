using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    [SerializeField]
    PoppingControlls popControll;


    public GameObject MainMenuUI;
    public GameObject LoseScreen;
    public GameObject WinScreen;


    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        
    }

    private void Start()
    {
        if (GameManager.Instance.isRestart)
        {
            MainMenuUI.SetActive(false);
        }
    }

    public void Play()
    {
        popControll.canPlay = true;
    }

    public void TurnWinLoseUION()
    {
        if (popControll.isGuessRight)
        {
            Debug.Log("Right guess");
            WinScreen.SetActive(true);
        }
        else
        {
            Debug.Log("Ops Try again");
            LoseScreen.SetActive(true);

        }
    }

    public void TryAgain()
    {
        SceneManager.LoadScene(0);
    }


}
