using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_152_JA_02 : CardInfo
{
    public CardInfo_152_JA_02()
    {
        this.cardNo = "152_JA_02";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ジュディ・ホップス";
        this.cardName2 = "やる気いっぱいの警官";
        this.power = 2;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.AriannaRea;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.Zootopia;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
