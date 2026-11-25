using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_045_JA_13 : CardInfo
{
    public CardInfo_045_JA_13()
    {
        this.cardNo = "045_JA_13";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ジーニー";
        this.cardName2 = "つかみどころのないやつ";
        this.power = 3;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.HedvigH_S;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
