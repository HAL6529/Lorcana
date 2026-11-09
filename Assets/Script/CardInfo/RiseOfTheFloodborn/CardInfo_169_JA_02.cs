using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_169_JA_02 : CardInfo
{
    public CardInfo_169_JA_02()
    {
        this.cardNo = "169_JA_02";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "アイスポー";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.IsaiahMesq;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.Zootopia;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Common;
    }
}
