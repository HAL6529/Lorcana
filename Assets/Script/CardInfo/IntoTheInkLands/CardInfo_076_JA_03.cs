using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_076_JA_03 : CardInfo
{
    public CardInfo_076_JA_03()
    {
        this.cardNo = "076_JA_03";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ジェットサム";
        this.cardName2 = "ごろつき";
        this.power = 2;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.BrianKesinger;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Ward };
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.TheLittleMermaid;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
