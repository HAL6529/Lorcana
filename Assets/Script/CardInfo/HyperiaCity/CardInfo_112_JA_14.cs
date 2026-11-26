using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_112_JA_14 : CardInfo
{
    public CardInfo_112_JA_14()
    {
        this.cardNo = "112_JA_14";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "タダシ・ハマダ";
        this.cardName2 = "流れを届ける者";
        this.power = 4;
        this.toughness = 3;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.SimoneGiovanardi;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Mentor, EnumController.Class.Inventor  };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.BigHero6;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
