using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_011_JA_06 : CardInfo
{
    public CardInfo_011_JA_06()
    {
        this.cardNo = "011_JA_06";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "É{ÉSèêí∑";
        this.cardName2 = "ÉKÉ[ÉãÇÃÉtÉ@Éì";
        this.power = 4;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.CristianRomero;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.Zootopia;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
