using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_016_JA_14 : CardInfo
{
    public CardInfo_016_JA_14()
    {
        this.cardNo = "016_JA_14";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "エリサ・マーザ";
        this.cardName2 = "仕事熱心な刑事";
        this.power = 3;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AnnaStosik;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Detective };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.Gargoyles;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
