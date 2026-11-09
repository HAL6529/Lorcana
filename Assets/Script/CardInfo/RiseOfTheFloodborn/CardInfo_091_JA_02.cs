using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_091_JA_02 : CardInfo
{
    public CardInfo_091_JA_02()
    {
        this.cardNo = "091_JA_02";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ÉâÉeÉBÉKÉì";
        this.cardName2 = "î∆çﬂâ§";
        this.power = 4;
        this.toughness = 1;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MichaelaMartin;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.TheGreatMouseDetective;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
