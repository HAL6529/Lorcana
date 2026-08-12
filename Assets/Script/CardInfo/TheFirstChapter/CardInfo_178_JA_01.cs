using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_178_JA_01 : CardInfo
{
    public CardInfo_178_JA_01()
    {
        this.cardNo = "178_JA_01";
        this.inkCost = 8;
        this.availableInk = true;
        this.cardName1 = "ƒKƒ“ƒgƒD";
        this.cardName2 = "‹â‰Í˜A–M‘åˆÑ";
        this.power = 6;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = "Luis Huerta";
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Alien, EnumController.Class.Captain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.LiloAndStitch;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}
