using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_166_JA_04 : CardInfo
{
    public CardInfo_166_JA_04()
    {
        this.cardNo = "166_JA_04";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ïXÇÃêw";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.MarianaMoreno;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Frozen;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Rare;
    }
}
