using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_182_JA_01 : CardInfo
{
    public CardInfo_182_JA_01()
    {
        this.cardNo = "182_JA_01";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "クリストフ";
        this.cardName2 = "王室御用達氷職人";
        this.power = 3;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = "Ron Baird";
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.Frozen;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
