using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_084_JA_08 : CardInfo
{
    public CardInfo_084_JA_08()
    {
        this.cardNo = "084_JA_08";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "氷の棘";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.PriyaKakati;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst, EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Frozen;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Uncommon;
    }
}
