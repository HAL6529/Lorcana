using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_124_JA_12 : CardInfo
{
    public CardInfo_124_JA_12()
    {
        this.cardNo = "124_JA_12";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ヴィニー・サントリーニ";
        this.cardName2 = "逃走中";
        this.power = 4;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.WouterBruneel;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.AtlantisTheLostEmpire;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
