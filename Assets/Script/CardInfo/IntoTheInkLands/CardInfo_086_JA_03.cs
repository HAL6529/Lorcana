using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_086_JA_03 : CardInfo
{
    public CardInfo_086_JA_03()
    {
        this.cardNo = "086_JA_03";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "サー・ヒス";
        this.cardName2 = "いまいましいマムシ";
        this.power = 3;
        this.toughness = 1;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AlanBatson;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.RobinHood;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
