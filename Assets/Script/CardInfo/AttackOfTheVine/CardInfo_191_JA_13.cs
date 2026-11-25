using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_191_JA_13 : CardInfo
{
    public CardInfo_191_JA_13()
    {
        this.cardNo = "191_JA_13";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "クロンク";
        this.cardName2 = "ムドカの店の料理人";
        this.power = 1;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.DiegoMachuca;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Resist1 };
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.TheEmperorsNewGroove;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
