using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_124_JA_13 : CardInfo
{
    public CardInfo_124_JA_13()
    {
        this.cardNo = "124_JA_13";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "ドナルドダック";
        this.cardName2 = "ヴァインリング乗り";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.LissetteCarrera;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Rush };
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
