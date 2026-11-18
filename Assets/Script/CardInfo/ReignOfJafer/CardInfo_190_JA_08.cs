using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_190_JA_08 : CardInfo
{
    public CardInfo_190_JA_08()
    {
        this.cardNo = "190_JA_08";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "トビー・タートル";
        this.cardName2 = "用心深い友だち";
        this.power = 0;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.IrishChua;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.RobinHood;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
