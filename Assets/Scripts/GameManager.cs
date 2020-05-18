using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Cinemachine;

public class GameManager : MonoBehaviour
{
    // 게임오버 상태를 표현하고, 게임 점수와 UI를 관리하는 게임 매니저
    // 씬에는 단 하나의 게임 매니저만 존재할 수 있음
    public static GameManager instance; // 싱글턴을 할당할 전역 변수

    public bool isGameover = true; // 게임 중인지를 나타내는 변수

    public GameObject WelcomeUI; // 타이틀 UI
    public Item item;

    private Inventory inventory;

    [SerializeField] private UI_Inventory uiInventory;


    public CinemachineVirtualCamera[] views;




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
        WelcomeUI.SetActive(true);

        inventory = new Inventory();
        uiInventory.SetInventory(inventory);

        //ItemWorld.SpawnItemWorld(new Vector3(0.543f, 0.876f, 4f), new Item{itemType = Item.ItemType.Puzzle, amount = 1 });
    }

    public void OnGameStart()
    {
        isGameover = false;
        GameStart();
    }

    void GameStart()
    {
        WelcomeUI.SetActive(false);
    }

    public void GameClear()
    {
        Debug.Log("축하합니다. 게임을 클리어하셨습니다!");
    }

    public void ViewChange()
    {
        int length = views.Length;
        int currentView = 0;
        int nextView;

        for(int i = 0; i < length; i++)
        {
            if (views[i].Priority == 1)
            {
                currentView = i;
            }
        }

        nextView = currentView + 1;
        if(nextView == length)
        {
            nextView = 0;
        }

        for(int i = 0; i< length; i++)
        {
            if(i == nextView)
            {
                views[i].Priority = 1;
            }
            else
            {
                views[i].Priority = 0;
            }
        }
    }
}
