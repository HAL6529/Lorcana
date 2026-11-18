using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_055_JA_08 : CardInfo
{
    public CardInfo_055_JA_08()
    {
        this.cardNo = "055_JA_08";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "イエレナ";
        this.cardName2 = "ノーサルドラの指導者";
        this.power = 2;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.AishDurmagmbetova;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Frozen;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
