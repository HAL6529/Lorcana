using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_056_JA_02 : CardInfo
{
    public CardInfo_056_JA_02()
    {
        this.cardNo = "056_JA_02";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "ピノキオ";
        this.cardName2 = "注目のスター";
        this.power = 1;
        this.toughness = 1;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.Kapik;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.Pinocchio;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
