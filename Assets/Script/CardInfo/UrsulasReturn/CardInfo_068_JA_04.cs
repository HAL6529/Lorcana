using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_068_JA_04 : CardInfo
{
    public CardInfo_068_JA_04()
    {
        this.cardNo = "068_JA_04";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "ÉAÅ[ÉXÉâÇÃâBÇÍâ∆";
        this.cardName2 = "óíÇÃñ⁄";
        this.power = 2;
        this.toughness = 6;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.EriWelliAndSamBurley;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.TheLittleMermaid;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Rare;
    }
}
