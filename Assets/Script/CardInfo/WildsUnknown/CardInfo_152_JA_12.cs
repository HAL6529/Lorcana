using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_152_JA_12 : CardInfo
{
    public CardInfo_152_JA_12()
    {
        this.cardNo = "152_JA_12";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "サラ・ベラム博士";
        this.cardName2 = "研究主任";
        this.power = 3;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.ValentinaGraziusoAndGraceTran;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Inventor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.DarkwingDuck;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
