using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_188_JA_08 : CardInfo
{
    public CardInfo_188_JA_08()
    {
        this.cardNo = "188_JA_08";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "モンタリー・ジャック";
        this.cardName2 = "喧嘩っ早い用心棒";
        this.power = 4;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.RicardoCaria;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Chipmunk;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
