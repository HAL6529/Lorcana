using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViewMode_Image : MonoBehaviour
{
    public Image m_Image;
    public Image countImage;
    public Text m_Text;

    public void SetImage(Sprite paramater, int count)
    {
        if(paramater == null)
        {
            m_Image.color = new Color(1, 1, 1, 0);
            countImage.color = new Color(1, 1, 1, 0);
            m_Text.text = "";
            return;
        }
        m_Image.sprite = paramater;
        m_Image.color = new Color(1, 1, 1, 1);
        countImage.color = new Color(1, 1, 1, 1);
        m_Text.text = count.ToString();
    }
}
