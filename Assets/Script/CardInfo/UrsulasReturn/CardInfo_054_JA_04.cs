using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_054_JA_04 : CardInfo
{
    public CardInfo_054_JA_04()
    {
        this.cardNo = "054_JA_04";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "ピーター・パン";
        this.cardName2 = "影の追跡者";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.EmilyAbeydeera;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Rush, EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.PeterPan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
