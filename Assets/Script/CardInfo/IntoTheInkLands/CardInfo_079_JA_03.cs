using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_079_JA_03 : CardInfo
{
    public CardInfo_079_JA_03()
    {
        this.cardNo = "079_JA_03";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "マイロ・サッチ";
        this.cardName2 = "知的な地図製作者";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.GiuseppeDiMaio;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.AtlantisTheLostEmpire;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
