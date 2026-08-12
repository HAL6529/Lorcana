using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_061_JA_01 : CardInfo
{
    public CardInfo_061_JA_01()
    {
        this.cardNo = "061_JA_01";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "É[ÉEÉX";
        this.cardName2 = "àÓç»ÇÃê_";
        this.power = 0;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = "Koni";
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Deity };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Challenger4, EnumController.KeywordAvility.Rush };
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
