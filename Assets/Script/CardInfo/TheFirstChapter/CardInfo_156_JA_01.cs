using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_156_JA_01 : CardInfo
{
    public CardInfo_156_JA_01()
    {
        this.cardNo = "156_JA_01";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ピロクテテス";
        this.cardName2 = "ヒーロー育成名人";
        this.power = 3;
        this.toughness = 1;
        this.lore = 1;
        this.illustrator = "Leonardo Giammichele";
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Mentor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Support };
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
