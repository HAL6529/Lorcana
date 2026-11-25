using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_101_JA_13 : CardInfo
{
    public CardInfo_101_JA_13()
    {
        this.cardNo = "101_JA_13";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "花も枯れるぅ！ヘッヘッヘ！";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.KasiaBrzezinska;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.TheSwordInTheStone;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Rare;
    }
}
