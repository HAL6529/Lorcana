using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_110_JA_03 : CardInfo
{
    public CardInfo_110_JA_03()
    {
        this.cardNo = "110_JA_03";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ジム・ホーキンス";
        this.cardName2 = "スリルの追求者";
        this.power = 3;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MarcelBerg;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.TreasurePlanet;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
