using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_110_JA_02 : CardInfo
{
    public CardInfo_110_JA_02()
    {
        this.cardNo = "110_JA_02";
        this.inkCost = 6;
        this.availableInk = false;
        this.cardName1 = "トレメイン夫人";
        this.cardName2 = "横柄な女王";
        this.power = 3;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.AriannaRea;
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn, EnumController.Class.Villain, EnumController.Class.Queen };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Shift4 };
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.Cinderella;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
