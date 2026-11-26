using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_078_JA_14 : CardInfo
{
    public CardInfo_078_JA_14()
    {
        this.cardNo = "078_JA_14";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ジョック";
        this.cardName2 = "景色にご満悦";
        this.power = 4;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.LaurenBarger;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.LadyAndTheTramp;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
