using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_067_JA_03 : CardInfo
{
    public CardInfo_067_JA_03()
    {
        this.cardNo = "067_JA_03";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "èóâ§ÇÃèÈ";
        this.cardName2 = "ãæÇÃä‘";
        this.power = 1;
        this.toughness = 7;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MatthewOates;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.SleepingBeauty;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Rare;
    }
}
