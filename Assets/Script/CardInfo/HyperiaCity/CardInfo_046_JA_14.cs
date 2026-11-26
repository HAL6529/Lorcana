using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_046_JA_14 : CardInfo
{
    public CardInfo_046_JA_14()
    {
        this.cardNo = "046_JA_14";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "マダム・ミム";
        this.cardName2 = "光り物まっしぐら";
        this.power = 2;
        this.toughness = 1;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.LucaPinelli;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Villain, EnumController.Class.Sorcerer};
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.TheSwordInTheStone;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
