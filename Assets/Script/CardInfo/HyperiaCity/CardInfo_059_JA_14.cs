using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_059_JA_14 : CardInfo
{
    public CardInfo_059_JA_14()
    {
        this.cardNo = "059_JA_14";
        this.inkCost = 8;
        this.availableInk = true;
        this.cardName1 = "マダム・ミム";
        this.cardName2 = "やりくり上手なトリックスター";
        this.power = 7;
        this.toughness = 5;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.MarcelBerg;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Villain, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.TheSwordInTheStone;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}
