using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_044_JA_02 : CardInfo
{
    public CardInfo_044_JA_02()
    {
        this.cardNo = "044_JA_02";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ジミニー・クリケット";
        this.cardName2 = "ピノキオの良心";
        this.power = 1;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.IsaiahMesq;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Mentor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.Pinocchio;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
