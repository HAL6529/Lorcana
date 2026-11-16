using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_185_JA_06 : CardInfo
{
    public CardInfo_185_JA_06()
    {
        this.cardNo = "185_JA_06";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ビリー・ボーンズ";
        this.cardName2 = "宇宙の船員";
        this.power = 2;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.DiogoSaito;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Alien, EnumController.Class.Pirate};
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.TreasurePlanet;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
