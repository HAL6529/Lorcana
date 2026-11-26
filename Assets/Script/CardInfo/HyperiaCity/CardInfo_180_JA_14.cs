using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_180_JA_14 : CardInfo
{
    public CardInfo_180_JA_14()
    {
        this.cardNo = "180_JA_14";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ワイルドキャット";
        this.cardName2 = "型破りな整備士";
        this.power = 4;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.Greez;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally};
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.TaleSpin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
