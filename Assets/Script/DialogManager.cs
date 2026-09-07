using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    public NewSaveDialog m_NewSaveDialog;

    public OKDialog m_OKDialog;

    public void AllClose()
    {
        m_NewSaveDialog.Close();
        m_OKDialog.Close();
        this.gameObject.SetActive(false);
    }

    public void NewSaveDialog_Open()
    {
        this.gameObject.SetActive(true);
        m_NewSaveDialog.Open();
    }

    public void OKDialog_Open(EnumController.OKBtnParamater paramater)
    {
        this.gameObject.SetActive(true);
        m_OKDialog.Open(paramater);
    }
}
