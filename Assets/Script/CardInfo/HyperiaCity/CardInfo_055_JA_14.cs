using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_055_JA_14 : CardInfo
{
    public CardInfo_055_JA_14()
    {
        this.cardNo = "055_JA_14";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ラプンツェル";
        this.cardName2 = "行動派アーティスト";
        this.power = 0;
        this.toughness = 1;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.FahedAlrajil;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.Tangled;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}
