using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_107_JA_12 : CardInfo
{
    public CardInfo_107_JA_12()
    {
        this.cardNo = "107_JA_12";
        this.inkCost = 1;
        this.availableInk = false;
        this.cardName1 = "オードリー・ラミレズ";
        this.cardName2 = "きかん坊の機関士";
        this.power = 2;
        this.toughness = 1;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.OlgaAndriyenko;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Rush };
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.AtlantisTheLostEmpire;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
