using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_146_JA_02 : CardInfo
{
    public CardInfo_146_JA_02()
    {
        this.cardNo = "146_JA_02";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "デューク・ウィーゼルトン";
        this.cardName2 = "ちんけなイカサマ師";
        this.power = 1;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.R_laBarberaAndL_Giammichele;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Ward };
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.Zootopia;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
