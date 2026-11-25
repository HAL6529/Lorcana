using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_143_JA_13 : CardInfo
{
    public CardInfo_143_JA_13()
    {
        this.cardNo = "143_JA_13";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ランチパッド";
        this.cardName2 = "空のパトロール";
        this.power = 3;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.LissetteCarrera;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Alert };
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.DuckTales;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
