using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//主菜单界面
public class MainMenuPanel : MonoBehaviour
{
    //开始游戏
    public Button m_StartBtn;
    //其他场景  

    public Button m_OtherScenesBtn;

    //帮助
    public Button m_HelpBtan;
    
    //关于
    public Button m_CreditsBtn; 

    //其他场景面板
    public GameObject m_OtherScenesPlane;

    //帮助界面
    public GameObject m_HelpPlane;

    //关于面板
    public GameObject m_CreditsPlane;

    void Start()
    {
        m_StartBtn.onClick.AddListener(()=>{
            SceneManager.LoadScene("Game1");
        });

        m_OtherScenesBtn.onClick.AddListener(()=>{
            m_OtherScenesPlane.SetActive(true);
            gameObject.SetActive(false);
        });

        m_HelpBtan.onClick.AddListener(()=>{
            gameObject.SetActive(false);
            m_HelpPlane.SetActive(true);

        });

        m_CreditsBtn.onClick.AddListener(()=>{
           m_CreditsPlane.SetActive(true);
            gameObject.SetActive(false);
        });
    }

    
}
