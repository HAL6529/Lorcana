using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_088_JA_06 : CardInfo
{
    public CardInfo_088_JA_06()
    {
        this.cardNo = "088_JA_06";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ÉKÉ[Éã";
        this.cardName2 = "ç≈çÇÇÃâÃïPÇ≈ìVég";
        this.power = 1;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.WouterBruneel;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.Zootopia;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
