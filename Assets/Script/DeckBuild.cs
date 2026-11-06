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
    //public EditCardPanelManager m_EditCardPanelManager;
    public SearchClass m_SearchClass;

    public RectTransform CanvasRectTransform;

    public RectTransform Parent;
    public RectTransform header_parent;
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

    private const int Parent_X = 890;
    private const int Parent_Y = 1920;
    private const int header_parent_X = 890;
    private const int header_parent_Y = 80;
    private const int ScrollView_Parent_X = 890;
    private const int ScrollView_Parent_Y = 1713;
    private const int bottom_X = 890;
    private const int bottom_Y = 127;
    private const int bottom_MenuBtn_X = 127;
    private const int bottom_MenuBtn_Y = 127;
    private const int Parent2_X = 890;
    private const int Parent2_Y = 1920;
    private const int header2_parent_X = 890;
    private const int header2_parent_Y = 80;
    private const int header2_sortBtn_X = 80;
    private const int header2_sortBtn_Y = 80;
    private const int header2_space1_X = 10;
    private const int header2_space1_Y = 80;
    private const int header2_switchDeckBtn_X = 80;
    private const int header2_switchDeckBtn_Y = 80;
    private const int header2_searchBtn_X = 80;
    private const int header2_searchBtn_Y = 80;
    private const int header2_Space_X = 890;
    private const int header2_Space_Y = 1840;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        float magnification_x = CanvasRectTransform.sizeDelta.x / 890;
        float magnification_y = CanvasRectTransform.sizeDelta.y / 1920;

        Parent.sizeDelta = new Vector2(Parent_X * magnification_x, Parent_Y * magnification_y);
        header_parent.sizeDelta = new Vector2(header_parent_X * magnification_x, header_parent_Y * magnification_y);
        ScrollView_Parent.sizeDelta = new Vector2(ScrollView_Parent_X * magnification_x, ScrollView_Parent_Y * magnification_y);
        bottom.sizeDelta = new Vector2(bottom_X * magnification_x, bottom_Y * magnification_y);
        Parent2.sizeDelta = new Vector2(Parent2_X * magnification_x, Parent2_Y * magnification_y);
        header2_parent.sizeDelta = new Vector2(header2_parent_X * magnification_x, header2_parent_Y * magnification_y);
        header2_space1.sizeDelta = new Vector2(header2_space1_X * magnification_x, header2_space1_Y * magnification_y);
        header2_Space.sizeDelta = new Vector2(header2_Space_X * magnification_x, header2_Space_Y * magnification_y);

        float magnification = magnification_x;
        if (magnification_x > magnification_y)
        {
            magnification = magnification_y;
        }
        bottom_MenuBtn.sizeDelta = new Vector2(bottom_MenuBtn_X * magnification, bottom_MenuBtn_Y * magnification);
        header2_sortBtn.sizeDelta = new Vector2(header2_sortBtn_X * magnification, header2_sortBtn_Y * magnification);
        header2_switchDeckBtn.sizeDelta = new Vector2(header2_switchDeckBtn_X * magnification, header2_switchDeckBtn_Y * magnification);
        header2_searchBtn.sizeDelta = new Vector2(header2_searchBtn_X * magnification, header2_searchBtn_Y * magnification);

        header2_space2.sizeDelta = new Vector2(header2_parent.sizeDelta.x - header2_sortBtn.sizeDelta.x - header2_space1.sizeDelta.x - header2_switchDeckBtn.sizeDelta.x - header2_searchBtn.sizeDelta.x, header2_space2.sizeDelta.y * magnification);

        header_parent.anchorMin = new Vector2(0, 1);
        header_parent.anchorMax = new Vector2(0, 1);
        header_parent.pivot = new Vector2(0, 1);
        header_parent.anchoredPosition = Vector2.zero;

        ScrollView_Parent.anchorMin = new Vector2(0, 1);
        ScrollView_Parent.anchorMax = new Vector2(0, 1);
        ScrollView_Parent.pivot = new Vector2(0, 1);
        ScrollView_Parent.anchoredPosition = new Vector2(0, header_parent.sizeDelta.y * (-1));

        bottom.anchorMin = new Vector2(0, 1);
        bottom.anchorMax = new Vector2(0, 1);
        bottom.pivot = new Vector2(0, 1);
        bottom.anchoredPosition = new Vector2(0, (header_parent.sizeDelta.y + ScrollView_Parent.sizeDelta.y) * (-1));

        bottom_MenuBtn.anchorMin = new Vector2(0, 1);
        bottom_MenuBtn.anchorMax = new Vector2(0, 1);
        bottom_MenuBtn.pivot = new Vector2(0, 1);
        bottom_MenuBtn.anchoredPosition = new Vector2((bottom.sizeDelta.x - bottom_MenuBtn.sizeDelta.x) / 2, 0);

        header2_parent.anchorMin = new Vector2(0, 1);
        header2_parent.anchorMax = new Vector2(0, 1);
        header2_parent.pivot = new Vector2(0, 1);
        header2_parent.anchoredPosition = Vector2.zero;

        header2_Space.anchorMin = new Vector2(0, 1);
        header2_Space.anchorMax = new Vector2(0, 1);
        header2_Space.pivot = new Vector2(0, 1);
        header2_Space.anchoredPosition = new Vector2(0, header2_parent.sizeDelta.y * (-1));

        float Header2_SizeDelta_X = 0;
        header2_sortBtn.anchorMin = new Vector2(0, 1);
        header2_sortBtn.anchorMax = new Vector2(0, 1);
        header2_sortBtn.pivot = new Vector2(0, 1);
        header2_sortBtn.anchoredPosition = Vector2.zero;

        Header2_SizeDelta_X += header2_sortBtn.sizeDelta.x;
        header2_space1.anchorMin = new Vector2(0, 1);
        header2_space1.anchorMax = new Vector2(0, 1);
        header2_space1.pivot = new Vector2(0, 1);
        header2_space1.anchoredPosition = new Vector2(Header2_SizeDelta_X, 0);

        Header2_SizeDelta_X += header2_space1.sizeDelta.x;
        header2_switchDeckBtn.anchorMin = new Vector2(0, 1);
        header2_switchDeckBtn.anchorMax = new Vector2(0, 1);
        header2_switchDeckBtn.pivot = new Vector2(0, 1);
        header2_switchDeckBtn.anchoredPosition = new Vector2(Header2_SizeDelta_X, 0);

        Header2_SizeDelta_X += header2_switchDeckBtn.sizeDelta.x;
        header2_space2.anchorMin = new Vector2(0, 1);
        header2_space2.anchorMax = new Vector2(0, 1);
        header2_space2.pivot = new Vector2(0, 1);
        header2_space2.anchoredPosition = new Vector2(Header2_SizeDelta_X, 0);

        Header2_SizeDelta_X += header2_space2.sizeDelta.x;
        header2_searchBtn.anchorMin = new Vector2(0, 1);
        header2_searchBtn.anchorMax = new Vector2(0, 1);
        header2_searchBtn.pivot = new Vector2(0, 1);
        header2_searchBtn.anchoredPosition = new Vector2(Header2_SizeDelta_X, 0);
        yield return null;

        m_PanelPicture.UpdateImage(magnification_x, magnification_y);
        yield return null;
        m_Menu.UpdateImage(magnification_x, magnification_y);
        yield return null;
        m_DialogManager.UpdateImage(magnification_x, magnification_y);
        yield return null;
        m_ViewMode.UpdateImage(magnification_x, magnification_y);
        yield return null;
        //m_EditCardPanelManager.UpdateImage(magnification_x, magnification_y);
        m_SearchClass.UpdateImage(magnification_x, magnification_y);
        yield return null;
    }
}
