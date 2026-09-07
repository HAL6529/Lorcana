using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OKDialog : MonoBehaviour
{
    public DialogManager m_DialogManager;

    public Text m_Text;

    public void Close()
    {
        this.gameObject.SetActive(false);
    }

    public void onCloseBtn()
    {
        m_DialogManager.AllClose();
    }

    public void onOKBtn()
    {
        m_DialogManager.AllClose();
    }

    public void Open(EnumController.OKBtnParamater paramater)
    {
        switch (paramater)
        {
            case EnumController.OKBtnParamater.NamelessError:
                m_Text.text = "ƒfƒbƒL–¼‚ð“ü—Í‚µ‚Ä‚­‚¾‚³‚¢";
                break;
            default:
                m_Text.text = "";
                break;
        }

        this.gameObject.SetActive(true);
    }
}
