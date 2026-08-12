using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_118_JA_01 : CardInfo
{
    public CardInfo_118_JA_01()
    {
        this.cardNo = "118_JA_01";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ÉÄÅ[ÉâÉì";
        this.cardName2 = "íÈçëÇÃï∫ém";
        this.power = 4;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = "Mel Milton";
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.Mulan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
