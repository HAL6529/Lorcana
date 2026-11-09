using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_163_JA_02 : CardInfo
{
    public CardInfo_163_JA_02()
    {
        this.cardNo = "163_JA_02";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "タマゴ4ダース";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.JochemVanGool;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Uncommon;
    }
}
