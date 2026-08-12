using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_127_JA_01 : CardInfo
{
    public CardInfo_127_JA_01()
    {
        this.cardNo = "127_JA_01";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "ティガー";
        this.cardName2 = "世界一のオレ様";
        this.power = 4;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = "Kenneth Anderson";
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Deity };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Reckless };
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.Moana;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
