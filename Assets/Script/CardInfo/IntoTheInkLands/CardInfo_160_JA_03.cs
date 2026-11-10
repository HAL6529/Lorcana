using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_160_JA_03 : CardInfo
{
    public CardInfo_160_JA_03()
    {
        this.cardNo = "160_JA_03";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "Friend Like Me";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.EmilyAbeydeera;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Rare;
    }
}
