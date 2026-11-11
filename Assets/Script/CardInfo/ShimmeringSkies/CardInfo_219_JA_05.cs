using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_219_JA_05 : CardInfo
{
    public CardInfo_219_JA_05()
    {
        this.cardNo = "219_JA_05";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "‰¤‘°‚Ì‚©‚ñ‚µ‚á‚­";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.JenniferWu;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.RobinHood;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Enchanted;
    }
}
