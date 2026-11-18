using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_187_JA_08 : CardInfo
{
    public CardInfo_187_JA_08()
    {
        this.cardNo = "187_JA_08";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "リー将軍";
        this.cardName2 = "皇軍大将";
        this.power = 2;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.KendallHale;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Mentor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Resist1 };
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Mulan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
