using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_185_JA_01 : CardInfo
{
    public CardInfo_185_JA_01()
    {
        this.cardNo = "185_JA_01";
        this.inkCost = 8;
        this.availableInk = true;
        this.cardName1 = "マウイ";
        this.cardName2 = "半神半人";
        this.power = 8;
        this.toughness = 8;
        this.lore = 3;
        this.illustrator = "Isaiah Mesq";
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Deity };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.Moana;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
