using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_146_JA_14 : CardInfo
{
    public CardInfo_146_JA_14()
    {
        this.cardNo = "146_JA_14";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "マダム・ミム";
        this.cardName2 = "鼻を突っ込むお隣";
        this.power = 5;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.Gwawi;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.TheSwordInTheStone;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
