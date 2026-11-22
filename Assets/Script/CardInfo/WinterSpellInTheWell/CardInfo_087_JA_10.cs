using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_087_JA_10 : CardInfo
{
    public CardInfo_087_JA_10()
    {
        this.cardNo = "087_JA_10";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ゴールディ・オギルト";
        this.cardName2 = "抜け目ない探鉱者";
        this.power = 3;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JiahuiEvaGao;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpellInTheWell;
        this.title = EnumController.Title.DuckTales;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
