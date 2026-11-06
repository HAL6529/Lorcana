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

    private const int Parent_X = 890;
    private const int Parent_Y = 1920;
    private const int Btn_X = 890;
    private const int Btn_Y = 70;
    private const int space_X = 890;
    private const int space_Y = 100;

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
        Parent.sizeDelta = new Vector2(Parent_X * magnification_x, Parent_Y * magnification_y);
        CloseBtn.sizeDelta = new Vector2(Btn_X * magnification_x, Btn_Y * magnification_y);
        NewSaveBtn.sizeDelta = new Vector2(Btn_X * magnification_x, Btn_Y * magnification_y);
        SaveBtn.sizeDelta = new Vector2(Btn_X * magnification_x, Btn_Y * magnification_y);
        DisplayBtn.sizeDelta = new Vector2(Btn_X * magnification_x, Btn_Y * magnification_y);
        space.sizeDelta = new Vector2(space_X * magnification_x, space_Y * magnification_y);
        MenuBtn.sizeDelta = new Vector2(Btn_X * magnification_x, Btn_Y * magnification_y);

        Vector2 left_position = new Vector2(0, 1);
        float Menu_Y = 0;
        CloseBtn.anchorMin = left_position;
        CloseBtn.anchorMax = left_position;
        CloseBtn.pivot = left_position;
        CloseBtn.anchoredPosition = Vector2.zero;

        Menu_Y += CloseBtn.sizeDelta.y + 10;
        NewSaveBtn.anchorMin = left_position;
        NewSaveBtn.anchorMax = left_position;
        NewSaveBtn.pivot = left_position;
        NewSaveBtn.anchoredPosition = new Vector2(0, Menu_Y * (-1));

        Menu_Y += NewSaveBtn.sizeDelta.y + 10;
        SaveBtn.anchorMin = left_position;
        SaveBtn.anchorMax = left_position;
        SaveBtn.pivot = left_position;
        SaveBtn.anchoredPosition = new Vector2(0, Menu_Y * (-1));

        Menu_Y += SaveBtn.sizeDelta.y + 10;
        DisplayBtn.anchorMin = left_position;
        DisplayBtn.anchorMax = left_position;
        DisplayBtn.pivot = left_position;
        DisplayBtn.anchoredPosition = new Vector2(0, Menu_Y * (-1));

        Menu_Y += DisplayBtn.sizeDelta.y + 10;
        space.anchorMin = left_position;
        space.anchorMax = left_position;
        space.pivot = left_position;
        space.anchoredPosition = new Vector2(0, Menu_Y * (-1));

        Menu_Y += space.sizeDelta.y + 10;
        MenuBtn.anchorMin = left_position;
        MenuBtn.anchorMax = left_position;
        MenuBtn.pivot = left_position;
        MenuBtn.anchoredPosition = new Vector2(0, Menu_Y * (-1));
    }
}
