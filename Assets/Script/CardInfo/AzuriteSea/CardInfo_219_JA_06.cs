using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_219_JA_06 : CardInfo
{
    public CardInfo_219_JA_06()
    {
        this.cardNo = "219_JA_06";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "We Could Be Immortals";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.IanMacDonald;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.BigHero6;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Enchanted;
    }
}
