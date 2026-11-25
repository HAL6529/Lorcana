using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_160_JA_13 : CardInfo
{
    public CardInfo_160_JA_13()
    {
        this.cardNo = "160_JA_13";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ブー";
        this.cardName2 = "人間の子ども";
        this.power = 0;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.EriWelli;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.MonstersInc;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
