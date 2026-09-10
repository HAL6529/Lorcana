using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu_SelectDeckPanel : MonoBehaviour
{
    public Text m_Text;

    public void SetText(string s)
    {
        if(s == "")
        {
            m_Text.text = "";
            this.gameObject.SetActive(false);
        }
        else
        {
            m_Text.text = s;
            this.gameObject.SetActive(true);
        }
    }
}
