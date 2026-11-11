using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_112_JA_05 : CardInfo
{
    public CardInfo_112_JA_05()
    {
        this.cardNo = "112_JA_05";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ミッキーマウス";
        this.cardName2 = "熱烈なるダンサー";
        this.power = 2;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.RaquelVillanueva;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
