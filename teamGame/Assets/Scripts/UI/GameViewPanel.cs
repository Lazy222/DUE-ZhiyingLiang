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

    //下一关卡按钮
    public Button m_NextBtn;

    //上一关卡按钮
    public Button m_LastBtn;

    //下一关卡名字
    public string m_LastName;
    //上一关卡名字
    public string m_NextName;

    //主菜单页面
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
