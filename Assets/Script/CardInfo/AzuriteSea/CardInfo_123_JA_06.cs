using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_123_JA_06 : CardInfo
{
    public CardInfo_123_JA_06()
    {
        this.cardNo = "123_JA_06";
        this.inkCost = 6;
        this.availableInk = false;
        this.cardName1 = "グーフィー";
        this.cardName2 = "空飛ぶグーフ";
        this.power = 5;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.KennethAnderson;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Rush, EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
