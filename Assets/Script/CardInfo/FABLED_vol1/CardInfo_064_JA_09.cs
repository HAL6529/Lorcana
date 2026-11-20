using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_064_JA_09 : CardInfo
{
    public CardInfo_064_JA_09()
    {
        this.cardNo = "064_JA_09";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "魔法の羽";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.MarianaMoreno;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.Fabled_vol1;
        this.title = EnumController.Title.Dumbo;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Rare;
    }
}
