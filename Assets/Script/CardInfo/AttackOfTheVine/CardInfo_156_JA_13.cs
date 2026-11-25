using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_156_JA_13 : CardInfo
{
    public CardInfo_156_JA_13()
    {
        this.cardNo = "156_JA_13";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "ハデス";
        this.cardName2 = "緻密な策謀家";
        this.power = 5;
        this.toughness = 5;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.JulianDelRey;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Ward };
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
