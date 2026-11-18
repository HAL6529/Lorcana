using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_036_JA_08 : CardInfo
{
    public CardInfo_036_JA_08()
    {
        this.cardNo = "036_JA_08";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ジョーイ";
        this.cardName2 = "青のハト";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.FrenchCarlomagno;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Bolt;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
