using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_013_JA_07 : CardInfo
{
    public CardInfo_013_JA_07()
    {
        this.cardNo = "013_JA_07";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ミラベル・マドリガル";
        this.cardName2 = "希望の夢想家";
        this.power = 1;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.Koni;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Madrigal };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber, EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Evasive, EnumController.KeywordAvility.Singer5 };
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.Encanto;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
