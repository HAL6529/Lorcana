using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_012_JA_02 : CardInfo
{
    public CardInfo_012_JA_02()
    {
        this.cardNo = "012_JA_02";
        this.inkCost = 7;
        this.availableInk = true;
        this.cardName1 = "キング・ルーイ";
        this.cardName2 = "ジャングルの大物";
        this.power = 3;
        this.toughness = 8;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.HadjieJoos;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.King };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.TheJungleBook;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
