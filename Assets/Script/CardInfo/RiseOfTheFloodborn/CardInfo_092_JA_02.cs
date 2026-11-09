using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_092_JA_02 : CardInfo
{
    public CardInfo_092_JA_02()
    {
        this.cardNo = "092_JA_02";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "レイ";
        this.cardName2 = "お気楽ホタル";
        this.power = 3;
        this.toughness = 3;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.FilipeLaurentino;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.ThePrincessAndTheFrog;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
