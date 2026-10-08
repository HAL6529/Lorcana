using System;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YesOrNoDialog : MonoBehaviour
{
    public RectTransform Parent;
    public RectTransform Parent_space;
    public RectTransform Parent_text;
    public RectTransform Parent_space2;
    public RectTransform Parent_buttons;
    public RectTransform Parent_buttons_space1;
    public RectTransform Parent_buttons_yes;
    public RectTransform Parent_buttons_space2;
    public RectTransform Parent_buttons_no;
    public RectTransform Parent_buttons_space3;
    public RectTransform Parent_space3;

    public Text m_Text;

    public DialogManager m_DialogManager;
    private EnumController.YesOrNoParamater Paramater;
    public EditCardPanelManager m_EditCardPanelManager;

    public void Close()
    {
        this.gameObject.SetActive(false);
    }

    public void Open(EnumController.YesOrNoParamater paramater)
    {
        Paramater = paramater;
        switch (Paramater)
        {
            case EnumController.YesOrNoParamater.ConfirmOverWrite:
                m_Text.text = "同じデッキ名のデータが既に存在しています。\r\n上書き保存しますか";
                break;
            case EnumController.YesOrNoParamater.ConfirmOverWrite_OverWriteBtn:
                if(m_EditCardPanelManager.DeckName == "")
                {
                    m_DialogManager.AllClose();
                    m_DialogManager.NewSaveDialog_Open();
                    return;
                }
                m_Text.text = "【" + m_EditCardPanelManager.DeckName + "】に\r\n上書き保存しますか";
                break;
            default:
                m_Text.text = "";
                break;
        }

        this.gameObject.SetActive(true);
    }

    public void onYesBtn()
    {
        switch (Paramater)
        {
            case EnumController.YesOrNoParamater.ConfirmOverWrite:
                m_EditCardPanelManager.DeckName = m_DialogManager.saveDeckName;
                m_DialogManager.AllClose();
                m_DialogManager.Save();
                break;
            case EnumController.YesOrNoParamater.ConfirmOverWrite_OverWriteBtn:
                m_DialogManager.AllClose();
                m_DialogManager.Save();
                break;
            default:
                break;
        }
    }

    public void onNoBtn()
    {
        m_DialogManager.AllClose();
    }

    public void UpdateImage(float magnification_x, float magnification_y)
    {
        Parent.sizeDelta = new Vector2(Parent.sizeDelta.x * magnification_x, Parent.sizeDelta.y * magnification_y);
        Parent_space.sizeDelta = new Vector2(Parent_space.sizeDelta.x * magnification_x, Parent_space.sizeDelta.y * magnification_y);
        Parent_text.sizeDelta = new Vector2(Parent_text.sizeDelta.x * magnification_x, Parent_text.sizeDelta.y * magnification_y);
        Parent_space2.sizeDelta = new Vector2(Parent_space2.sizeDelta.x * magnification_x, Parent_space2.sizeDelta.y * magnification_y);
        Parent_buttons.sizeDelta = new Vector2(Parent_buttons.sizeDelta.x * magnification_x, Parent_buttons.sizeDelta.y * magnification_y);
        Parent_buttons_space1.sizeDelta = new Vector2(Parent_buttons_space1.sizeDelta.x * magnification_x, Parent_buttons_space1.sizeDelta.y * magnification_y);
        Parent_buttons_yes.sizeDelta = new Vector2(Parent_buttons_yes.sizeDelta.x * magnification_x, Parent_buttons_yes.sizeDelta.y * magnification_y);
        Parent_buttons_space2.sizeDelta = new Vector2(Parent_buttons_space2.sizeDelta.x * magnification_x, Parent_buttons_space2.sizeDelta.y * magnification_y);
        Parent_buttons_no.sizeDelta = new Vector2(Parent_buttons_no.sizeDelta.x * magnification_x, Parent_buttons_no.sizeDelta.y * magnification_y);
        Parent_buttons_space3.sizeDelta = new Vector2(Parent_buttons_space3.sizeDelta.x * magnification_x, Parent_buttons_space3.sizeDelta.y * magnification_y);
        Parent_space3.sizeDelta = new Vector2(Parent_space3.sizeDelta.x * magnification_x, Parent_space3.sizeDelta.y * magnification_y);
    }
}
