using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_078_JA_02 : CardInfo
{
    public CardInfo_078_JA_02()
    {
        this.cardNo = "078_JA_02";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ドナルドダック";
        this.cardName2 = "夢遊病者";
        this.power = 0;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.LeonardoGiammichele;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
