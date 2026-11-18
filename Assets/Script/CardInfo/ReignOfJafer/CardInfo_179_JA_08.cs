using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_179_JA_08 : CardInfo
{
    public CardInfo_179_JA_08()
    {
        this.cardNo = "179_JA_08";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "ベルのお気に入りの本";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.EdgarPasten;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Rare;
    }
}
