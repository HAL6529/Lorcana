using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_148_JA_12 : CardInfo
{
    public CardInfo_148_JA_12()
    {
        this.cardNo = "148_JA_12";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ジッパー";
        this.cardName2 = "フライ級の助っ人";
        this.power = 0;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.NatalieDombois;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.Chipmunk;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
