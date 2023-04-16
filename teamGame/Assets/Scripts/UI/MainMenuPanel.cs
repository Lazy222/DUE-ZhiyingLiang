using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
// Main menu screen
public class MainMenuPanel : MonoBehaviour
{
    // Start the game
    public Button m_StartBtn;
    // Other scenarios

    public Button m_OtherScenesBtn;

    // Help
    public Button m_HelpBtan;
    
    // About
    public Button m_CreditsBtn; 

    // Other scene panels
    public GameObject m_OtherScenesPlane;

    // The help page
    public GameObject m_HelpPlane;

    // About the panel
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
