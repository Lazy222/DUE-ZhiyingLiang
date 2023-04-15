using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameWinPanel : MonoBehaviour
{
    public Button m_NextLevelBtn;

    public string NextLevelName;
    void Start()
    {
        m_NextLevelBtn.onClick.AddListener(()=>{
            SceneManager.LoadScene(NextLevelName);
        });
    }

   
}
