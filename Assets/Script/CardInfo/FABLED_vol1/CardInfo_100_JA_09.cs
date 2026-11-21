using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_100_JA_09 : CardInfo
{
    public CardInfo_100_JA_09()
    {
        this.cardNo = "100_JA_09";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "グーフィー家の釣り竿";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.CarlosRuiz;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.Fabled_vol1;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Rare;
    }
}
