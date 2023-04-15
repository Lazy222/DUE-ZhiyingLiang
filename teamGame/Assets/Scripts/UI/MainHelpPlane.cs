using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MainHelpPlane : MonoBehaviour
{
    public Button m_ReturnBtn;

    public GameObject m_MainiMne;

    // Start is called before the first frame update
    void Start()
    {
        m_ReturnBtn.onClick.AddListener(()=>{
            m_MainiMne.SetActive(true);
            gameObject.SetActive(false);
        });
    }

    
}
