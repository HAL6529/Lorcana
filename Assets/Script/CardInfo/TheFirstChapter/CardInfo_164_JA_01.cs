using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_164_JA_01 : CardInfo
{
    public CardInfo_164_JA_01()
    {
        this.cardNo = "164_JA_01";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "ONE JUMP AHEAD";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = "Bill Robinson";
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Uncommon;
    }
}
