using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_064_JA_06 : CardInfo
{
    public CardInfo_064_JA_06()
    {
        this.cardNo = "064_JA_06";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "Š„‚ê‚½‰¤Š¥‚ð‚à‚Æ‚ß‚Ä";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.FrenchCarlomagno;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.Lorcana;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Rare;
    }
}
