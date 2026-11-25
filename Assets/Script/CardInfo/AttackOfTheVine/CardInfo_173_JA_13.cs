using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_173_JA_13 : CardInfo
{
    public CardInfo_173_JA_13()
    {
        this.cardNo = "173_JA_13";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "翻訳首輪";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.PeterBrockhammer;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.Up;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Rare;
    }
}
