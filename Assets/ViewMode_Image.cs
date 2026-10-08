using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViewMode_Image : MonoBehaviour
{
    public Image m_Image;
    
    public void SetImage(Sprite paramater, bool isDisplay)
    {
        if(paramater == null && !isDisplay)
        {
            this.gameObject.SetActive(false);
            return;
        }
        m_Image.sprite = paramater;

        if(paramater == null)
        {
            m_Image.color = new Color(1, 1, 1, 0);
        }
        else 
        {
            m_Image.color = new Color(1, 1, 1, 1);
        }
        this.gameObject.SetActive(true);
    }
}
