using System.Net.Http.Headers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameViewPanel : MonoBehaviour
{   
    public GameCoreMgr m_GameCoreMgr;
    public PlayerState m_Playerstate;

    public Button m_HelpBtn;
    public GameObject m_HelpPlane;

    public Text m_RequirText;

    //Next Close Button
    public Button m_NextBtn;

    //Previous close button
    public Button m_LastBtn;

    //Next level name
    public string m_LastName;
    //Last level name
    public string m_NextName;

    //Home Menu
    public Button m_MainBtn;

    void Start()
    {
        m_HelpBtn.onClick.AddListener(()=>{
            m_HelpPlane.SetActive(true);
        }) ;  

        m_NextBtn.onClick.AddListener(()=>{
              SceneManager.LoadScene(m_NextName);
        });

        m_LastBtn.onClick.AddListener(()=>{ 
            SceneManager.LoadScene(m_LastName);
        });

        m_MainBtn.onClick.AddListener(()=>{
            SceneManager.LoadScene("Menu");
        });
    }

   
    void Update()
    {
        m_RequirText.text = m_Playerstate.m_CurGold + "/" + m_GameCoreMgr.m_Gold;
    }
}
