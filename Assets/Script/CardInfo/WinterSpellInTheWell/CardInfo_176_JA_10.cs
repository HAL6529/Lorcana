using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_176_JA_10 : CardInfo
{
    public CardInfo_176_JA_10()
    {
        this.cardNo = "176_JA_10";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "フランシーン";
        this.cardName2 = "一心不乱に証拠確認";
        this.power = 4;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.SandraRios;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Detective };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Resist1 };
        this.expansion = EnumController.Expansion.WinterSpellInTheWell;
        this.title = EnumController.Title.Zootopia;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
