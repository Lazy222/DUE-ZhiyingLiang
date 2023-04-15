using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCoreMgr : MonoBehaviour
{
    public PlayerState m_PlayerState;

    //金币
    public int m_Gold; 

    //胜利界面
    public GameObject m_GameWinPlane;

    //是否通关
    public bool IsPassLevel()
    {
        if(m_PlayerState.m_CurGold>=m_Gold)
            return true;
        return false;
    }

    private void Update() {
        if(IsPassLevel())
        {
            Debug.Log("通关");
            m_GameWinPlane.SetActive(true);
        }
    }
}
