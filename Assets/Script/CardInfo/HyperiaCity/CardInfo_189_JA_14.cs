using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_189_JA_14 : CardInfo
{
    public CardInfo_189_JA_14()
    {
        this.cardNo = "189_JA_14";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "コスロフ";
        this.cardName2 = "威圧的な用心棒";
        this.power = 4;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.OttoParedes;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.Zootopia;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
