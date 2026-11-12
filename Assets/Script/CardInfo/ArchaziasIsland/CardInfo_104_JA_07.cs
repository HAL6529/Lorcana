using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_104_JA_07 : CardInfo
{
    public CardInfo_104_JA_07()
    {
        this.cardNo = "104_JA_07";
        this.inkCost = 6;
        this.availableInk = false;
        this.cardName1 = "ベイマックス";
        this.cardName2 = "巨大ロボット";
        this.power = 5;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.ValerioBuonfantino;
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn, EnumController.Class.Hero, EnumController.Class.Robot};
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald, EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.UniversalShift4 };
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.BigHero6;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
