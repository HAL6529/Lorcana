using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_038_JA_02 : CardInfo
{
    public CardInfo_038_JA_02()
    {
        this.cardNo = "038_JA_02";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ファシリエ";
        this.cardName2 = "抜け目ないペテン師";
        this.power = 4;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.LeonardoGiammichele;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.ThePrincessAndTheFrog;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
