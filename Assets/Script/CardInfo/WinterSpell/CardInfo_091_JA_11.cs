using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_091_JA_11 : CardInfo
{
    public CardInfo_091_JA_11()
    {
        this.cardNo = "091_JA_11";
        this.inkCost = 6;
        this.availableInk = false;
        this.cardName1 = "ミッキーマウス";
        this.cardName2 = "一流スノーボーダー";
        this.power = 4;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.FedericoMariaCugliari;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
