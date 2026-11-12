using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_058_JA_07 : CardInfo
{
    public CardInfo_058_JA_07()
    {
        this.cardNo = "058_JA_07";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "テ・カァ";
        this.cardName2 = "溶岩の魔物";
        this.power = 5;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MaxGrecke;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Deity };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Challenger2 };
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.Moana;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
