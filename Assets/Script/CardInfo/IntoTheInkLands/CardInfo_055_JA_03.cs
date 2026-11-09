using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_055_JA_03 : CardInfo
{
    public CardInfo_055_JA_03()
    {
        this.cardNo = "055_JA_03";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ストラトス";
        this.cardName2 = "トルネードタイタン";
        this.power = 4;
        this.toughness = 4;
        this.lore = 0;
        this.illustrator = EnumController.Illustrator.JaredNickerlAndAlicePisoni;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Titan };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
