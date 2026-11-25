using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_121_JA_13 : CardInfo
{
    public CardInfo_121_JA_13()
    {
        this.cardNo = "121_JA_13";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "キング・ルーイ";
        this.cardName2 = "スウィングの王様";
        this.power = 3;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.LaurenLevering;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.King };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Singer6 };
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.TheJungleBook;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
