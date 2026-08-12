using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardInfo : MonoBehaviour
{
    protected string cardNo;
    protected int inkCost;
    protected bool availableInk;
    public Sprite m_sprite;
    protected string cardName1;
    protected string cardName2;
    protected int power;
    protected int toughness;
    protected int lore;
    protected string illustrator;
    protected List<EnumController.Class> classList;
    protected List<EnumController.Colors> color;
    protected List<EnumController.KeywordAvility> keywordAvility;
    protected EnumController.Expansion expansion;
    protected EnumController.Title title;
    protected EnumController.Type type;
    protected EnumController.Rare rare;

    public string GetCardNo()
    {
        return cardNo;
    }

    public int GetInkCost()
    {
        return inkCost;
    }

    public bool GetAvailableInk()
    {
        return availableInk;
    }

    public Sprite GetSprite()
    {
        return m_sprite;
    }

    public string GetCardName1()
    { 
        return cardName1;
    }

    public string GetCardName2()
    {
        return cardName2;
    }

    public int GetPower()
    {
        return power;
    }

    public int GetToughness()
    {
        return toughness;
    }

    public int GetLore()
    {
        return lore;
    }

    public string GetIllustrator()
    {
        return illustrator;
    }

    public List<EnumController.Class> GetClassList()
    {
        return classList;
    }

    public List<EnumController.Colors> GetColor()
    {
        return color;
    }

    public List<EnumController.KeywordAvility> GetKeywordAvility()
    {
        return keywordAvility;
    }

    public EnumController.Expansion GetExpantion()
    {
        return expansion;
    }

    public EnumController.Title GetTitle()
    {
        return title;
    }

    public EnumController.Type GetType()
    {
        return type;
    }

    public EnumController.Rare GetRare()
    {
        return rare;
    }

    public void SetInkCost(int paramater)
    {
        inkCost = paramater;
    }

    public void SetAvailableInk(bool paramater)
    {
        availableInk = paramater;
    }

    public void SetSprite(Sprite paramater)
    {
        m_sprite = paramater;
    }

    public void SetCardName1(string paramater)
    {
        cardName1 = paramater;
    }

    public void SetCardName2(string paramater)
    {
        cardName2 = paramater;
    }

    public void SetPower(int paramater)
    {
        power = paramater;
    }

    public void SetToughness(int paramater)
    {
        toughness = paramater;
    }

    public void SetLore(int paramater)
    {
        lore = paramater;
    }

    public void SetIllustrator(string paramater)
    {
        illustrator = paramater;
    }

    public void SetClassList(List<EnumController.Class> paramater)
    {
        classList = paramater;
    }

    public void SetColor(List<EnumController.Colors> paramater)
    {
        color = paramater;
    }

    public void SetKeywordAvility(List<EnumController.KeywordAvility> paramater)
    {
        keywordAvility = paramater;
    }

    public void SetExpantion(EnumController.Expansion paramater)
    {
        expansion = paramater;
    }

    public void SetTitle(EnumController.Title paramater)
    {
        title = paramater;
    }

    public void SetType(EnumController.Type paramater)
    {
        type = paramater;
    }
}
