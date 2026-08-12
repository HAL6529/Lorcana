using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_155_JA_01 : CardInfo
{
    public CardInfo_155_JA_01()
    {
        this.cardNo = "155_JA_01";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "ムファサ";
        this.cardName2 = "プライドランドの王";
        this.power = 4;
        this.toughness = 6;
        this.lore = 3;
        this.illustrator = "Luis Huerta";
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Mentor, EnumController.Class.King };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
