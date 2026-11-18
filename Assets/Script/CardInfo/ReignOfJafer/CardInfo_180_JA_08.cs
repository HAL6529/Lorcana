using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_180_JA_08 : CardInfo
{
    public CardInfo_180_JA_08()
    {
        this.cardNo = "180_JA_08";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "アトランティスのクリスタル";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.Greez;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.AtlantisTheLostEmpire;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Rare;
    }
}
