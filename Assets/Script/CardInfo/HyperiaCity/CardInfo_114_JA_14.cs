using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_114_JA_14 : CardInfo
{
    public CardInfo_114_JA_14()
    {
        this.cardNo = "114_JA_14";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ジャスパー";
        this.cardName2 = "スレスレのボート乗り";
        this.power = 5;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.KevinSidharta;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.OneHundredAndOneDalmatians;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
