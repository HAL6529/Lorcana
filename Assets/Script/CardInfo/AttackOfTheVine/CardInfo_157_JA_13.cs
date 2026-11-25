using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_157_JA_13 : CardInfo
{
    public CardInfo_157_JA_13()
    {
        this.cardNo = "157_JA_13";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "アントニオ・マドリガル";
        this.cardName2 = "どうぶつのおいしゃさん";
        this.power = 4;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MartaAndreeva;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Madrigal };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.Encanto;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
