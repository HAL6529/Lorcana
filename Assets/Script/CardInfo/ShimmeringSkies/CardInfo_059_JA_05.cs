using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_059_JA_05 : CardInfo
{
    public CardInfo_059_JA_05()
    {
        this.cardNo = "059_JA_05";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ç√ñ∞èpÇÃóÕ";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.GiuliaRiva;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Common;
    }
}
