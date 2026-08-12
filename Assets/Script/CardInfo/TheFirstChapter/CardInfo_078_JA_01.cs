using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_078_JA_01 : CardInfo
{
    public CardInfo_078_JA_01()
    {
        this.cardNo = "078_JA_01";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ÉnÉìÉX";
        this.cardName2 = "çÙó™â§éq!";
        this.power = 3;
        this.toughness = 3;
        this.lore = 3;
        this.illustrator = "Massimiliano Narciso";
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Prince};
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.Frozen;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
