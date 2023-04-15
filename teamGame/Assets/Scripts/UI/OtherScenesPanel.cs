using System.Security.Cryptography.X509Certificates;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OtherScenesPanel : MonoBehaviour
{ 
    public Button m_CatBtn;

    public Button m_BearBtn;

    public Button m_TiggerBtn;

    public Button m_DeerBtn;

    public Button m_ReturnBtn;

    public GameObject m_MainMenuPlane;

    void Start()
    {
        m_CatBtn.onClick.AddListener(()=>{
            SceneManager.LoadScene("Game1");
        });

        m_BearBtn.onClick.AddListener(()=>{
             SceneManager.LoadScene("Game2");
        });

        m_TiggerBtn.onClick.AddListener(()=>{
             SceneManager.LoadScene("Game3");
        });

        m_DeerBtn.onClick.AddListener(()=>{
             SceneManager.LoadScene("Game4");
        }); 

        m_ReturnBtn.onClick.AddListener(()=>{
            gameObject.SetActive(false);
            m_MainMenuPlane.SetActive(true);
        });
    } 
     
     
}
