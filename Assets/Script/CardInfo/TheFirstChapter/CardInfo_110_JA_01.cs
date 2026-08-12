using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_110_JA_01 : CardInfo
{
    public CardInfo_110_JA_01()
    {
        this.cardNo = "110_JA_01";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ガストン";
        this.cardName2 = "尊大なハンター";
        this.power = 4;
        this.toughness = 2;
        this.lore = 0;
        this.illustrator = "Matthew Robert Davies";
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Reckless };
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
