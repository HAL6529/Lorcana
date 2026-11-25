using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_037_JA_13 : CardInfo
{
    public CardInfo_037_JA_13()
    {
        this.cardNo = "037_JA_13";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ラプンツェルの塔";
        this.cardName2 = "ヴァインズの支配下";
        this.power = 1;
        this.toughness = 8;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.HaJungSong;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber};
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.Tangled;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Uncommon;
    }
}
