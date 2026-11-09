using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_055_JA_02 : CardInfo
{
    public CardInfo_055_JA_02()
    {
        this.cardNo = "055_JA_02";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "ピーターパンの影";
        this.cardName2 = "ひらり逃走中";
        this.power = 2;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.GiuliaRiva;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Evasive, EnumController.KeywordAvility.Rush };
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.PeterPan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
