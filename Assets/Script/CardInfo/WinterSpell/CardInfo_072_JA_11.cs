using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_072_JA_11 : CardInfo
{
    public CardInfo_072_JA_11()
    {
        this.cardNo = "072_JA_11";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ミニーマウス";
        this.cardName2 = "くるくるスケーター";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.DomenicoRusso;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
