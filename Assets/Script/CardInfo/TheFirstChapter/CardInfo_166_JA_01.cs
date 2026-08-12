using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_166_JA_01 : CardInfo
{
    public CardInfo_166_JA_01()
    {
        this.cardNo = "166_JA_01";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ココナッツのかご";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = "Milica Celikovic";
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.Moana;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Uncommon;
    }
}
