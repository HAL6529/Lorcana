using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_103_JA_14 : CardInfo
{
    public CardInfo_103_JA_14()
    {
        this.cardNo = "103_JA_14";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ヘイヘイ";
        this.cardName2 = "横断歩道渡り鶏";
        this.power = 3;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.BrianKesinger;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.Moana;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
