using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreditsPanel : MonoBehaviour
{
    public Button m_ReturnBtn;

    public GameObject MainMeuPlane;
    void Start()
    {
        m_ReturnBtn.onClick.AddListener(()=>{
            gameObject.SetActive(false);
            MainMeuPlane.SetActive(true);
        });
    }

  
}
