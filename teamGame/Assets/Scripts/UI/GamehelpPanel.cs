using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GamehelpPanel : MonoBehaviour
{
    public Button m_Return; 
    
    void Start()
    {
        m_Return.onClick.AddListener(()=>{
            gameObject.SetActive(false);
        });
    } 
     
    void Update()
    {
        
    }
}
