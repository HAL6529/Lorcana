using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_068_JA_11 : CardInfo
{
    public CardInfo_068_JA_11()
    {
        this.cardNo = "068_JA_11";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "凍りついたつる";
        this.cardName2 = "怪奇なる植物";
        this.power = 1;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.JeremyAdams;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.Lorcana;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Uncommon;
    }
}
