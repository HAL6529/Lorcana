using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_207_JA_12 : CardInfo
{
    public CardInfo_207_JA_12()
    {
        this.cardNo = "207_JA_12";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "イサベラ・マドリガル";
        this.cardName2 = "なんて素敵な声";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.LynnsMagicWorlds;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Madrigal };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.Encanto;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Epic;
    }
}
