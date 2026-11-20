using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_218_JA_09 : CardInfo
{
    public CardInfo_218_JA_09()
    {
        this.cardNo = "218_JA_09";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "アナ";
        this.cardName2 = "嵐に立ち向かう者";
        this.power = 1;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MariaDresden;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Queen };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.Fabled_vol1;
        this.title = EnumController.Title.Frozen;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Epic;
    }
}
