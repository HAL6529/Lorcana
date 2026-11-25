using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_171_JA_13 : CardInfo
{
    public CardInfo_171_JA_13()
    {
        this.cardNo = "171_JA_13";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "ハナのインクキャスター";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.MoniekSchilder;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.Lorcana;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Uncommon;
    }
}
