using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_167_JA_05 : CardInfo
{
    public CardInfo_167_JA_05()
    {
        this.cardNo = "167_JA_05";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "マーリンのカーペットバッグ";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.GakuKumatori;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.TheSwordInTheStone;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Uncommon;
    }
}
