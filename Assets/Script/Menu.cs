using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public ViewMode m_ViewMode;

    public DialogManager m_DialogManager;

    private ExtendUtil m_ExtendUtil = new ExtendUtil();

    public RectTransform Parent;
    public RectTransform CloseBtn;
    public RectTransform NewSaveBtn;
    public RectTransform SaveBtn;
    public RectTransform DisplayBtn;
    public RectTransform space;
    public RectTransform MenuBtn;

    public void onCloseBtn()
    {
        this.gameObject.SetActive(false);
    }

    public void onDisplayBtn()
    {
        m_ViewMode.Open();
        this.gameObject.SetActive(false);
    }

    public void onMenuBtn()
    {
        SceneManager.LoadScene("Menu");
    }

    public void onNewSave()
    {
        m_DialogManager.NewSaveDialog_Open();
    }

    public void onAddSave()
    {
        m_DialogManager.YesOrNoDialog_Open(EnumController.YesOrNoParamater.ConfirmOverWrite_OverWriteBtn);
    }

    private void onSave()
    {

    }

    public void UpdateImage(float magnification_x, float magnification_y)
    {
        Parent.sizeDelta = new Vector2(Parent.sizeDelta.x * magnification_x, Parent.sizeDelta.y * magnification_y);
        CloseBtn.sizeDelta = new Vector2(CloseBtn.sizeDelta.x * magnification_x, CloseBtn.sizeDelta.y * magnification_y);
        NewSaveBtn.sizeDelta = new Vector2(NewSaveBtn.sizeDelta.x * magnification_x, NewSaveBtn.sizeDelta.y * magnification_y);
        SaveBtn.sizeDelta = new Vector2(SaveBtn.sizeDelta.x * magnification_x, SaveBtn.sizeDelta.y * magnification_y);
        DisplayBtn.sizeDelta = new Vector2(DisplayBtn.sizeDelta.x * magnification_x, DisplayBtn.sizeDelta.y * magnification_y);
        space.sizeDelta = new Vector2(space.sizeDelta.x * magnification_x, space.sizeDelta.y * magnification_y);
        MenuBtn.sizeDelta = new Vector2(MenuBtn.sizeDelta.x * magnification_x, MenuBtn.sizeDelta.y * magnification_y);

        float Menu_Y = 0;
        CloseBtn.anchorMin = new Vector2(0, 1);
        CloseBtn.anchorMax = new Vector2(0, 1);
        CloseBtn.pivot = new Vector2(0, 1);
        CloseBtn.anchoredPosition = Vector2.zero;

        Menu_Y += CloseBtn.sizeDelta.y + 10;
        NewSaveBtn.anchorMin = new Vector2(0, 1);
        NewSaveBtn.anchorMax = new Vector2(0, 1);
        NewSaveBtn.pivot = new Vector2(0, 1);
        NewSaveBtn.anchoredPosition = new Vector2(0, Menu_Y * (-1));

        Menu_Y += NewSaveBtn.sizeDelta.y + 10;
        SaveBtn.anchorMin = new Vector2(0, 1);
        SaveBtn.anchorMax = new Vector2(0, 1);
        SaveBtn.pivot = new Vector2(0, 1);
        SaveBtn.anchoredPosition = new Vector2(0, Menu_Y * (-1));

        Menu_Y += SaveBtn.sizeDelta.y + 10;
        DisplayBtn.anchorMin = new Vector2(0, 1);
        DisplayBtn.anchorMax = new Vector2(0, 1);
        DisplayBtn.pivot = new Vector2(0, 1);
        DisplayBtn.anchoredPosition = new Vector2(0, Menu_Y * (-1));

        Menu_Y += DisplayBtn.sizeDelta.y + 10;
        space.anchorMin = new Vector2(0, 1);
        space.anchorMax = new Vector2(0, 1);
        space.pivot = new Vector2(0, 1);
        space.anchoredPosition = new Vector2(0, Menu_Y * (-1));

        Menu_Y += space.sizeDelta.y + 10;
        MenuBtn.anchorMin = new Vector2(0, 1);
        MenuBtn.anchorMax = new Vector2(0, 1);
        MenuBtn.pivot = new Vector2(0, 1);
        MenuBtn.anchoredPosition = new Vector2(0, Menu_Y * (-1));
    }
}
