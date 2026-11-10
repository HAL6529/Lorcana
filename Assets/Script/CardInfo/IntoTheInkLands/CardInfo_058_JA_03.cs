using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_058_JA_03 : CardInfo
{
    public CardInfo_058_JA_03()
    {
        this.cardNo = "058_JA_03";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "ç‡ïÛÇÃéÁåÏé“";
        this.cardName2 = "ì¥åAÇÃî‘êl";
        this.power = 6;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.HedvigH_S;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.TreasurePlanet;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
