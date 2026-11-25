using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_107_JA_13 : CardInfo
{
    public CardInfo_107_JA_13()
    {
        this.cardNo = "107_JA_13";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "ヴァインズのさや";
        this.cardName2 = "注文の多いお客様";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.SarahSchmidt;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.Lorcana;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
