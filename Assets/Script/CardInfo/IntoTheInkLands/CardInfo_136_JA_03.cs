using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_136_JA_03 : CardInfo
{
    public CardInfo_136_JA_03()
    {
        this.cardNo = "136_JA_03";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "RLSレガシー号";
        this.cardName2 = "ソーラーガレオン";
        this.power = 3;
        this.toughness = 8;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.WietseTreurniet;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.TreasurePlanet;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Rare;
    }
}
