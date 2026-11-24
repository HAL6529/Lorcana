using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_115_JA_12 : CardInfo
{
    public CardInfo_115_JA_12()
    {
        this.cardNo = "115_JA_12";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "デイジーダック";
        this.cardName2 = "トレンディーな旅人";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.ClioWolfensberger;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
