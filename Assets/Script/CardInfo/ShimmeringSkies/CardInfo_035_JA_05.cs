using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_035_JA_05 : CardInfo
{
    public CardInfo_035_JA_05()
    {
        this.cardNo = "035_JA_05";
        this.inkCost = 8;
        this.availableInk = false;
        this.cardName1 = "マレフィセント";
        this.cardName2 = "恐ろしい女王";
        this.power = 7;
        this.toughness = 7;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MaliaEwart;
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn, EnumController.Class.Villain, EnumController.Class.Queen, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift6 };
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.SleepingBeauty;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
