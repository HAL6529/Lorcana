using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_176_JA_03 : CardInfo
{
    public CardInfo_176_JA_03()
    {
        this.cardNo = "176_JA_03";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ジョン・シルバー";
        this.cardName2 = "強欲な宝探し屋";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.GakuKumatori;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Villain, EnumController.Class.Alien, EnumController.Class.Pirate, EnumController.Class.Captain  };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.TreasurePlanet;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
