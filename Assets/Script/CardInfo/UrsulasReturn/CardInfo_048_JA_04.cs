using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_048_JA_04 : CardInfo
{
    public CardInfo_048_JA_04()
    {
        this.cardNo = "048_JA_04";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "魔法のほうき";
        this.cardName2 = "イルミナの保守係";
        this.power = 1;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.EvaWidermann;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Broom};
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Fantasia;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
