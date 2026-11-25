using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_070_JA_13 : CardInfo
{
    public CardInfo_070_JA_13()
    {
        this.cardNo = "070_JA_13";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "割れたさや";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.AlexAccorsiAndLeonardoGiammichele;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.Lorcana;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Uncommon;
    }
}
