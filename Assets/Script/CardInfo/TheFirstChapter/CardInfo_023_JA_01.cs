using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_023_JA_01 : CardInfo
{
    public CardInfo_023_JA_01()
    {
        this.cardNo = "023_JA_01";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "スティッチ";
        this.cardName2 = "ロックスター";
        this.power = 3;
        this.toughness = 5;
        this.lore = 3;
        this.illustrator = "Simangaliso Shibaya";
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Hero, EnumController.Class.Alien };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Shift4};
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.LiloAndStitch;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
