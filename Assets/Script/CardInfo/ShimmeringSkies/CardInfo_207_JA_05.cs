using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_207_JA_05 : CardInfo
{
    public CardInfo_207_JA_05()
    {
        this.cardNo = "207_JA_05";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "‘å‚¢‚È‚é–ü‚µ";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.AishaDurmagambetova;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.Tangled;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Enchanted;
    }
}
