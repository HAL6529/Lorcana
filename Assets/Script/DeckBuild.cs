using System;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeckBuild : MonoBehaviour
{
    public PanelPicture m_PanelPicture;
    public Menu m_Menu;
    public DialogManager m_DialogManager;
    public ViewMode m_ViewMode;
    public EditCardPanelManager m_EditCardPanelManager;

    public RectTransform CanvasRectTransform;

    public RectTransform Parent;
    public RectTransform header_parent;
    public RectTransform header_sortBtn;
    public RectTransform header_space1;
    public RectTransform header_switchDeckBtn;
    public RectTransform header_space2;
    public RectTransform header_searchBtn;
    public RectTransform ScrollView_Parent;
    public RectTransform bottom;
    public RectTransform bottom_MenuBtn;
    public RectTransform Parent2;
    public RectTransform header2_parent;
    public RectTransform header2_sortBtn;
    public RectTransform header2_space1;
    public RectTransform header2_switchDeckBtn;
    public RectTransform header2_space2;
    public RectTransform header2_searchBtn;
    public RectTransform header2_Space;

    // Start is called before the first frame update
    void Start()
    {
        float magnification_x = CanvasRectTransform.sizeDelta.x / 890;
        float magnification_y = CanvasRectTransform.sizeDelta.y / 1920;

        Parent.sizeDelta = new Vector2(Parent.sizeDelta.x * magnification_x, Parent.sizeDelta.y * magnification_y);
        header_parent.sizeDelta = new Vector2(header_parent.sizeDelta.x * magnification_x, header_parent.sizeDelta.y * magnification_y);
        header_space1.sizeDelta = new Vector2(header_space1.sizeDelta.x * magnification_x, header_space1.sizeDelta.y * magnification_y);
        header_space2.sizeDelta = new Vector2(header_space2.sizeDelta.x * magnification_x, header_space2.sizeDelta.y * magnification_y);
        ScrollView_Parent.sizeDelta = new Vector2(ScrollView_Parent.sizeDelta.x * magnification_x, ScrollView_Parent.sizeDelta.y * magnification_y);
        bottom.sizeDelta = new Vector2(bottom.sizeDelta.x * magnification_x, bottom.sizeDelta.y * magnification_y);
        
        Parent2.sizeDelta = new Vector2(Parent2.sizeDelta.x * magnification_x, Parent2.sizeDelta.y * magnification_y);
        header2_parent.sizeDelta = new Vector2(header2_parent.sizeDelta.x * magnification_x, header2_parent.sizeDelta.y * magnification_y);
        header2_space1.sizeDelta = new Vector2(header2_space1.sizeDelta.x * magnification_x, header2_space1.sizeDelta.y * magnification_y);
        header2_Space.sizeDelta = new Vector2(header2_Space.sizeDelta.x * magnification_x, header2_Space.sizeDelta.y * magnification_y);

        float magnification = magnification_x;
        if (magnification_x > magnification_y)
        {
            magnification = magnification_y;
        }
        header_sortBtn.sizeDelta = new Vector2(header_sortBtn.sizeDelta.x * magnification, header_sortBtn.sizeDelta.y * magnification);
        header_switchDeckBtn.sizeDelta = new Vector2(header_switchDeckBtn.sizeDelta.x * magnification, header_switchDeckBtn.sizeDelta.y * magnification);
        header_searchBtn.sizeDelta = new Vector2(header_searchBtn.sizeDelta.x * magnification, header_searchBtn.sizeDelta.y * magnification);
        bottom_MenuBtn.sizeDelta = new Vector2(bottom_MenuBtn.sizeDelta.x * magnification, bottom_MenuBtn.sizeDelta.y * magnification);
        header2_sortBtn.sizeDelta = new Vector2(header2_sortBtn.sizeDelta.x * magnification, header2_sortBtn.sizeDelta.y * magnification);
        header2_switchDeckBtn.sizeDelta = new Vector2(header2_switchDeckBtn.sizeDelta.x * magnification, header2_switchDeckBtn.sizeDelta.y * magnification);
        header2_searchBtn.sizeDelta = new Vector2(header2_searchBtn.sizeDelta.x * magnification, header2_searchBtn.sizeDelta.y * magnification);

        header2_space2.sizeDelta = new Vector2(header2_parent.sizeDelta.x - header2_sortBtn.sizeDelta.x - header2_space1.sizeDelta.x - header2_switchDeckBtn.sizeDelta.x - header2_searchBtn.sizeDelta.x, header2_space2.sizeDelta.y * magnification);

        m_PanelPicture.UpdateImage(magnification_x, magnification_y);
        m_Menu.UpdateImage(magnification_x, magnification_y);
        m_DialogManager.UpdateImage(magnification_x, magnification_y);
        m_ViewMode.UpdateImage(magnification_x, magnification_y);
        m_EditCardPanelManager.UpdateImage(magnification_x, magnification_y);
    }
}
