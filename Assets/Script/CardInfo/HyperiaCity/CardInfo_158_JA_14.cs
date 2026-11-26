using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_158_JA_14 : CardInfo
{
    public CardInfo_158_JA_14()
    {
        this.cardNo = "158_JA_14";
        this.inkCost = 7;
        this.availableInk = true;
        this.cardName1 = "ベイマックス";
        this.cardName2 = "ハイボルテージ";
        this.power = 5;
        this.toughness = 8;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.GakuKumatori;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Super, EnumController.Class.Hero, EnumController.Class.Robot };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.ShiftRemove2InkDrops };
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.BigHero6;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}
