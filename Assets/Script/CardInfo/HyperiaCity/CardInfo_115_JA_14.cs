using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_115_JA_14 : CardInfo
{
    public CardInfo_115_JA_14()
    {
        this.cardNo = "115_JA_14";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ペグ";
        this.cardName2 = "深夜の歌姫";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.RaquelVillanueva;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Singer4 };
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.LadyAndTheTramp;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
