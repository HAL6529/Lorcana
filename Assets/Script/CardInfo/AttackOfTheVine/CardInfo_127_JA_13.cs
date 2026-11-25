using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_127_JA_13 : CardInfo
{
    public CardInfo_127_JA_13()
    {
        this.cardNo = "127_JA_13";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "ブー";
        this.cardName2 = "元気いっぱいの子ども";
        this.power = 0;
        this.toughness = 1;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MaliaEwart;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Rush };
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.MonstersInc;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
