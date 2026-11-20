using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_206_JA_09 : CardInfo
{
    public CardInfo_206_JA_09()
    {
        this.cardNo = "206_JA_09";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "オーロラ";
        this.cardName2 = "姫のお披露目";
        this.power = 1;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JeannePlounevez;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.Fabled_vol1;
        this.title = EnumController.Title.SleepingBeauty;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Epic;
    }
}
