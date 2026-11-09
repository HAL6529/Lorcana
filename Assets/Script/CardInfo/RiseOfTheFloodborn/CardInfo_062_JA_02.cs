using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_062_JA_02 : CardInfo
{
    public CardInfo_062_JA_02()
    {
        this.cardNo = "062_JA_02";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "ï|Ç¢Ç±Ç∆ÅAéÑÇÕçDÇ´";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.MarianaMoreno;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.TheEmperorsNewGroove;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Rare;
    }
}
