using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_230_JA_13 : CardInfo
{
    public CardInfo_230_JA_13()
    {
        this.cardNo = "230_JA_13";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "マドリガル一家";
        this.cardName2 = "家族の年齢さまざま";
        this.power = 2;
        this.toughness = 8;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MaxineVee;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Team, EnumController.Class.Madrigal };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber, EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.MadrigalShift3 };
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.Encanto;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
