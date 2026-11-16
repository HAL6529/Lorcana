using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_063_JA_06 : CardInfo
{
    public CardInfo_063_JA_06()
    {
        this.cardNo = "063_JA_06";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "–ÀŽq‚É‚È‚Á‚¿‚á‚¤‚í";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.DouglasDeLaHoz;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.AliceInWonderland;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Uncommon;
    }
}
