using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // 게임오버 상태를 표현하고, 게임 점수와 UI를 관리하는 게임 매니저
    // 씬에는 단 하나의 게임 매니저만 존재할 수 있음
    public static GameManager instance; // 싱글턴을 할당할 전역 변수

    public bool isGameover = true; // 게임 중인지를 나타내는 변수

    public GameObject WelcomeUI; // 타이틀 UI
    public GameObject Level; // 레벨 구성

    public DoorController door;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Debug.Log("씬에 두개 이상의 게임매니저가 존재합니다.");
            Destroy(gameObject);
        }

        isGameover = true;
        Level.SetActive(false);
        WelcomeUI.SetActive(true);
    }

    public void OnGameStart()
    {
        isGameover = false;
        Level.SetActive(true);

        Invoke("GameStart", 2f);
    }

    void GameStart()
    {
        WelcomeUI.SetActive(false);
    }

    public void GameClear()
    {
        Debug.Log("축하합니다. 게임을 클리어하셨습니다!");
    }
}
