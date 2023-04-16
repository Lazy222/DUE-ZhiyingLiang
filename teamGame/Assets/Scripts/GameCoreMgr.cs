using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCoreMgr : MonoBehaviour
{
    public PlayerState m_PlayerState;

    // Gold coin
    public int m_Gold; 

    // Victory screen
    public GameObject m_GameWinPlane;

    // Whether to clear the customs
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
