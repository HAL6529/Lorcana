using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_077_JA_08 : CardInfo
{
    public CardInfo_077_JA_08()
    {
        this.cardNo = "077_JA_08";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "森の決闘";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.VivTanner;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Bambi;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Uncommon;
    }
}
