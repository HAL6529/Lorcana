using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    public NewSaveDialog m_NewSaveDialog;

    public OKDialog m_OKDialog;

    public RectTransform Parent;

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

    public void UpdateImage(float magnification_x, float magnification_y)
    {
        Parent.sizeDelta = new Vector2(Parent.sizeDelta.x * magnification_x, Parent.sizeDelta.y * magnification_y);
        m_NewSaveDialog.UpdateImage(magnification_x, magnification_y);
        m_OKDialog.UpdateImage(magnification_x, magnification_y);
    }
}
