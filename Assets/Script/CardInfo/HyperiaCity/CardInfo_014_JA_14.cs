using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_014_JA_14 : CardInfo
{
    public CardInfo_014_JA_14()
    {
        this.cardNo = "014_JA_14";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "ニック・ワイルド";
        this.cardName2 = "おもちゃの寄付の受付担当";
        this.power = 2;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.SimoneGiovanardi;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Ally, EnumController.Class.Detective };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Support };
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.Zootopia;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
