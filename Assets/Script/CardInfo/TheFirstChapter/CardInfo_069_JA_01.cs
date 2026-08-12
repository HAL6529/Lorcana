using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_069_JA_01 : CardInfo
{
    public CardInfo_069_JA_01()
    {
        this.cardNo = "069_JA_01";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "アラジン";
        this.cardName2 = "アリ王子";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = "Lauren Walsh";
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Prince };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Ward };
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
